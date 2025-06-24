using System.ComponentModel;
using ImageMagick;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;
using DwVideo.utils;

namespace DwVideo
{
    public partial class Video : UserControl
    {
        private string download_path;
        private string type;
        private string? resolution;
        private IStreamInfo streamManifest;
        private IStreamInfo videoStreamManifest;

        public async void Download()
        {
            string url = Tag.Text;
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(url);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);

            var progress = new Progress<double>(p => {
                ProgressValue = (int)Math.Floor(p * 100);
                PorcentLabel.Text = $"{ProgressValue}%";
            });

            TagText = video.Title;

            StreamManifest = streamManifest.GetAudioStreams().GetWithHighestBitrate();

            if(type == "Audio")
            {
                await youtube.Videos.Streams.DownloadAsync(StreamManifest, Path.Combine(download_path, $"{ValidateName.LimpiarNombreArchivo(video.Title)}.mp3"), progress);
            }
            else if(type == "Video")
            {
                VideoStreamManifest = streamManifest
                    .GetVideoStreams()
                    .FirstOrDefault(s => s.VideoQuality.Label == resolution);

                var rutaFFmpeg = Path.Combine($"{AppDomain.CurrentDomain.BaseDirectory}\\tools", "ffmpeg.exe");

                var title_audio = $"{ValidateName.LimpiarNombreArchivo(video.Title)}.mp3";
                var title_video = $"{ValidateName.LimpiarNombreArchivo(video.Title)}.mp4";

                await youtube.Videos.Streams.DownloadAsync(
                    StreamManifest,
                    Path.Combine(download_path, title_audio)
                    );

                await youtube.Videos.Streams.DownloadAsync(
                    VideoStreamManifest,
                    Path.Combine(download_path, title_video), 
                    progress
                    );

                var input_video = Path.Combine(download_path, title_video);
                var input_audio = Path.Combine(download_path, title_audio);
                var output = Path.Combine(download_path, $"output_{title_video}");

                string argumentos = $"-i \"{input_video}\" -i \"{input_audio}\" -c:v copy -c:a aac -strict experimental -map 0:v:0 -map 1:a:0 \"{output}\"";

                var proceso = new System.Diagnostics.Process
                {
                    StartInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = rutaFFmpeg,
                        Arguments = argumentos,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                proceso.Start();
            }
        }

        private async void LoadThumbnailAsync(string videoUrl)
        {
            try
            {
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(videoUrl);
                string thumbnailUrl = video.Thumbnails.GetWithHighestResolution().Url;

                using (var magickImage = new MagickImage(thumbnailUrl))
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        // Convierte la imagen WebP a PNG
                        magickImage.Write(memoryStream, MagickFormat.Png);
                        memoryStream.Position = 0;

                        // Carga la imagen convertida en el PictureBox
                        PictureSrc = Image.FromStream(memoryStream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading thumbnail: {ex.Message}");
            }
        }

        public Video(string url, string download_path, string _type = "Video", string? _resolution = null)
        {
            InitializeComponent();
            DownloadPath = download_path;
            Type = _type;
            Resolution = _resolution;
            LoadThumbnailAsync(url);
        }

        [Category("Comportamiento")]
        [Description("Establece o obtiene el titulo del video.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TagText
        {
            get => Tag.Text;
            set => Tag.Text = value;
        }

        [Category("Comportamiento")]
        [Description("Establece o obtiene la ruta de la imagen.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image PictureSrc
        {
            get => picture.Image;
            set => picture.Image = value;
        }

        [Category("Comportamiento")]
        [Description("Establece o obtiene el porcentaje de descarga.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ProgressValue
        {
            get => progressBar.Value;
            set => progressBar.Value = value;
        }

        [Category("Comportamiento")]
        [Description("Establece o obtiene la ruta de descarga del video.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DownloadPath
        {
            get => download_path;
            set => download_path = value;
        }

        [Category("Comportamiento")]
        [Description("Establece o obtiene el tipo de archivo a descargar.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Type
        {
            get => type;
            set => type = value;
        }

        [Category("Comportamiento")]
        [Description("Establece o obtiene la resolucion en caso de ser un video.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? Resolution
        {
            get => resolution;
            set => resolution = value;
        }

        [Category("Comportamiento")]
        [Description("Establece o obtiene el manifiesto del stream.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IStreamInfo StreamManifest
        {
            get => streamManifest;
            set => streamManifest = value;
        }

        [Category("Comportamiento")]
        [Description("Establece o obtiene el manifiesto del stream del video.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IStreamInfo VideoStreamManifest
        {
            get => videoStreamManifest;
            set => videoStreamManifest = value;
        }
    }
}
