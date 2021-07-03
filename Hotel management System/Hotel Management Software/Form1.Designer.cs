namespace Hotel_Management_Software
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroSetLink1 = new MetroSet_UI.Controls.MetroSetLink();
            this.metroSetEllipse1 = new MetroSet_UI.Controls.MetroSetEllipse();
            this.btnlogin = new XanderUI.XUIButton();
            this.txtpassword = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtusername = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1942, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Location = new System.Drawing.Point(13, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(53, 40);
            this.btnexit.TabIndex = 0;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.metroSetLink1);
            this.panel2.Controls.Add(this.metroSetEllipse1);
            this.panel2.Controls.Add(this.btnlogin);
            this.panel2.Controls.Add(this.txtpassword);
            this.panel2.Controls.Add(this.txtusername);
            this.panel2.Controls.Add(this.metroSetLabel1);
            this.panel2.Location = new System.Drawing.Point(593, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 578);
            this.panel2.TabIndex = 1;
            // 
            // metroSetLink1
            // 
            this.metroSetLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetLink1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLink1.IsDerivedStyle = true;
            this.metroSetLink1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.metroSetLink1.Location = new System.Drawing.Point(512, 540);
            this.metroSetLink1.Name = "metroSetLink1";
            this.metroSetLink1.Size = new System.Drawing.Size(224, 27);
            this.metroSetLink1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLink1.StyleManager = null;
            this.metroSetLink1.TabIndex = 7;
            this.metroSetLink1.TabStop = true;
            this.metroSetLink1.Text = "Forgot  password";
            this.metroSetLink1.ThemeAuthor = "Narwin";
            this.metroSetLink1.ThemeName = "MetroLite";
            this.metroSetLink1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            this.metroSetLink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.metroSetLink1_LinkClicked);
            // 
            // metroSetEllipse1
            // 
            this.metroSetEllipse1.BorderThickness = 3;
            this.metroSetEllipse1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetEllipse1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetEllipse1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetEllipse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetEllipse1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetEllipse1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetEllipse1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetEllipse1.Image = ((System.Drawing.Image)(resources.GetObject("metroSetEllipse1.Image")));
            this.metroSetEllipse1.ImageSize = new System.Drawing.Size(64, 64);
            this.metroSetEllipse1.IsDerivedStyle = true;
            this.metroSetEllipse1.Location = new System.Drawing.Point(213, 3);
            this.metroSetEllipse1.Name = "metroSetEllipse1";
            this.metroSetEllipse1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetEllipse1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetEllipse1.NormalTextColor = System.Drawing.Color.Black;
            this.metroSetEllipse1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetEllipse1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetEllipse1.PressTextColor = System.Drawing.Color.White;
            this.metroSetEllipse1.Size = new System.Drawing.Size(98, 97);
            this.metroSetEllipse1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetEllipse1.StyleManager = null;
            this.metroSetEllipse1.TabIndex = 6;
            this.metroSetEllipse1.ThemeAuthor = "Narwin";
            this.metroSetEllipse1.ThemeName = "MetroLite";
            // 
            // btnlogin
            // 
            this.btnlogin.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlogin.ButtonImage = null;
            this.btnlogin.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnlogin.ButtonText = "Login";
            this.btnlogin.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnlogin.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnlogin.CornerRadius = 10;
            this.btnlogin.Font = new System.Drawing.Font("Lucida Bright", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnlogin.HoverBackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.btnlogin.HoverTextColor = System.Drawing.Color.Yellow;
            this.btnlogin.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnlogin.Location = new System.Drawing.Point(207, 365);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(351, 50);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.TextColor = System.Drawing.Color.Yellow;
            this.btnlogin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.AutoCompleteCustomSource = null;
            this.txtpassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtpassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtpassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtpassword.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtpassword.Image = ((System.Drawing.Image)(resources.GetObject("txtpassword.Image")));
            this.txtpassword.IsDerivedStyle = true;
            this.txtpassword.Lines = null;
            this.txtpassword.Location = new System.Drawing.Point(207, 256);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Multiline = false;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.ReadOnly = false;
            this.txtpassword.Size = new System.Drawing.Size(357, 40);
            this.txtpassword.Style = MetroSet_UI.Enums.Style.Light;
            this.txtpassword.StyleManager = null;
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpassword.ThemeAuthor = "Narwin";
            this.txtpassword.ThemeName = "MetroLite";
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.WatermarkText = "Password";
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // txtusername
            // 
            this.txtusername.AutoCompleteCustomSource = null;
            this.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtusername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtusername.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtusername.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtusername.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtusername.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtusername.Image = ((System.Drawing.Image)(resources.GetObject("txtusername.Image")));
            this.txtusername.IsDerivedStyle = true;
            this.txtusername.Lines = null;
            this.txtusername.Location = new System.Drawing.Point(207, 164);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Multiline = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = false;
            this.txtusername.Size = new System.Drawing.Size(357, 40);
            this.txtusername.Style = MetroSet_UI.Enums.Style.Light;
            this.txtusername.StyleManager = null;
            this.txtusername.TabIndex = 1;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtusername.ThemeAuthor = "Narwin";
            this.txtusername.ThemeName = "MetroLite";
            this.txtusername.UseSystemPasswordChar = false;
            this.txtusername.WatermarkText = "Username";
            this.txtusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusername_KeyPress);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.metroSetLabel1.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(330, 30);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(148, 46);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "Login";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1366, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "......... See what a difference a stay makes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1942, 977);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private XanderUI.XUIButton btnlogin;
        private MetroSet_UI.Controls.MetroSetTextBox txtpassword;
        private MetroSet_UI.Controls.MetroSetTextBox txtusername;
        private MetroSet_UI.Controls.MetroSetEllipse metroSetEllipse1;
        private MetroSet_UI.Controls.MetroSetLink metroSetLink1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
    }
}

