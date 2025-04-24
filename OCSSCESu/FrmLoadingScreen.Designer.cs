namespace OCSSCESu
{
    partial class FrmLoadingScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dataRetrieveProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.laodingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::OCSSCESu.Properties.Resources.logo_v4_1;
            this.guna2PictureBox1.Location = new System.Drawing.Point(5, 33);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(521, 135);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // dataRetrieveProgressBar
            // 
            this.dataRetrieveProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.dataRetrieveProgressBar.Location = new System.Drawing.Point(28, 198);
            this.dataRetrieveProgressBar.Name = "dataRetrieveProgressBar";
            this.dataRetrieveProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dataRetrieveProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dataRetrieveProgressBar.ShadowDecoration.Parent = this.dataRetrieveProgressBar;
            this.dataRetrieveProgressBar.Size = new System.Drawing.Size(478, 10);
            this.dataRetrieveProgressBar.TabIndex = 1;
            this.dataRetrieveProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // laodingLabel
            // 
            this.laodingLabel.AutoSize = true;
            this.laodingLabel.ForeColor = System.Drawing.Color.White;
            this.laodingLabel.Location = new System.Drawing.Point(24, 176);
            this.laodingLabel.Name = "laodingLabel";
            this.laodingLabel.Size = new System.Drawing.Size(122, 19);
            this.laodingLabel.TabIndex = 2;
            this.laodingLabel.Text = "Loading resources. . .";
            // 
            // FrmLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(530, 241);
            this.Controls.Add(this.laodingLabel);
            this.Controls.Add(this.dataRetrieveProgressBar);
            this.Controls.Add(this.guna2PictureBox1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoadingScreen";
            this.Load += new System.EventHandler(this.FrmLoadingScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ProgressBar dataRetrieveProgressBar;
        private System.Windows.Forms.Label laodingLabel;
    }
}