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
            DownloadPathControl = "C:\\Users\\luisd\\Downloads";
            TypeOption.SelectedIndex = 0;
            ResolutionOption.SelectedIndex = 0;
        }

        private void confirm_download(Video video_component)
        {
            Thread confirm_down = new Thread(() =>
            {
                while (true)
                {
                    if (video_component.ProgressValue == 100)
                    {
                        if (activities.InvokeRequired)
                        {
                            activities.Invoke(new Action(() =>
                            {
                                if (activities.Controls.Count > 0)
                                {
                                    activities.Controls.RemoveAt(0);
                                }
                            }));
                        }
                        break;
                    }
                    Thread.Sleep(100);
                }
            });

            confirm_down.IsBackground = true;
            confirm_down.Start();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (search_input.Text != "")
            {
                Video video_component = new Video(search_input.Text, DownloadPathControl, TypeOption.SelectedItem.ToString(), ResolutionOption.SelectedItem.ToString())
                {
                    TagText = search_input.Text,
                    DownloadPath = DownloadPathControl
                };

                activities.Controls.Add(video_component);
                confirm_download(video_component);
                video_component.Download();
            }
            else
            {
                MessageBox.Show("Debe de colocar una url.", "Advertencia", MessageBoxButtons.OK);
            }
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

        private void TypeOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TypeOption.SelectedItem.ToString() == "Audio")
            {
                ResolutionOption.Enabled = false;
            }
            else
            {
                ResolutionOption.Enabled = true;
            }
        }
    }
}
