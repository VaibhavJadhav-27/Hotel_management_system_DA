namespace Hotel_Management_Software
{
    partial class ad_room
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbtype = new MetroSet_UI.Controls.MetroSetComboBox();
            this.cmbbed = new MetroSet_UI.Controls.MetroSetComboBox();
            this.btnAddRoom = new XanderUI.XUIButton();
            this.btnremoveroom = new XanderUI.XUIButton();
            this.btnUpdateroom = new XanderUI.XUIButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.txtroomid = new MetroFramework.Controls.MetroTextBox();
            this.txtroonno = new MetroFramework.Controls.MetroTextBox();
            this.txtprice = new MetroFramework.Controls.MetroTextBox();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.rdbYES = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.rdbNO = new MetroSet_UI.Controls.MetroSetRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(69, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1185, 445);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(104, 576);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(163, 33);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 3;
            this.metroSetLabel1.Text = "Room ID :";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(104, 673);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(186, 33);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 5;
            this.metroSetLabel2.Text = "Room Number :";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(104, 774);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(186, 33);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 7;
            this.metroSetLabel3.Text = "Type :";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(784, 576);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(95, 33);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 9;
            this.metroSetLabel4.Text = "Bed :";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(784, 673);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(105, 33);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 11;
            this.metroSetLabel5.Text = "Price :";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // cmbtype
            // 
            this.cmbtype.AllowDrop = true;
            this.cmbtype.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbtype.BackColor = System.Drawing.Color.Transparent;
            this.cmbtype.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbtype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbtype.CausesValidation = false;
            this.cmbtype.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbtype.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbtype.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.IsDerivedStyle = true;
            this.cmbtype.ItemHeight = 20;
            this.cmbtype.Items.AddRange(new object[] {
            "Deluxe",
            "Twin",
            "Regular Suite"});
            this.cmbtype.Location = new System.Drawing.Point(306, 774);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbtype.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbtype.Size = new System.Drawing.Size(234, 26);
            this.cmbtype.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbtype.StyleManager = null;
            this.cmbtype.TabIndex = 13;
            this.cmbtype.ThemeAuthor = "Narwin";
            this.cmbtype.ThemeName = "MetroLite";
            // 
            // cmbbed
            // 
            this.cmbbed.AllowDrop = true;
            this.cmbbed.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbbed.BackColor = System.Drawing.Color.Transparent;
            this.cmbbed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbbed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbbed.CausesValidation = false;
            this.cmbbed.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbbed.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbbed.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbbed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbbed.FormattingEnabled = true;
            this.cmbbed.IsDerivedStyle = true;
            this.cmbbed.ItemHeight = 20;
            this.cmbbed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.cmbbed.Location = new System.Drawing.Point(903, 576);
            this.cmbbed.Name = "cmbbed";
            this.cmbbed.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbbed.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbbed.Size = new System.Drawing.Size(234, 26);
            this.cmbbed.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbbed.StyleManager = null;
            this.cmbbed.TabIndex = 14;
            this.cmbbed.ThemeAuthor = "Narwin";
            this.cmbbed.ThemeName = "MetroLite";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddRoom.ButtonImage = null;
            this.btnAddRoom.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnAddRoom.ButtonText = "Add Room";
            this.btnAddRoom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddRoom.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddRoom.CornerRadius = 5;
            this.btnAddRoom.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddRoom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddRoom.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddRoom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddRoom.Location = new System.Drawing.Point(1390, 221);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(200, 50);
            this.btnAddRoom.TabIndex = 15;
            this.btnAddRoom.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddRoom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnremoveroom
            // 
            this.btnremoveroom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnremoveroom.ButtonImage = null;
            this.btnremoveroom.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnremoveroom.ButtonText = "Remove Room";
            this.btnremoveroom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnremoveroom.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnremoveroom.CornerRadius = 5;
            this.btnremoveroom.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoveroom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnremoveroom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnremoveroom.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnremoveroom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnremoveroom.Location = new System.Drawing.Point(1390, 487);
            this.btnremoveroom.Name = "btnremoveroom";
            this.btnremoveroom.Size = new System.Drawing.Size(200, 50);
            this.btnremoveroom.TabIndex = 16;
            this.btnremoveroom.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnremoveroom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnremoveroom.Click += new System.EventHandler(this.btnremoveroom_Click);
            // 
            // btnUpdateroom
            // 
            this.btnUpdateroom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateroom.ButtonImage = null;
            this.btnUpdateroom.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnUpdateroom.ButtonText = "Update Room";
            this.btnUpdateroom.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdateroom.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdateroom.CornerRadius = 5;
            this.btnUpdateroom.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateroom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdateroom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdateroom.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateroom.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnUpdateroom.Location = new System.Drawing.Point(1390, 353);
            this.btnUpdateroom.Name = "btnUpdateroom";
            this.btnUpdateroom.Size = new System.Drawing.Size(200, 50);
            this.btnUpdateroom.TabIndex = 17;
            this.btnUpdateroom.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdateroom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdateroom.Click += new System.EventHandler(this.btnUpdateroom_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(374, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(539, 34);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Room Number";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(408, 35);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Room Number";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // txtroomid
            // 
            // 
            // 
            // 
            this.txtroomid.CustomButton.Image = null;
            this.txtroomid.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtroomid.CustomButton.Name = "";
            this.txtroomid.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtroomid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtroomid.CustomButton.TabIndex = 1;
            this.txtroomid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtroomid.CustomButton.UseSelectable = true;
            this.txtroomid.CustomButton.Visible = false;
            this.txtroomid.Lines = new string[0];
            this.txtroomid.Location = new System.Drawing.Point(306, 576);
            this.txtroomid.MaxLength = 32767;
            this.txtroomid.Name = "txtroomid";
            this.txtroomid.PasswordChar = '\0';
            this.txtroomid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtroomid.SelectedText = "";
            this.txtroomid.SelectionLength = 0;
            this.txtroomid.SelectionStart = 0;
            this.txtroomid.ShortcutsEnabled = true;
            this.txtroomid.Size = new System.Drawing.Size(234, 33);
            this.txtroomid.TabIndex = 19;
            this.txtroomid.UseSelectable = true;
            this.txtroomid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtroomid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtroonno
            // 
            // 
            // 
            // 
            this.txtroonno.CustomButton.Image = null;
            this.txtroonno.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtroonno.CustomButton.Name = "";
            this.txtroonno.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtroonno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtroonno.CustomButton.TabIndex = 1;
            this.txtroonno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtroonno.CustomButton.UseSelectable = true;
            this.txtroonno.CustomButton.Visible = false;
            this.txtroonno.Lines = new string[0];
            this.txtroonno.Location = new System.Drawing.Point(306, 673);
            this.txtroonno.MaxLength = 32767;
            this.txtroonno.Name = "txtroonno";
            this.txtroonno.PasswordChar = '\0';
            this.txtroonno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtroonno.SelectedText = "";
            this.txtroonno.SelectionLength = 0;
            this.txtroonno.SelectionStart = 0;
            this.txtroonno.ShortcutsEnabled = true;
            this.txtroonno.Size = new System.Drawing.Size(234, 33);
            this.txtroonno.TabIndex = 20;
            this.txtroonno.UseSelectable = true;
            this.txtroonno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtroonno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtroonno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtroonno_KeyPress);
            // 
            // txtprice
            // 
            // 
            // 
            // 
            this.txtprice.CustomButton.Image = null;
            this.txtprice.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.txtprice.CustomButton.Name = "";
            this.txtprice.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtprice.CustomButton.TabIndex = 1;
            this.txtprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtprice.CustomButton.UseSelectable = true;
            this.txtprice.CustomButton.Visible = false;
            this.txtprice.Lines = new string[0];
            this.txtprice.Location = new System.Drawing.Point(903, 673);
            this.txtprice.MaxLength = 32767;
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtprice.SelectedText = "";
            this.txtprice.SelectionLength = 0;
            this.txtprice.SelectionStart = 0;
            this.txtprice.ShortcutsEnabled = true;
            this.txtprice.Size = new System.Drawing.Size(234, 33);
            this.txtprice.TabIndex = 21;
            this.txtprice.UseSelectable = true;
            this.txtprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(784, 767);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(105, 33);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 22;
            this.metroSetLabel6.Text = "Booked :";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // rdbYES
            // 
            this.rdbYES.BackgroundColor = System.Drawing.Color.White;
            this.rdbYES.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rdbYES.Checked = false;
            this.rdbYES.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.rdbYES.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.rdbYES.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.rdbYES.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbYES.Group = 0;
            this.rdbYES.IsDerivedStyle = true;
            this.rdbYES.Location = new System.Drawing.Point(914, 774);
            this.rdbYES.Name = "rdbYES";
            this.rdbYES.Size = new System.Drawing.Size(77, 17);
            this.rdbYES.Style = MetroSet_UI.Enums.Style.Light;
            this.rdbYES.StyleManager = null;
            this.rdbYES.TabIndex = 23;
            this.rdbYES.Text = "YES";
            this.rdbYES.ThemeAuthor = "Narwin";
            this.rdbYES.ThemeName = "MetroLite";
            // 
            // rdbNO
            // 
            this.rdbNO.BackgroundColor = System.Drawing.Color.White;
            this.rdbNO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rdbNO.Checked = true;
            this.rdbNO.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.rdbNO.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            this.rdbNO.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.rdbNO.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNO.Group = 0;
            this.rdbNO.IsDerivedStyle = true;
            this.rdbNO.Location = new System.Drawing.Point(1040, 774);
            this.rdbNO.Name = "rdbNO";
            this.rdbNO.Size = new System.Drawing.Size(75, 17);
            this.rdbNO.Style = MetroSet_UI.Enums.Style.Light;
            this.rdbNO.StyleManager = null;
            this.rdbNO.TabIndex = 24;
            this.rdbNO.Text = "NO";
            this.rdbNO.ThemeAuthor = "Narwin";
            this.rdbNO.ThemeName = "MetroLite";
            // 
            // ad_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdbYES);
            this.Controls.Add(this.rdbNO);
            this.Controls.Add(this.metroSetLabel6);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtroonno);
            this.Controls.Add(this.txtroomid);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnUpdateroom);
            this.Controls.Add(this.btnremoveroom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.cmbbed);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ad_room";
            this.Size = new System.Drawing.Size(1685, 855);
            this.Load += new System.EventHandler(this.ad_room_Load);
            this.Leave += new System.EventHandler(this.ad_room_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetComboBox cmbtype;
        private MetroSet_UI.Controls.MetroSetComboBox cmbbed;
        private XanderUI.XUIButton btnAddRoom;
        private XanderUI.XUIButton btnremoveroom;
        private XanderUI.XUIButton btnUpdateroom;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroTextBox txtroomid;
        private MetroFramework.Controls.MetroTextBox txtroonno;
        private MetroFramework.Controls.MetroTextBox txtprice;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetRadioButton rdbYES;
        private MetroSet_UI.Controls.MetroSetRadioButton rdbNO;
    }
}
