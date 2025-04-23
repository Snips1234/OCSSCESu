namespace OCSSCESu
{
    partial class FrmUserAuthentication
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
            this.components = new System.ComponentModel.Container();
            this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.formShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.windowLabel = new System.Windows.Forms.Label();
            this.studentIdText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.uniqueCodeText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.yearLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.course = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formDragControl
            // 
            this.formDragControl.TargetControl = this;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 16;
            this.closeBtn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.closeBtn.HoverState.Parent = this.closeBtn;
            this.closeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.Location = new System.Drawing.Point(351, 13);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShadowDecoration.Parent = this.closeBtn;
            this.closeBtn.Size = new System.Drawing.Size(32, 32);
            this.closeBtn.TabIndex = 1;
            // 
            // windowLabel
            // 
            this.windowLabel.AutoSize = true;
            this.windowLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.windowLabel.Location = new System.Drawing.Point(12, 14);
            this.windowLabel.Name = "windowLabel";
            this.windowLabel.Size = new System.Drawing.Size(156, 30);
            this.windowLabel.TabIndex = 5;
            this.windowLabel.Text = "User validation";
            // 
            // studentIdText
            // 
            this.studentIdText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.studentIdText.BorderRadius = 8;
            this.studentIdText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentIdText.DefaultText = "";
            this.studentIdText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.studentIdText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.studentIdText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentIdText.DisabledState.Parent = this.studentIdText;
            this.studentIdText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.studentIdText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.studentIdText.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.studentIdText.FocusedState.Parent = this.studentIdText;
            this.studentIdText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.studentIdText.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.studentIdText.HoverState.Parent = this.studentIdText;
            this.studentIdText.Location = new System.Drawing.Point(18, 78);
            this.studentIdText.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.studentIdText.Name = "studentIdText";
            this.studentIdText.PasswordChar = '\0';
            this.studentIdText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.studentIdText.PlaceholderText = "Student ID";
            this.studentIdText.SelectedText = "";
            this.studentIdText.ShadowDecoration.Parent = this.studentIdText;
            this.studentIdText.Size = new System.Drawing.Size(365, 42);
            this.studentIdText.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Student ID";
            // 
            // uniqueCodeText
            // 
            this.uniqueCodeText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uniqueCodeText.BorderRadius = 8;
            this.uniqueCodeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uniqueCodeText.DefaultText = "";
            this.uniqueCodeText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.uniqueCodeText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.uniqueCodeText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.uniqueCodeText.DisabledState.Parent = this.uniqueCodeText;
            this.uniqueCodeText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.uniqueCodeText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.uniqueCodeText.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.uniqueCodeText.FocusedState.Parent = this.uniqueCodeText;
            this.uniqueCodeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniqueCodeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.uniqueCodeText.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.uniqueCodeText.HoverState.Parent = this.uniqueCodeText;
            this.uniqueCodeText.Location = new System.Drawing.Point(17, 154);
            this.uniqueCodeText.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.uniqueCodeText.Name = "uniqueCodeText";
            this.uniqueCodeText.PasswordChar = '\0';
            this.uniqueCodeText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.uniqueCodeText.PlaceholderText = "Unique code";
            this.uniqueCodeText.SelectedText = "";
            this.uniqueCodeText.ShadowDecoration.Parent = this.uniqueCodeText;
            this.uniqueCodeText.Size = new System.Drawing.Size(366, 42);
            this.uniqueCodeText.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Unique Code";
            // 
            // saveButton
            // 
            this.saveButton.BorderRadius = 8;
            this.saveButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.saveButton.CheckedState.Parent = this.saveButton;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.CustomImages.Parent = this.saveButton;
            this.saveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.saveButton.HoverState.Parent = this.saveButton;
            this.saveButton.Image = global::OCSSCESu.Properties.Resources.icons8_verified_account_96px;
            this.saveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.saveButton.ImageSize = new System.Drawing.Size(30, 30);
            this.saveButton.Location = new System.Drawing.Point(17, 356);
            this.saveButton.Name = "saveButton";
            this.saveButton.ShadowDecoration.Parent = this.saveButton;
            this.saveButton.Size = new System.Drawing.Size(366, 66);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Verify";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // yearLevel
            // 
            this.yearLevel.BackColor = System.Drawing.Color.Transparent;
            this.yearLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yearLevel.BorderRadius = 8;
            this.yearLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.yearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearLevel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.yearLevel.FocusedColor = System.Drawing.Color.Empty;
            this.yearLevel.FocusedState.Parent = this.yearLevel;
            this.yearLevel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.yearLevel.FormattingEnabled = true;
            this.yearLevel.HoverState.Parent = this.yearLevel;
            this.yearLevel.ItemHeight = 30;
            this.yearLevel.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th"});
            this.yearLevel.ItemsAppearance.Parent = this.yearLevel;
            this.yearLevel.Location = new System.Drawing.Point(17, 230);
            this.yearLevel.Name = "yearLevel";
            this.yearLevel.ShadowDecoration.Parent = this.yearLevel;
            this.yearLevel.Size = new System.Drawing.Size(366, 36);
            this.yearLevel.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Year Level";
            // 
            // course
            // 
            this.course.BackColor = System.Drawing.Color.Transparent;
            this.course.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.course.BorderRadius = 8;
            this.course.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course.FillColor = System.Drawing.Color.WhiteSmoke;
            this.course.FocusedColor = System.Drawing.Color.Empty;
            this.course.FocusedState.Parent = this.course;
            this.course.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.course.FormattingEnabled = true;
            this.course.HoverState.Parent = this.course;
            this.course.ItemHeight = 30;
            this.course.Items.AddRange(new object[] {
            "BSCS",
            "CABA",
            "HRM",
            "CRIM",
            "EDUC"});
            this.course.ItemsAppearance.Parent = this.course;
            this.course.Location = new System.Drawing.Point(17, 298);
            this.course.Name = "course";
            this.course.ShadowDecoration.Parent = this.course;
            this.course.Size = new System.Drawing.Size(366, 36);
            this.course.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Course";
            // 
            // FrmUserAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(395, 449);
            this.Controls.Add(this.course);
            this.Controls.Add(this.yearLevel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.uniqueCodeText);
            this.Controls.Add(this.studentIdText);
            this.Controls.Add(this.windowLabel);
            this.Controls.Add(this.closeBtn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUserAuthentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmUserAuthentication";
            this.Load += new System.EventHandler(this.FrmUserAuthentication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
        private Guna.UI2.WinForms.Guna2ShadowForm formShadow;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private System.Windows.Forms.Label windowLabel;
        private Guna.UI2.WinForms.Guna2TextBox studentIdText;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox uniqueCodeText;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private Guna.UI2.WinForms.Guna2ComboBox yearLevel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox course;
        private System.Windows.Forms.Label label3;
    }
}