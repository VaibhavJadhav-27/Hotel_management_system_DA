namespace Hotel_Management_Software
{
    partial class rp_laundry
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
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmdsuittype = new MetroFramework.Controls.MetroComboBox();
            this.nudquantity = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnAddtolist = new XanderUI.XUIButton();
            this.btnSave = new XanderUI.XUIButton();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtGuestname = new MetroFramework.Controls.MetroTextBox();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblPrice = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblTotalPrice = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblGrandTotal = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblguestid = new MetroSet_UI.Controls.MetroSetLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudquantity)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(107, 234);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(186, 31);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "Suit / Dress Type :";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(121, 338);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(95, 31);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 1;
            this.metroSetLabel2.Text = "Price :";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(107, 433);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(186, 31);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 2;
            this.metroSetLabel3.Text = "Quantity :";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(107, 529);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(186, 31);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 3;
            this.metroSetLabel4.Text = "Total :";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // cmdsuittype
            // 
            this.cmdsuittype.DisplayFocus = true;
            this.cmdsuittype.FormattingEnabled = true;
            this.cmdsuittype.ItemHeight = 24;
            this.cmdsuittype.Items.AddRange(new object[] {
            "Suit",
            "Saree",
            "Dress",
            "Shirt",
            "Pant"});
            this.cmdsuittype.Location = new System.Drawing.Point(329, 234);
            this.cmdsuittype.Name = "cmdsuittype";
            this.cmdsuittype.Size = new System.Drawing.Size(284, 30);
            this.cmdsuittype.TabIndex = 4;
            this.cmdsuittype.UseSelectable = true;
            this.cmdsuittype.SelectedIndexChanged += new System.EventHandler(this.cmdsuittype_SelectedIndexChanged);
            // 
            // nudquantity
            // 
            this.nudquantity.Location = new System.Drawing.Point(329, 433);
            this.nudquantity.Name = "nudquantity";
            this.nudquantity.Size = new System.Drawing.Size(120, 22);
            this.nudquantity.TabIndex = 6;
            this.nudquantity.ValueChanged += new System.EventHandler(this.nudquantity_ValueChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(770, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(716, 580);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddtolist
            // 
            this.btnAddtolist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddtolist.ButtonImage = null;
            this.btnAddtolist.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnAddtolist.ButtonText = "Add to List";
            this.btnAddtolist.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddtolist.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddtolist.CornerRadius = 5;
            this.btnAddtolist.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtolist.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddtolist.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddtolist.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddtolist.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddtolist.Location = new System.Drawing.Point(220, 635);
            this.btnAddtolist.Name = "btnAddtolist";
            this.btnAddtolist.Size = new System.Drawing.Size(200, 50);
            this.btnAddtolist.TabIndex = 9;
            this.btnAddtolist.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddtolist.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddtolist.Click += new System.EventHandler(this.btnAddtolist_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.ButtonImage = null;
            this.btnSave.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnSave.ButtonText = "Save";
            this.btnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.CornerRadius = 5;
            this.btnSave.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSave.Location = new System.Drawing.Point(220, 749);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 50);
            this.btnSave.TabIndex = 10;
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(805, 691);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(159, 31);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 11;
            this.metroSetLabel5.Text = "Grand Total :";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
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
            this.txtGuestname.Location = new System.Drawing.Point(329, 82);
            this.txtGuestname.MaxLength = 32767;
            this.txtGuestname.Name = "txtGuestname";
            this.txtGuestname.PasswordChar = '\0';
            this.txtGuestname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGuestname.SelectedText = "";
            this.txtGuestname.SelectionLength = 0;
            this.txtGuestname.SelectionStart = 0;
            this.txtGuestname.ShortcutsEnabled = true;
            this.txtGuestname.Size = new System.Drawing.Size(284, 33);
            this.txtGuestname.TabIndex = 14;
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
            this.metroSetLabel6.Location = new System.Drawing.Point(121, 81);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(150, 31);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 13;
            this.metroSetLabel6.Text = "Guest Name :";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Font = new System.Drawing.Font("Lucida Bright", 10.8F);
            this.lblPrice.IsDerivedStyle = true;
            this.lblPrice.Location = new System.Drawing.Point(330, 328);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(283, 33);
            this.lblPrice.Style = MetroSet_UI.Enums.Style.Light;
            this.lblPrice.StyleManager = null;
            this.lblPrice.TabIndex = 15;
            this.lblPrice.ThemeAuthor = "Narwin";
            this.lblPrice.ThemeName = "MetroLite";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPrice.Font = new System.Drawing.Font("Lucida Bright", 10.8F);
            this.lblTotalPrice.IsDerivedStyle = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(329, 529);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(284, 33);
            this.lblTotalPrice.Style = MetroSet_UI.Enums.Style.Light;
            this.lblTotalPrice.StyleManager = null;
            this.lblTotalPrice.TabIndex = 16;
            this.lblTotalPrice.ThemeAuthor = "Narwin";
            this.lblTotalPrice.ThemeName = "MetroLite";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrandTotal.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.IsDerivedStyle = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(954, 689);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(402, 33);
            this.lblGrandTotal.Style = MetroSet_UI.Enums.Style.Light;
            this.lblGrandTotal.StyleManager = null;
            this.lblGrandTotal.TabIndex = 17;
            this.lblGrandTotal.ThemeAuthor = "Narwin";
            this.lblGrandTotal.ThemeName = "MetroLite";
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Lucida Bright", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(121, 154);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(150, 31);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 34;
            this.metroSetLabel7.Text = "Guest Name :";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLite";
            // 
            // lblguestid
            // 
            this.lblguestid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblguestid.Font = new System.Drawing.Font("Lucida Bright", 10.8F);
            this.lblguestid.IsDerivedStyle = true;
            this.lblguestid.Location = new System.Drawing.Point(329, 154);
            this.lblguestid.Name = "lblguestid";
            this.lblguestid.Size = new System.Drawing.Size(283, 33);
            this.lblguestid.Style = MetroSet_UI.Enums.Style.Light;
            this.lblguestid.StyleManager = null;
            this.lblguestid.TabIndex = 35;
            this.lblguestid.ThemeAuthor = "Narwin";
            this.lblguestid.ThemeName = "MetroLite";
            // 
            // rp_laundry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.lblguestid);
            this.Controls.Add(this.metroSetLabel7);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtGuestname);
            this.Controls.Add(this.metroSetLabel6);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddtolist);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.nudquantity);
            this.Controls.Add(this.cmdsuittype);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Name = "rp_laundry";
            this.Size = new System.Drawing.Size(1685, 855);
            this.Load += new System.EventHandler(this.rp_laundry_Load);
            this.Leave += new System.EventHandler(this.rp_laundry_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.nudquantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroFramework.Controls.MetroComboBox cmdsuittype;
        private System.Windows.Forms.NumericUpDown nudquantity;
        private System.Windows.Forms.ListView listView1;
        private XanderUI.XUIButton btnAddtolist;
        private XanderUI.XUIButton btnSave;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroFramework.Controls.MetroTextBox txtGuestname;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetLabel lblPrice;
        private MetroSet_UI.Controls.MetroSetLabel lblTotalPrice;
        private MetroSet_UI.Controls.MetroSetLabel lblGrandTotal;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetLabel lblguestid;
    }
}
