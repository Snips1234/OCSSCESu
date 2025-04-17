namespace OCSSCESu
{
    partial class FrmConfig
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
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.formShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.portText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serverText = new Guna.UI2.WinForms.Guna2TextBox();
            this.databaseText = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordText = new Guna.UI2.WinForms.Guna2TextBox();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formElipse
            // 
            this.formElipse.BorderRadius = 30;
            this.formElipse.TargetControl = this;
            // 
            // portText
            // 
            this.portText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.portText.BorderRadius = 9;
            this.portText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.portText.DefaultText = "";
            this.portText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.portText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.portText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.portText.DisabledState.Parent = this.portText;
            this.portText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.portText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.portText.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.portText.FocusedState.Parent = this.portText;
            this.portText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.portText.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.portText.HoverState.Parent = this.portText;
            this.portText.Location = new System.Drawing.Point(25, 86);
            this.portText.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.portText.Name = "portText";
            this.portText.PasswordChar = '\0';
            this.portText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.portText.PlaceholderText = "Port";
            this.portText.SelectedText = "";
            this.portText.ShadowDecoration.Parent = this.portText;
            this.portText.Size = new System.Drawing.Size(295, 35);
            this.portText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(68, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Database configuration";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OCSSCESu.Properties.Resources.gearIcon;
            this.pictureBox1.Location = new System.Drawing.Point(25, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // serverText
            // 
            this.serverText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.serverText.BorderRadius = 9;
            this.serverText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serverText.DefaultText = "";
            this.serverText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.serverText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.serverText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.serverText.DisabledState.Parent = this.serverText;
            this.serverText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.serverText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.serverText.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.serverText.FocusedState.Parent = this.serverText;
            this.serverText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.serverText.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.serverText.HoverState.Parent = this.serverText;
            this.serverText.Location = new System.Drawing.Point(25, 131);
            this.serverText.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.serverText.Name = "serverText";
            this.serverText.PasswordChar = '\0';
            this.serverText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.serverText.PlaceholderText = "Server";
            this.serverText.SelectedText = "";
            this.serverText.ShadowDecoration.Parent = this.serverText;
            this.serverText.Size = new System.Drawing.Size(295, 35);
            this.serverText.TabIndex = 2;
            // 
            // databaseText
            // 
            this.databaseText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.databaseText.BorderRadius = 9;
            this.databaseText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.databaseText.DefaultText = "";
            this.databaseText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.databaseText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.databaseText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.databaseText.DisabledState.Parent = this.databaseText;
            this.databaseText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.databaseText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.databaseText.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.databaseText.FocusedState.Parent = this.databaseText;
            this.databaseText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.databaseText.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.databaseText.HoverState.Parent = this.databaseText;
            this.databaseText.Location = new System.Drawing.Point(25, 176);
            this.databaseText.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.databaseText.Name = "databaseText";
            this.databaseText.PasswordChar = '\0';
            this.databaseText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.databaseText.PlaceholderText = "Database name";
            this.databaseText.SelectedText = "";
            this.databaseText.ShadowDecoration.Parent = this.databaseText;
            this.databaseText.Size = new System.Drawing.Size(295, 35);
            this.databaseText.TabIndex = 3;
            // 
            // usernameText
            // 
            this.usernameText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.usernameText.BorderRadius = 9;
            this.usernameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameText.DefaultText = "";
            this.usernameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameText.DisabledState.Parent = this.usernameText;
            this.usernameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.usernameText.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.usernameText.FocusedState.Parent = this.usernameText;
            this.usernameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.usernameText.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.usernameText.HoverState.Parent = this.usernameText;
            this.usernameText.Location = new System.Drawing.Point(25, 221);
            this.usernameText.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.usernameText.Name = "usernameText";
            this.usernameText.PasswordChar = '\0';
            this.usernameText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.usernameText.PlaceholderText = "Username";
            this.usernameText.SelectedText = "";
            this.usernameText.ShadowDecoration.Parent = this.usernameText;
            this.usernameText.Size = new System.Drawing.Size(295, 35);
            this.usernameText.TabIndex = 4;
            // 
            // passwordText
            // 
            this.passwordText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.passwordText.BorderRadius = 9;
            this.passwordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordText.DefaultText = "";
            this.passwordText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordText.DisabledState.Parent = this.passwordText;
            this.passwordText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.passwordText.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.passwordText.FocusedState.Parent = this.passwordText;
            this.passwordText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.passwordText.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.passwordText.HoverState.Parent = this.passwordText;
            this.passwordText.Location = new System.Drawing.Point(25, 266);
            this.passwordText.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '\0';
            this.passwordText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.passwordText.PlaceholderText = "Password";
            this.passwordText.SelectedText = "";
            this.passwordText.ShadowDecoration.Parent = this.passwordText;
            this.passwordText.Size = new System.Drawing.Size(295, 35);
            this.passwordText.TabIndex = 5;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // saveButton
            // 
            this.saveButton.BorderRadius = 10;
            this.saveButton.CheckedState.Parent = this.saveButton;
            this.saveButton.CustomImages.Parent = this.saveButton;
            this.saveButton.FillColor = System.Drawing.Color.Maroon;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.HoverState.Parent = this.saveButton;
            this.saveButton.Location = new System.Drawing.Point(25, 316);
            this.saveButton.Name = "saveButton";
            this.saveButton.ShadowDecoration.Parent = this.saveButton;
            this.saveButton.Size = new System.Drawing.Size(295, 51);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // formDragControl
            // 
            this.formDragControl.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 16;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Maroon;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Maroon;
            this.guna2ControlBox1.Location = new System.Drawing.Point(300, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 32);
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // FrmDatabaseConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(344, 405);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.databaseText);
            this.Controls.Add(this.serverText);
            this.Controls.Add(this.portText);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmDatabaseConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Configuration";
            this.Load += new System.EventHandler(this.DatabaseConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private Guna.UI2.WinForms.Guna2ShadowForm formShadow;
        private Guna.UI2.WinForms.Guna2TextBox portText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox passwordText;
        private Guna.UI2.WinForms.Guna2TextBox usernameText;
        private Guna.UI2.WinForms.Guna2TextBox databaseText;
        private Guna.UI2.WinForms.Guna2TextBox serverText;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}