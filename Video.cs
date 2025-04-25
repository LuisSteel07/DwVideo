using System.ComponentModel;
using ImageMagick;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos.Streams;

namespace DwVideo
{
    public partial class Video : UserControl
    {
        public async void Download()
        {
            string url = Tag.Text;
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(url);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(url);
            var streamInfo = streamManifest.GetAudioStreams().GetWithHighestBitrate();

            var progress = new Progress<double>(p => {
                ProgressValue = (int)Math.Floor(p * 100);
                PorcentLabel.Text = $"{ProgressValue}%";
            });

            TagText = video.Title;
            await youtube.Videos.Streams.DownloadAsync(streamInfo, Path.Combine(DownloadPath, $"{video.Title}.mp3"), progress);
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

        public Video(string url, string download_path)
        {
            InitializeComponent();
            LoadThumbnailAsync(url);
            DownloadPath = download_path;
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
            get => DownloadPath;
            set => DownloadPath = value;
        }
    }
}
