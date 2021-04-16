namespace Aurora_Client
{
    partial class AuroraForm
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
            this.WorkingArea = new System.Windows.Forms.Panel();
            this.DragBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.HeaderPnl = new System.Windows.Forms.Panel();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.SettingsBtn = new MaterialSkin.Controls.MaterialButton();
            this.WebsiteBtn = new MaterialSkin.Controls.MaterialButton();
            this.ModsBtn = new MaterialSkin.Controls.MaterialButton();
            this.PlayBtn = new MaterialSkin.Controls.MaterialButton();
            this.DashboardBtn = new MaterialSkin.Controls.MaterialButton();
            this.DesktopPnl = new System.Windows.Forms.Panel();
            this.ProgressBar = new XanderUI.XUIFlatProgressBar();
            this.DragBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HeaderPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkingArea
            // 
            this.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkingArea.Location = new System.Drawing.Point(0, 30);
            this.WorkingArea.Name = "WorkingArea";
            this.WorkingArea.Size = new System.Drawing.Size(800, 420);
            this.WorkingArea.TabIndex = 0;
            // 
            // DragBar
            // 
            this.DragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(162)))));
            this.DragBar.Controls.Add(this.pictureBox1);
            this.DragBar.Controls.Add(this.TitleLbl);
            this.DragBar.Controls.Add(this.MinimizeBtn);
            this.DragBar.Controls.Add(this.CloseBtn);
            this.DragBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragBar.Location = new System.Drawing.Point(0, 0);
            this.DragBar.Name = "DragBar";
            this.DragBar.Size = new System.Drawing.Size(848, 30);
            this.DragBar.TabIndex = 0;
            this.DragBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragBar_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aurora_Client.Properties.Resources.AuroraLogo30;
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TitleLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleLbl.Location = new System.Drawing.Point(42, 3);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(119, 24);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Aurora Client";
            this.TitleLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleLbl_MouseMove);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimizeBtn.Location = new System.Drawing.Point(788, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(30, 30);
            this.MinimizeBtn.TabIndex = 1;
            this.MinimizeBtn.Text = "_";
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseBtn.Location = new System.Drawing.Point(818, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(30, 30);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // HeaderPnl
            // 
            this.HeaderPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(186)))));
            this.HeaderPnl.Controls.Add(this.HeaderLbl);
            this.HeaderPnl.Controls.Add(this.SettingsBtn);
            this.HeaderPnl.Controls.Add(this.WebsiteBtn);
            this.HeaderPnl.Controls.Add(this.ModsBtn);
            this.HeaderPnl.Controls.Add(this.PlayBtn);
            this.HeaderPnl.Controls.Add(this.DashboardBtn);
            this.HeaderPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPnl.Location = new System.Drawing.Point(0, 30);
            this.HeaderPnl.Name = "HeaderPnl";
            this.HeaderPnl.Size = new System.Drawing.Size(848, 70);
            this.HeaderPnl.TabIndex = 1;
            this.HeaderPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderPnl_Paint);
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.HeaderLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.HeaderLbl.Location = new System.Drawing.Point(12, 3);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(102, 24);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Dashboard";
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.AutoSize = false;
            this.SettingsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsBtn.Depth = 0;
            this.SettingsBtn.DrawShadows = true;
            this.SettingsBtn.HighEmphasis = true;
            this.SettingsBtn.Icon = null;
            this.SettingsBtn.Location = new System.Drawing.Point(677, 28);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SettingsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(158, 36);
            this.SettingsBtn.TabIndex = 4;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SettingsBtn.UseAccentColor = false;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // WebsiteBtn
            // 
            this.WebsiteBtn.AutoSize = false;
            this.WebsiteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WebsiteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WebsiteBtn.Depth = 0;
            this.WebsiteBtn.DrawShadows = true;
            this.WebsiteBtn.HighEmphasis = true;
            this.WebsiteBtn.Icon = null;
            this.WebsiteBtn.Location = new System.Drawing.Point(511, 28);
            this.WebsiteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.WebsiteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.WebsiteBtn.Name = "WebsiteBtn";
            this.WebsiteBtn.Size = new System.Drawing.Size(158, 36);
            this.WebsiteBtn.TabIndex = 3;
            this.WebsiteBtn.Text = "Website";
            this.WebsiteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.WebsiteBtn.UseAccentColor = false;
            this.WebsiteBtn.UseVisualStyleBackColor = true;
            this.WebsiteBtn.Click += new System.EventHandler(this.WebsiteBtn_Click);
            // 
            // ModsBtn
            // 
            this.ModsBtn.AutoSize = false;
            this.ModsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModsBtn.Depth = 0;
            this.ModsBtn.DrawShadows = true;
            this.ModsBtn.HighEmphasis = true;
            this.ModsBtn.Icon = null;
            this.ModsBtn.Location = new System.Drawing.Point(345, 28);
            this.ModsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ModsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModsBtn.Name = "ModsBtn";
            this.ModsBtn.Size = new System.Drawing.Size(158, 36);
            this.ModsBtn.TabIndex = 2;
            this.ModsBtn.Text = "Mods";
            this.ModsBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ModsBtn.UseAccentColor = false;
            this.ModsBtn.UseVisualStyleBackColor = true;
            this.ModsBtn.Click += new System.EventHandler(this.ModsBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.AutoSize = false;
            this.PlayBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayBtn.Depth = 0;
            this.PlayBtn.DrawShadows = true;
            this.PlayBtn.Enabled = false;
            this.PlayBtn.HighEmphasis = true;
            this.PlayBtn.Icon = null;
            this.PlayBtn.Location = new System.Drawing.Point(179, 28);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PlayBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(158, 36);
            this.PlayBtn.TabIndex = 1;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PlayBtn.UseAccentColor = false;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.AutoSize = false;
            this.DashboardBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.Depth = 0;
            this.DashboardBtn.DrawShadows = true;
            this.DashboardBtn.HighEmphasis = true;
            this.DashboardBtn.Icon = null;
            this.DashboardBtn.Location = new System.Drawing.Point(13, 28);
            this.DashboardBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DashboardBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(158, 36);
            this.DashboardBtn.TabIndex = 0;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DashboardBtn.UseAccentColor = false;
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // DesktopPnl
            // 
            this.DesktopPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DesktopPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPnl.Location = new System.Drawing.Point(0, 100);
            this.DesktopPnl.Name = "DesktopPnl";
            this.DesktopPnl.Size = new System.Drawing.Size(848, 350);
            this.DesktopPnl.TabIndex = 3;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BarStyle = XanderUI.XUIFlatProgressBar.Style.Material;
            this.ProgressBar.BorderColor = System.Drawing.Color.Black;
            this.ProgressBar.CompleteColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgressBar.InocmpletedColor = System.Drawing.Color.White;
            this.ProgressBar.Location = new System.Drawing.Point(0, 100);
            this.ProgressBar.MaxValue = 100;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ShowBorder = true;
            this.ProgressBar.Size = new System.Drawing.Size(848, 6);
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.Value = 50;
            this.ProgressBar.Visible = false;
            // 
            // AuroraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.DesktopPnl);
            this.Controls.Add(this.HeaderPnl);
            this.Controls.Add(this.DragBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuroraForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AuroraForm_Load);
            this.DragBar.ResumeLayout(false);
            this.DragBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HeaderPnl.ResumeLayout(false);
            this.HeaderPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WorkingArea;
        private System.Windows.Forms.Panel DragBar;
        private System.Windows.Forms.Panel HeaderPnl;
        private MaterialSkin.Controls.MaterialButton SettingsBtn;
        private MaterialSkin.Controls.MaterialButton WebsiteBtn;
        private MaterialSkin.Controls.MaterialButton ModsBtn;
        private MaterialSkin.Controls.MaterialButton PlayBtn;
        private MaterialSkin.Controls.MaterialButton DashboardBtn;
        private System.Windows.Forms.Panel DesktopPnl;
        private XanderUI.XUIFlatProgressBar ProgressBar;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

