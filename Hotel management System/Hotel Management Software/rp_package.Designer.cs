namespace Hotel_Management_Software
{
    partial class rp_package
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
            this.lblTotalPrice = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblPrice = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtGuestname = new MetroFramework.Controls.MetroTextBox();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.nudquantity = new System.Windows.Forms.NumericUpDown();
            this.cmdpackagetype = new MetroFramework.Controls.MetroComboBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnSave = new XanderUI.XUIButton();
            this.lblpackageinfo = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblguestid = new MetroSet_UI.Controls.MetroSetLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPrice.Font = new System.Drawing.Font("Lucida Bright", 10.8F);
            this.lblTotalPrice.IsDerivedStyle = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(336, 534);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(284, 33);
            this.lblTotalPrice.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTotalPrice.StyleManager = null;
            this.lblTotalPrice.TabIndex = 26;
            this.lblTotalPrice.ThemeAuthor = "Narwin";
            this.lblTotalPrice.ThemeName = "MetroLite";
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Font = new System.Drawing.Font("Lucida Bright", 10.8F);
            this.lblPrice.IsDerivedStyle = true;
            this.lblPrice.Location = new System.Drawing.Point(336, 344);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(283, 33);
            this.lblPrice.Style = MetroSet_UI.Enums.Style.Light;
            this.lblPrice.StyleManager = null;
            this.lblPrice.TabIndex = 25;
            this.lblPrice.ThemeAuthor = "Narwin";
            this.lblPrice.ThemeName = "MetroLite";
            // 
            // txtGuestname
            // 
            // 
            // 
            // 
            this.txtGuestname.CustomButton.Image = null;
            this.txtGuestname.CustomButton.Location = new System.Drawing.Point(252, 1);
            this.txtGuestname.CustomButton.Name = "";
            this.txtGuestname.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtGuestname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGuestname.CustomButton.TabIndex = 1;
            this.txtGuestname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGuestname.CustomButton.UseSelectable = true;
            this.txtGuestname.CustomButton.Visible = false;
            this.txtGuestname.Lines = new string[0];
            this.txtGuestname.Location = new System.Drawing.Point(335, 100);
            this.txtGuestname.MaxLength = 32767;
            this.txtGuestname.Name = "txtGuestname";
            this.txtGuestname.PasswordChar = '\0';
            this.txtGuestname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuestname.SelectedText = "";
            this.txtGuestname.SelectionLength = 0;
            this.txtGuestname.SelectionStart = 0;
            this.txtGuestname.ShortcutsEnabled = true;
            this.txtGuestname.Size = new System.Drawing.Size(284, 33);
            this.txtGuestname.TabIndex = 24;
            this.txtGuestname.UseSelectable = true;
            this.txtGuestname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGuestname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGuestname.TextChanged += new System.EventHandler(this.txtGuestname_TextChanged);
            this.txtGuestname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuestname_KeyPress);
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(115, 102);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(150, 31);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 23;
            this.metroSetLabel6.Text = "Guest Name :";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // nudquantity
            // 
            this.nudquantity.Location = new System.Drawing.Point(335, 440);
            this.nudquantity.Name = "nudquantity";
            this.nudquantity.Size = new System.Drawing.Size(120, 22);
            this.nudquantity.TabIndex = 22;
            this.nudquantity.ValueChanged += new System.EventHandler(this.nudquantity_ValueChanged);
            this.nudquantity.Click += new System.EventHandler(this.nudquantity_Click);
            // 
            // cmdpackagetype
            // 
            this.cmdpackagetype.FormattingEnabled = true;
            this.cmdpackagetype.ItemHeight = 24;
            this.cmdpackagetype.Items.AddRange(new object[] {
            "American Package",
            "Monodraft American Package",
            "Day Package",
            "Evening Package",
            "Seasonal Package"});
            this.cmdpackagetype.Location = new System.Drawing.Point(335, 250);
            this.cmdpackagetype.Name = "cmdpackagetype";
            this.cmdpackagetype.Size = new System.Drawing.Size(284, 30);
            this.cmdpackagetype.TabIndex = 21;
            this.cmdpackagetype.UseSelectable = true;
            this.cmdpackagetype.SelectedIndexChanged += new System.EventHandler(this.cmdpackagetype_SelectedIndexChanged);
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(115, 534);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(186, 31);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 20;
            this.metroSetLabel4.Text = "Total :";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(115, 440);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(186, 31);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 19;
            this.metroSetLabel3.Text = "Quantity :";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(115, 346);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(193, 31);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 18;
            this.metroSetLabel2.Text = "Price per package :";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(115, 250);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(186, 31);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 17;
            this.metroSetLabel1.Text = "Package Type :";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.ButtonImage = null;
            this.btnSave.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnSave.ButtonText = "Save";
            this.btnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.CornerRadius = 5;
            this.btnSave.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSave.Location = new System.Drawing.Point(295, 689);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 50);
            this.btnSave.TabIndex = 28;
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblpackageinfo
            // 
            this.lblpackageinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblpackageinfo.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpackageinfo.IsDerivedStyle = true;
            this.lblpackageinfo.Location = new System.Drawing.Point(813, 109);
            this.lblpackageinfo.Name = "lblpackageinfo";
            this.lblpackageinfo.Size = new System.Drawing.Size(643, 630);
            this.lblpackageinfo.Style = MetroSet_UI.Enums.Style.Light;
            this.lblpackageinfo.StyleManager = null;
            this.lblpackageinfo.TabIndex = 33;
            this.lblpackageinfo.ThemeAuthor = "Narwin";
            this.lblpackageinfo.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(115, 172);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(150, 31);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 34;
            this.metroSetLabel5.Text = "Guest ID :";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // lblguestid
            // 
            this.lblguestid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblguestid.Font = new System.Drawing.Font("Lucida Bright", 10.8F);
            this.lblguestid.IsDerivedStyle = true;
            this.lblguestid.Location = new System.Drawing.Point(335, 172);
            this.lblguestid.Name = "lblguestid";
            this.lblguestid.Size = new System.Drawing.Size(283, 33);
            this.lblguestid.Style = MetroSet_UI.Enums.Style.Light;
            this.lblguestid.StyleManager = null;
            this.lblguestid.TabIndex = 35;
            this.lblguestid.ThemeAuthor = "Narwin";
            this.lblguestid.ThemeName = "MetroLite";
            // 
            // rp_package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lblguestid);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.lblpackageinfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtGuestname);
            this.Controls.Add(this.metroSetLabel6);
            this.Controls.Add(this.nudquantity);
            this.Controls.Add(this.cmdpackagetype);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Name = "rp_package";
            this.Size = new System.Drawing.Size(1685, 855);
            this.Leave += new System.EventHandler(this.rp_package_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.nudquantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel lblTotalPrice;
        private MetroSet_UI.Controls.MetroSetLabel lblPrice;
        private MetroFramework.Controls.MetroTextBox txtGuestname;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private System.Windows.Forms.NumericUpDown nudquantity;
        private MetroFramework.Controls.MetroComboBox cmdpackagetype;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private XanderUI.XUIButton btnSave;
        private MetroSet_UI.Controls.MetroSetLabel lblpackageinfo;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel lblguestid;
    }
}
