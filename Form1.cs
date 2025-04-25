using System.ComponentModel;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;

namespace DwVideo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DownloadPathControl = "C:\\Users\\samsung\\Documents\\Trabajo";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Video video_component = new Video(search_input.Text, DownloadPathControl)
            {
                TagText = search_input.Text
            };

            activities.Controls.Add(video_component);
            video_component.Download();

            //Thread confirm_down = new Thread(() =>
            //{
            //    while (true)
            //    {
            //        if(video_component.ProgressValue == 100)
            //        {
            //            activities.Controls.Clear();
            //        }
            //    }
            //});

            //confirm_down.Start();
        }

        private void rutaDeDescargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Multiselect = false;
            folderBrowserDialog.ShowDialog();

            DownloadPathControl = folderBrowserDialog.SelectedPath;
        }

        [Category("Comportamiento")]
        [Description("Establece o obtiene la ruta de descarga del video.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DownloadPathControl;
}
}
