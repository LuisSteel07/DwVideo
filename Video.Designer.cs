namespace DwVideo
{
    partial class Video
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Tag = new Label();
            picture = new PictureBox();
            progressBar = new ProgressBar();
            PorcentLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // Tag
            // 
            Tag.AutoSize = true;
            Tag.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tag.ForeColor = Color.White;
            Tag.Location = new Point(271, 17);
            Tag.Margin = new Padding(4, 0, 4, 0);
            Tag.Name = "Tag";
            Tag.Size = new Size(0, 41);
            Tag.TabIndex = 0;
            // 
            // picture
            // 
            picture.BackColor = SystemColors.Control;
            picture.Location = new Point(7, 8);
            picture.Margin = new Padding(4, 5, 4, 5);
            picture.Name = "picture";
            picture.Size = new Size(257, 233);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabIndex = 1;
            picture.TabStop = false;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(271, 200);
            progressBar.Margin = new Padding(4, 5, 4, 5);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(477, 38);
            progressBar.TabIndex = 2;
            // 
            // PorcentLabel
            // 
            PorcentLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PorcentLabel.AutoSize = true;
            PorcentLabel.ForeColor = Color.White;
            PorcentLabel.Location = new Point(674, 170);
            PorcentLabel.Margin = new Padding(4, 0, 4, 0);
            PorcentLabel.Name = "PorcentLabel";
            PorcentLabel.Size = new Size(0, 25);
            PorcentLabel.TabIndex = 3;
            // 
            // Video
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(40, 20, 80);
            Controls.Add(PorcentLabel);
            Controls.Add(progressBar);
            Controls.Add(picture);
            Controls.Add(Tag);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Video";
            Size = new Size(1154, 250);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tag;
        private PictureBox picture;
        private ProgressBar progressBar;
        private Label PorcentLabel;
    }
}
