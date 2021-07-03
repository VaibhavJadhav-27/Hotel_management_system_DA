namespace Hotel_Management_Software
{
    partial class RecoveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoveryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtusername = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new XanderUI.XUIButton();
            this.txtconfirmpass = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtnewpass = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerify = new XanderUI.XUIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtempname = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtempid = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnback = new XanderUI.XUIButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnVerify);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtempname);
            this.panel1.Controls.Add(this.txtempid);
            this.panel1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(238, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1596, 775);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtusername);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtconfirmpass);
            this.panel2.Controls.Add(this.txtnewpass);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(18, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1554, 485);
            this.panel2.TabIndex = 8;
            // 
            // txtusername
            // 
            this.txtusername.AutoCompleteCustomSource = null;
            this.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtusername.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtusername.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtusername.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtusername.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtusername.Image = null;
            this.txtusername.IsDerivedStyle = true;
            this.txtusername.Lines = null;
            this.txtusername.Location = new System.Drawing.Point(382, 28);
            this.txtusername.MaxLength = 32767;
            this.txtusername.Multiline = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = false;
            this.txtusername.Size = new System.Drawing.Size(428, 36);
            this.txtusername.Style = MetroSet_UI.Enums.Style.Light;
            this.txtusername.StyleManager = null;
            this.txtusername.TabIndex = 10;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtusername.ThemeAuthor = "Narwin";
            this.txtusername.ThemeName = "MetroLite";
            this.txtusername.UseSystemPasswordChar = false;
            this.txtusername.WatermarkText = "username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(148, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enter username :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUpdate.ButtonImage = null;
            this.btnUpdate.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnUpdate.ButtonText = "Update Password";
            this.btnUpdate.ClickBackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.ClickTextColor = System.Drawing.Color.Yellow;
            this.btnUpdate.CornerRadius = 10;
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.HoverBackgroundColor = System.Drawing.Color.Navy;
            this.btnUpdate.HoverTextColor = System.Drawing.Color.Yellow;
            this.btnUpdate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnUpdate.Location = new System.Drawing.Point(382, 314);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(304, 50);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.TextColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtconfirmpass
            // 
            this.txtconfirmpass.AutoCompleteCustomSource = null;
            this.txtconfirmpass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtconfirmpass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtconfirmpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtconfirmpass.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtconfirmpass.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtconfirmpass.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtconfirmpass.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmpass.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtconfirmpass.Image = null;
            this.txtconfirmpass.IsDerivedStyle = true;
            this.txtconfirmpass.Lines = null;
            this.txtconfirmpass.Location = new System.Drawing.Point(382, 196);
            this.txtconfirmpass.MaxLength = 32767;
            this.txtconfirmpass.Multiline = false;
            this.txtconfirmpass.Name = "txtconfirmpass";
            this.txtconfirmpass.ReadOnly = false;
            this.txtconfirmpass.Size = new System.Drawing.Size(428, 36);
            this.txtconfirmpass.Style = MetroSet_UI.Enums.Style.Light;
            this.txtconfirmpass.StyleManager = null;
            this.txtconfirmpass.TabIndex = 3;
            this.txtconfirmpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtconfirmpass.ThemeAuthor = "Narwin";
            this.txtconfirmpass.ThemeName = "MetroLite";
            this.txtconfirmpass.UseSystemPasswordChar = false;
            this.txtconfirmpass.WatermarkText = "confirm password";
            // 
            // txtnewpass
            // 
            this.txtnewpass.AutoCompleteCustomSource = null;
            this.txtnewpass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtnewpass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtnewpass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtnewpass.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtnewpass.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtnewpass.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtnewpass.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtnewpass.Image = null;
            this.txtnewpass.IsDerivedStyle = true;
            this.txtnewpass.Lines = null;
            this.txtnewpass.Location = new System.Drawing.Point(382, 110);
            this.txtnewpass.MaxLength = 32767;
            this.txtnewpass.Multiline = false;
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.ReadOnly = false;
            this.txtnewpass.Size = new System.Drawing.Size(428, 36);
            this.txtnewpass.Style = MetroSet_UI.Enums.Style.Light;
            this.txtnewpass.StyleManager = null;
            this.txtnewpass.TabIndex = 2;
            this.txtnewpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnewpass.ThemeAuthor = "Narwin";
            this.txtnewpass.ThemeName = "MetroLite";
            this.txtnewpass.UseSystemPasswordChar = false;
            this.txtnewpass.WatermarkText = "new password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(148, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Confirm Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(148, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter password :";
            // 
            // btnVerify
            // 
            this.btnVerify.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnVerify.ButtonImage = null;
            this.btnVerify.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnVerify.ButtonText = "Verify";
            this.btnVerify.ClickBackColor = System.Drawing.Color.Yellow;
            this.btnVerify.ClickTextColor = System.Drawing.Color.Yellow;
            this.btnVerify.CornerRadius = 5;
            this.btnVerify.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnVerify.HoverBackgroundColor = System.Drawing.Color.Yellow;
            this.btnVerify.HoverTextColor = System.Drawing.Color.Transparent;
            this.btnVerify.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnVerify.Location = new System.Drawing.Point(919, 84);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(200, 50);
            this.btnVerify.TabIndex = 7;
            this.btnVerify.TextColor = System.Drawing.Color.Yellow;
            this.btnVerify.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(214, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee ID :";
            // 
            // txtempname
            // 
            this.txtempname.AutoCompleteCustomSource = null;
            this.txtempname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtempname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtempname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtempname.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtempname.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtempname.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtempname.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempname.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtempname.Image = null;
            this.txtempname.IsDerivedStyle = true;
            this.txtempname.Lines = null;
            this.txtempname.Location = new System.Drawing.Point(334, 141);
            this.txtempname.MaxLength = 32767;
            this.txtempname.Multiline = false;
            this.txtempname.Name = "txtempname";
            this.txtempname.ReadOnly = false;
            this.txtempname.Size = new System.Drawing.Size(437, 35);
            this.txtempname.Style = MetroSet_UI.Enums.Style.Light;
            this.txtempname.StyleManager = null;
            this.txtempname.TabIndex = 4;
            this.txtempname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtempname.ThemeAuthor = "Narwin";
            this.txtempname.ThemeName = "MetroLite";
            this.txtempname.UseSystemPasswordChar = false;
            this.txtempname.WatermarkText = "Employee name";
            // 
            // txtempid
            // 
            this.txtempid.AutoCompleteCustomSource = null;
            this.txtempid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtempid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtempid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtempid.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtempid.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtempid.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtempid.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempid.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtempid.Image = null;
            this.txtempid.IsDerivedStyle = true;
            this.txtempid.Lines = null;
            this.txtempid.Location = new System.Drawing.Point(334, 63);
            this.txtempid.MaxLength = 32767;
            this.txtempid.Multiline = false;
            this.txtempid.Name = "txtempid";
            this.txtempid.ReadOnly = false;
            this.txtempid.Size = new System.Drawing.Size(437, 35);
            this.txtempid.Style = MetroSet_UI.Enums.Style.Light;
            this.txtempid.StyleManager = null;
            this.txtempid.TabIndex = 3;
            this.txtempid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtempid.ThemeAuthor = "Narwin";
            this.txtempid.ThemeName = "MetroLite";
            this.txtempid.UseSystemPasswordChar = false;
            this.txtempid.WatermarkText = "Employee id";
            // 
            // btnback
            // 
            this.btnback.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnback.ButtonImage = null;
            this.btnback.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnback.ButtonText = "Back";
            this.btnback.ClickBackColor = System.Drawing.Color.Transparent;
            this.btnback.ClickTextColor = System.Drawing.Color.Red;
            this.btnback.CornerRadius = 10;
            this.btnback.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.btnback.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnback.HoverBackgroundColor = System.Drawing.Color.Transparent;
            this.btnback.HoverTextColor = System.Drawing.Color.Red;
            this.btnback.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnback.Location = new System.Drawing.Point(1633, 929);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(200, 50);
            this.btnback.TabIndex = 1;
            this.btnback.TextColor = System.Drawing.Color.Red;
            this.btnback.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // RecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1942, 977);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecoveryForm";
            this.Text = "RecoveryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RecoveryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroSet_UI.Controls.MetroSetTextBox txtempname;
        private MetroSet_UI.Controls.MetroSetTextBox txtempid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnVerify;
        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUIButton btnUpdate;
        private MetroSet_UI.Controls.MetroSetTextBox txtconfirmpass;
        private MetroSet_UI.Controls.MetroSetTextBox txtnewpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private XanderUI.XUIButton btnback;
        private MetroSet_UI.Controls.MetroSetTextBox txtusername;
        private System.Windows.Forms.Label label5;
    }
}