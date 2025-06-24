namespace DwVideo
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            search_input = new TextBox();
            TopPanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            ResolutionOption = new ComboBox();
            TypeOption = new ComboBox();
            panel1 = new Panel();
            Search = new Button();
            activities = new Panel();
            menu = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            rutaDeDescargaToolStripMenuItem = new ToolStripMenuItem();
            TopPanel.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // search_input
            // 
            search_input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            search_input.Font = new Font("Segoe UI", 12F);
            search_input.Location = new Point(478, 56);
            search_input.Margin = new Padding(4, 5, 4, 5);
            search_input.Name = "search_input";
            search_input.Size = new Size(365, 39);
            search_input.TabIndex = 0;
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(label2);
            TopPanel.Controls.Add(label1);
            TopPanel.Controls.Add(ResolutionOption);
            TopPanel.Controls.Add(TypeOption);
            TopPanel.Controls.Add(panel1);
            TopPanel.Controls.Add(Search);
            TopPanel.Controls.Add(search_input);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 35);
            TopPanel.Margin = new Padding(4, 5, 4, 5);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1102, 132);
            TopPanel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(200, 21);
            label2.Name = "label2";
            label2.Size = new Size(146, 32);
            label2.TabIndex = 8;
            label2.Text = "Resolución ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 7;
            label1.Text = "Tipo";
            // 
            // ResolutionOption
            // 
            ResolutionOption.FormattingEnabled = true;
            ResolutionOption.Items.AddRange(new object[] { "1080p", "720p", "480p", "360p", "240p" });
            ResolutionOption.Location = new Point(200, 57);
            ResolutionOption.Name = "ResolutionOption";
            ResolutionOption.Size = new Size(182, 33);
            ResolutionOption.TabIndex = 6;
            // 
            // TypeOption
            // 
            TypeOption.FormattingEnabled = true;
            TypeOption.Items.AddRange(new object[] { "Video", "Audio" });
            TypeOption.Location = new Point(12, 56);
            TypeOption.Name = "TypeOption";
            TypeOption.Size = new Size(182, 33);
            TypeOption.TabIndex = 5;
            TypeOption.SelectedIndexChanged += TypeOption_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 142);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 167);
            panel1.TabIndex = 2;
            // 
            // Search
            // 
            Search.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Search.Location = new Point(854, 56);
            Search.Margin = new Padding(4, 5, 4, 5);
            Search.Name = "Search";
            Search.Size = new Size(107, 38);
            Search.TabIndex = 1;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // activities
            // 
            activities.BackColor = Color.FromArgb(10, 10, 64);
            activities.Dock = DockStyle.Fill;
            activities.Location = new Point(0, 167);
            activities.Margin = new Padding(4, 5, 4, 5);
            activities.Name = "activities";
            activities.Size = new Size(1102, 577);
            activities.TabIndex = 2;
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(9, 3, 0, 3);
            menu.Size = new Size(1102, 35);
            menu.TabIndex = 3;
            menu.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rutaDeDescargaToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(103, 29);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // rutaDeDescargaToolStripMenuItem
            // 
            rutaDeDescargaToolStripMenuItem.Name = "rutaDeDescargaToolStripMenuItem";
            rutaDeDescargaToolStripMenuItem.Size = new Size(253, 34);
            rutaDeDescargaToolStripMenuItem.Text = "Ruta de Descarga";
            rutaDeDescargaToolStripMenuItem.Click += rutaDeDescargaToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 64);
            ClientSize = new Size(1102, 744);
            Controls.Add(activities);
            Controls.Add(TopPanel);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1124, 800);
            MinimumSize = new Size(1124, 800);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DwVideo";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox search_input;
        private Panel TopPanel;
        private Button Search;
        private Panel panel1;
        private Panel activities;
        private MenuStrip menu;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem rutaDeDescargaToolStripMenuItem;
        private Label label2;
        private Label label1;
        private ComboBox ResolutionOption;
        private ComboBox TypeOption;
    }
}
