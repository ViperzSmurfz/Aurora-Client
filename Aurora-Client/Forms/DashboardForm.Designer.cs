namespace Aurora_Client
{
    partial class DashboardForm
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
            this.SigninBtn = new MaterialSkin.Controls.MaterialButton();
            this.UsernameTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // SigninBtn
            // 
            this.SigninBtn.AutoSize = false;
            this.SigninBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SigninBtn.Depth = 0;
            this.SigninBtn.DrawShadows = true;
            this.SigninBtn.HighEmphasis = true;
            this.SigninBtn.Icon = null;
            this.SigninBtn.Location = new System.Drawing.Point(677, 283);
            this.SigninBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SigninBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SigninBtn.Name = "SigninBtn";
            this.SigninBtn.Size = new System.Drawing.Size(158, 52);
            this.SigninBtn.TabIndex = 0;
            this.SigninBtn.Text = "Sign In";
            this.SigninBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SigninBtn.UseAccentColor = false;
            this.SigninBtn.UseVisualStyleBackColor = true;
            this.SigninBtn.Click += new System.EventHandler(this.SigninBtn_Click);
            // 
            // UsernameTxtBox
            // 
            // 
            // 
            // 
            this.UsernameTxtBox.CustomButton.Image = null;
            this.UsernameTxtBox.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.UsernameTxtBox.CustomButton.Name = "";
            this.UsernameTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UsernameTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernameTxtBox.CustomButton.TabIndex = 1;
            this.UsernameTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernameTxtBox.CustomButton.UseSelectable = true;
            this.UsernameTxtBox.CustomButton.Visible = false;
            this.UsernameTxtBox.DisplayIcon = true;
            this.UsernameTxtBox.Icon = global::Aurora_Client.Properties.Resources.username;
            this.UsernameTxtBox.Lines = new string[0];
            this.UsernameTxtBox.Location = new System.Drawing.Point(449, 283);
            this.UsernameTxtBox.MaxLength = 32767;
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.PasswordChar = '\0';
            this.UsernameTxtBox.PromptText = "Enter your Minecraft Username";
            this.UsernameTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTxtBox.SelectedText = "";
            this.UsernameTxtBox.SelectionLength = 0;
            this.UsernameTxtBox.SelectionStart = 0;
            this.UsernameTxtBox.ShortcutsEnabled = true;
            this.UsernameTxtBox.Size = new System.Drawing.Size(221, 23);
            this.UsernameTxtBox.TabIndex = 2;
            this.UsernameTxtBox.UseSelectable = true;
            this.UsernameTxtBox.WaterMark = "Enter your Minecraft Username";
            this.UsernameTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PasswordTxtBox
            // 
            // 
            // 
            // 
            this.PasswordTxtBox.CustomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordTxtBox.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordTxtBox.CustomButton.Image = global::Aurora_Client.Properties.Resources.showpass;
            this.PasswordTxtBox.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.PasswordTxtBox.CustomButton.Name = "";
            this.PasswordTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.PasswordTxtBox.CustomButton.TabIndex = 1;
            this.PasswordTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTxtBox.CustomButton.UseSelectable = true;
            this.PasswordTxtBox.DisplayIcon = true;
            this.PasswordTxtBox.Icon = global::Aurora_Client.Properties.Resources.password;
            this.PasswordTxtBox.Lines = new string[0];
            this.PasswordTxtBox.Location = new System.Drawing.Point(449, 312);
            this.PasswordTxtBox.MaxLength = 32767;
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '•';
            this.PasswordTxtBox.PromptText = "Enter your Minecraft Password";
            this.PasswordTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTxtBox.SelectedText = "";
            this.PasswordTxtBox.SelectionLength = 0;
            this.PasswordTxtBox.SelectionStart = 0;
            this.PasswordTxtBox.ShortcutsEnabled = true;
            this.PasswordTxtBox.ShowButton = true;
            this.PasswordTxtBox.Size = new System.Drawing.Size(221, 23);
            this.PasswordTxtBox.TabIndex = 1;
            this.PasswordTxtBox.UseSelectable = true;
            this.PasswordTxtBox.WaterMark = "Enter your Minecraft Password";
            this.PasswordTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordTxtBox.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.Eye_ButtonClick);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(848, 350);
            this.Controls.Add(this.UsernameTxtBox);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.SigninBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton SigninBtn;
        private MetroFramework.Controls.MetroTextBox PasswordTxtBox;
        private MetroFramework.Controls.MetroTextBox UsernameTxtBox;
    }
}