namespace OCSSCESu
{
    partial class UCCandidate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCandidate));
            this.checkBox = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.candidateName = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.candidateYearLevel = new System.Windows.Forms.Label();
            this.candidateId = new System.Windows.Forms.Label();
            this.candidateImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.courseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.candidateImage)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox.CheckedState.BorderRadius = 2;
            this.checkBox.CheckedState.BorderThickness = 0;
            this.checkBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox.CheckedState.Parent = this.checkBox;
            this.checkBox.Location = new System.Drawing.Point(21, 42);
            this.checkBox.Name = "checkBox";
            this.checkBox.ShadowDecoration.Parent = this.checkBox;
            this.checkBox.Size = new System.Drawing.Size(42, 42);
            this.checkBox.TabIndex = 1;
            this.checkBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox.UncheckedState.BorderRadius = 2;
            this.checkBox.UncheckedState.BorderThickness = 0;
            this.checkBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox.UncheckedState.Parent = this.checkBox;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // candidateName
            // 
            this.candidateName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.candidateName.AutoEllipsis = true;
            this.candidateName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.candidateName.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidateName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.candidateName.Location = new System.Drawing.Point(184, 24);
            this.candidateName.Name = "candidateName";
            this.candidateName.Size = new System.Drawing.Size(352, 34);
            this.candidateName.TabIndex = 3;
            this.candidateName.Text = "EDGARDO C BALAN JR";
            this.candidateName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.candidateName.Click += new System.EventHandler(this.on_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.Location = new System.Drawing.Point(189, 61);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(347, 8);
            this.guna2Separator1.TabIndex = 4;
            this.guna2Separator1.Click += new System.EventHandler(this.on_Click);
            // 
            // candidateYearLevel
            // 
            this.candidateYearLevel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.candidateYearLevel.AutoEllipsis = true;
            this.candidateYearLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.candidateYearLevel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidateYearLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.candidateYearLevel.Location = new System.Drawing.Point(435, 66);
            this.candidateYearLevel.Name = "candidateYearLevel";
            this.candidateYearLevel.Size = new System.Drawing.Size(101, 21);
            this.candidateYearLevel.TabIndex = 3;
            this.candidateYearLevel.Text = "4th  Year";
            this.candidateYearLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.candidateYearLevel.Click += new System.EventHandler(this.on_Click);
            // 
            // candidateId
            // 
            this.candidateId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.candidateId.AutoEllipsis = true;
            this.candidateId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.candidateId.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidateId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.candidateId.Location = new System.Drawing.Point(184, 67);
            this.candidateId.Name = "candidateId";
            this.candidateId.Size = new System.Drawing.Size(245, 21);
            this.candidateId.TabIndex = 3;
            this.candidateId.Text = "ID: 12312312";
            this.candidateId.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.candidateId.Click += new System.EventHandler(this.on_Click);
            // 
            // candidateImage
            // 
            this.candidateImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.candidateImage.ErrorImage = global::OCSSCESu.Properties.Resources.icons8_no_image_120px;
            this.candidateImage.Image = ((System.Drawing.Image)(resources.GetObject("candidateImage.Image")));
            this.candidateImage.InitialImage = global::OCSSCESu.Properties.Resources.icons8_no_image_120px;
            this.candidateImage.Location = new System.Drawing.Point(69, 9);
            this.candidateImage.Name = "candidateImage";
            this.candidateImage.ShadowDecoration.Parent = this.candidateImage;
            this.candidateImage.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.candidateImage.Size = new System.Drawing.Size(109, 109);
            this.candidateImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.candidateImage.TabIndex = 2;
            this.candidateImage.TabStop = false;
            this.candidateImage.Click += new System.EventHandler(this.on_Click);
            // 
            // courseLabel
            // 
            this.courseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.courseLabel.AutoEllipsis = true;
            this.courseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courseLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.courseLabel.Location = new System.Drawing.Point(185, 97);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(351, 21);
            this.courseLabel.TabIndex = 3;
            this.courseLabel.Text = "ID: 12312312";
            this.courseLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.courseLabel.Click += new System.EventHandler(this.on_Click);
            // 
            // UCCandidate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.candidateId);
            this.Controls.Add(this.candidateYearLevel);
            this.Controls.Add(this.candidateName);
            this.Controls.Add(this.candidateImage);
            this.Controls.Add(this.checkBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(0, 126);
            this.MinimumSize = new System.Drawing.Size(0, 126);
            this.Name = "UCCandidate"; 
            this.Size = new System.Drawing.Size(556, 126);
            this.Load += new System.EventHandler(this.on_Click);
            ((System.ComponentModel.ISupportInitialize)(this.candidateImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomCheckBox checkBox;
        private Guna.UI2.WinForms.Guna2PictureBox candidateImage;
        private System.Windows.Forms.Label candidateName;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label candidateYearLevel;
        private System.Windows.Forms.Label candidateId;
        private System.Windows.Forms.Label courseLabel;
    }
}
