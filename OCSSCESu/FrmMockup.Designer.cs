namespace OCSSCESu
{
    partial class FrmMockup
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
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 16;
            this.closeBtn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.closeBtn.HoverState.Parent = this.closeBtn;
            this.closeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.Location = new System.Drawing.Point(1004, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShadowDecoration.Parent = this.closeBtn;
            this.closeBtn.Size = new System.Drawing.Size(32, 32);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(142)))), ((int)(((byte)(74)))));
            this.label3.Location = new System.Drawing.Point(300, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 65);
            this.label3.TabIndex = 26;
            this.label3.Text = "ELECTION SYSTEM";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(295, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 45);
            this.label2.TabIndex = 27;
            this.label2.Text = "SUPREME STUDENT COUNCIL";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(207, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 86);
            this.label1.TabIndex = 28;
            this.label1.Text = "OSMEÑA COLLEGES";
            // 
            // startBtn
            // 
            this.startBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.BorderRadius = 8;
            this.startBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.startBtn.CheckedState.Parent = this.startBtn;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.CustomImages.Parent = this.startBtn;
            this.startBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startBtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.startBtn.HoverState.Parent = this.startBtn;
            this.startBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.startBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.startBtn.Location = new System.Drawing.Point(378, 564);
            this.startBtn.Name = "startBtn";
            this.startBtn.ShadowDecoration.Parent = this.startBtn;
            this.startBtn.Size = new System.Drawing.Size(292, 45);
            this.startBtn.TabIndex = 29;
            this.startBtn.Text = "Start Voting";
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2PictureBox1.Image = global::OCSSCESu.Properties.Resources.logo_v3;
            this.guna2PictureBox1.Location = new System.Drawing.Point(384, 43);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(280, 280);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FrmMockup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1048, 621);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.closeBtn);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMockup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMockup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMockup_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button startBtn;
    }
}

