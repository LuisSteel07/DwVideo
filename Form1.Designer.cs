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
            search_input.Location = new Point(218, 26);
            search_input.Name = "search_input";
            search_input.Size = new Size(257, 29);
            search_input.TabIndex = 0;
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(panel1);
            TopPanel.Controls.Add(Search);
            TopPanel.Controls.Add(search_input);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 24);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(800, 79);
            TopPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 2;
            // 
            // Search
            // 
            Search.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Search.Location = new Point(481, 30);
            Search.Name = "Search";
            Search.Size = new Size(75, 23);
            Search.TabIndex = 1;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // activities
            // 
            activities.BackColor = Color.FromArgb(10, 10, 64);
            activities.Dock = DockStyle.Fill;
            activities.Location = new Point(0, 103);
            activities.Name = "activities";
            activities.Size = new Size(800, 347);
            activities.TabIndex = 2;
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 24);
            menu.TabIndex = 3;
            menu.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rutaDeDescargaToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(69, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // rutaDeDescargaToolStripMenuItem
            // 
            rutaDeDescargaToolStripMenuItem.Name = "rutaDeDescargaToolStripMenuItem";
            rutaDeDescargaToolStripMenuItem.Size = new Size(180, 22);
            rutaDeDescargaToolStripMenuItem.Text = "Ruta de Descarga";
            rutaDeDescargaToolStripMenuItem.Click += rutaDeDescargaToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(activities);
            Controls.Add(TopPanel);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "Main";
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
    }
}
