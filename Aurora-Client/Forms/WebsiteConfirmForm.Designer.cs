namespace Aurora_Client.Forms
{
    partial class WebsiteConfirmForm
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
            this.DragBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new MaterialSkin.Controls.MaterialButton();
            this.CancelBtn = new MaterialSkin.Controls.MaterialButton();
            this.DescLbl = new System.Windows.Forms.Label();
            this.DragBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DragBar
            // 
            this.DragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(162)))));
            this.DragBar.Controls.Add(this.pictureBox1);
            this.DragBar.Controls.Add(this.TitleLbl);
            this.DragBar.Controls.Add(this.CloseBtn);
            this.DragBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragBar.Location = new System.Drawing.Point(0, 0);
            this.DragBar.Name = "DragBar";
            this.DragBar.Size = new System.Drawing.Size(426, 30);
            this.DragBar.TabIndex = 1;
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
            this.TitleLbl.Size = new System.Drawing.Size(128, 24);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Are you sure?";
            this.TitleLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleLbl_MouseMove);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseBtn.Location = new System.Drawing.Point(396, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(30, 30);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.AutoSize = false;
            this.OpenBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenBtn.Depth = 0;
            this.OpenBtn.DrawShadows = true;
            this.OpenBtn.HighEmphasis = true;
            this.OpenBtn.Icon = null;
            this.OpenBtn.Location = new System.Drawing.Point(16, 132);
            this.OpenBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 2;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OpenBtn.UseAccentColor = false;
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.AutoSize = false;
            this.CancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Depth = 0;
            this.CancelBtn.DrawShadows = true;
            this.CancelBtn.HighEmphasis = true;
            this.CancelBtn.Icon = null;
            this.CancelBtn.Location = new System.Drawing.Point(339, 132);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CancelBtn.UseAccentColor = false;
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // DescLbl
            // 
            this.DescLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DescLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.DescLbl.Location = new System.Drawing.Point(12, 33);
            this.DescLbl.Name = "DescLbl";
            this.DescLbl.Size = new System.Drawing.Size(402, 93);
            this.DescLbl.TabIndex = 4;
            this.DescLbl.Text = "Are you sure you would like to open our Official Website?";
            // 
            // WebsiteConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(426, 169);
            this.Controls.Add(this.DescLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.DragBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WebsiteConfirmForm";
            this.Text = "WebsiteConfirmForm";
            this.DragBar.ResumeLayout(false);
            this.DragBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DragBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button CloseBtn;
        private MaterialSkin.Controls.MaterialButton OpenBtn;
        private MaterialSkin.Controls.MaterialButton CancelBtn;
        private System.Windows.Forms.Label DescLbl;
    }
}