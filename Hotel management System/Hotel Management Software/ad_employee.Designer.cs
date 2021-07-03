namespace Hotel_Management_Software
{
    partial class ad_employee
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
            this.cmbgender = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.btnRemove = new XanderUI.XUIButton();
            this.btnUpdate = new XanderUI.XUIButton();
            this.cmbdepartment = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtempname = new MetroFramework.Controls.MetroTextBox();
            this.txtempid = new MetroFramework.Controls.MetroTextBox();
            this.txtcontactno = new MetroFramework.Controls.MetroTextBox();
            this.txtdesignation = new MetroFramework.Controls.MetroTextBox();
            this.txtsalary = new MetroFramework.Controls.MetroTextBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(95, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            this.dataGridView1.Size = new System.Drawing.Size(1196, 430);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(59, 560);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(186, 33);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 1;
            this.metroSetLabel1.Text = "Employee ID :";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(48, 643);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(207, 33);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 3;
            this.metroSetLabel2.Text = " Employee Name :";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(95, 718);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(110, 33);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 5;
            this.metroSetLabel3.Text = "Gender :";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(675, 643);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(157, 33);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 9;
            this.metroSetLabel4.Text = "Department :";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(675, 560);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(157, 33);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 7;
            this.metroSetLabel5.Text = "Contact No. :";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // cmbgender
            // 
            this.cmbgender.AllowDrop = true;
            this.cmbgender.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbgender.BackColor = System.Drawing.Color.Transparent;
            this.cmbgender.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbgender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbgender.CausesValidation = false;
            this.cmbgender.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbgender.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbgender.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.IsDerivedStyle = true;
            this.cmbgender.ItemHeight = 20;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbgender.Location = new System.Drawing.Point(240, 718);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbgender.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbgender.Size = new System.Drawing.Size(234, 26);
            this.cmbgender.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbgender.StyleManager = null;
            this.cmbgender.TabIndex = 11;
            this.cmbgender.ThemeAuthor = "Narwin";
            this.cmbgender.ThemeName = "MetroLite";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(1236, 560);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(184, 33);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 12;
            this.metroSetLabel6.Text = "Designation :";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // xuiButton1
            // 
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton1.ButtonImage = null;
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton1.ButtonText = "Add";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.Red;
            this.xuiButton1.ClickTextColor = System.Drawing.Color.Red;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.Red;
            this.xuiButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(1414, 131);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(200, 50);
            this.xuiButton1.TabIndex = 14;
            this.xuiButton1.TextColor = System.Drawing.Color.Red;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemove.ButtonImage = null;
            this.btnRemove.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnRemove.ButtonText = "Remove";
            this.btnRemove.ClickBackColor = System.Drawing.Color.Red;
            this.btnRemove.ClickTextColor = System.Drawing.Color.Red;
            this.btnRemove.CornerRadius = 5;
            this.btnRemove.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRemove.HoverBackgroundColor = System.Drawing.Color.Red;
            this.btnRemove.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemove.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnRemove.Location = new System.Drawing.Point(1414, 380);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(200, 50);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.TextColor = System.Drawing.Color.Red;
            this.btnRemove.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.ButtonImage = null;
            this.btnUpdate.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.ClickBackColor = System.Drawing.Color.Red;
            this.btnUpdate.ClickTextColor = System.Drawing.Color.Red;
            this.btnUpdate.CornerRadius = 5;
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.HoverBackgroundColor = System.Drawing.Color.Red;
            this.btnUpdate.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnUpdate.Location = new System.Drawing.Point(1414, 258);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 50);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.TextColor = System.Drawing.Color.Red;
            this.btnUpdate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbdepartment
            // 
            this.cmbdepartment.AllowDrop = true;
            this.cmbdepartment.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbdepartment.BackColor = System.Drawing.Color.Transparent;
            this.cmbdepartment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbdepartment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbdepartment.CausesValidation = false;
            this.cmbdepartment.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbdepartment.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbdepartment.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbdepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbdepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbdepartment.FormattingEnabled = true;
            this.cmbdepartment.IsDerivedStyle = true;
            this.cmbdepartment.ItemHeight = 20;
            this.cmbdepartment.Items.AddRange(new object[] {
            "Front office",
            "Administrative",
            "Housekeeping",
            "Food and Beverages",
            "Kitchen",
            "Security",
            "Humar Resources",
            "Attendance"});
            this.cmbdepartment.Location = new System.Drawing.Point(838, 643);
            this.cmbdepartment.Name = "cmbdepartment";
            this.cmbdepartment.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbdepartment.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbdepartment.Size = new System.Drawing.Size(289, 26);
            this.cmbdepartment.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbdepartment.StyleManager = null;
            this.cmbdepartment.TabIndex = 17;
            this.cmbdepartment.ThemeAuthor = "Narwin";
            this.cmbdepartment.ThemeName = "MetroLite";
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(1236, 643);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(184, 33);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 18;
            this.metroSetLabel7.Text = "Salary :";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLite";
            // 
            // txtempname
            // 
            // 
            // 
            // 
            this.txtempname.CustomButton.Image = null;
            this.txtempname.CustomButton.Location = new System.Drawing.Point(291, 1);
            this.txtempname.CustomButton.Name = "";
            this.txtempname.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtempname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtempname.CustomButton.TabIndex = 1;
            this.txtempname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtempname.CustomButton.UseSelectable = true;
            this.txtempname.CustomButton.Visible = false;
            this.txtempname.Lines = new string[0];
            this.txtempname.Location = new System.Drawing.Point(240, 643);
            this.txtempname.MaxLength = 32767;
            this.txtempname.Name = "txtempname";
            this.txtempname.PasswordChar = '\0';
            this.txtempname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtempname.SelectedText = "";
            this.txtempname.SelectionLength = 0;
            this.txtempname.SelectionStart = 0;
            this.txtempname.ShortcutsEnabled = true;
            this.txtempname.Size = new System.Drawing.Size(323, 33);
            this.txtempname.TabIndex = 20;
            this.txtempname.UseSelectable = true;
            this.txtempname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtempname.WaterMarkFont = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress_1);
            // 
            // txtempid
            // 
            // 
            // 
            // 
            this.txtempid.CustomButton.Image = null;
            this.txtempid.CustomButton.Location = new System.Drawing.Point(291, 1);
            this.txtempid.CustomButton.Name = "";
            this.txtempid.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtempid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtempid.CustomButton.TabIndex = 1;
            this.txtempid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtempid.CustomButton.UseSelectable = true;
            this.txtempid.CustomButton.Visible = false;
            this.txtempid.Lines = new string[0];
            this.txtempid.Location = new System.Drawing.Point(240, 560);
            this.txtempid.MaxLength = 32767;
            this.txtempid.Name = "txtempid";
            this.txtempid.PasswordChar = '\0';
            this.txtempid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtempid.SelectedText = "";
            this.txtempid.SelectionLength = 0;
            this.txtempid.SelectionStart = 0;
            this.txtempid.ShortcutsEnabled = true;
            this.txtempid.Size = new System.Drawing.Size(323, 33);
            this.txtempid.TabIndex = 21;
            this.txtempid.UseSelectable = true;
            this.txtempid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtempid.WaterMarkFont = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtcontactno
            // 
            // 
            // 
            // 
            this.txtcontactno.CustomButton.Image = null;
            this.txtcontactno.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.txtcontactno.CustomButton.Name = "";
            this.txtcontactno.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtcontactno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcontactno.CustomButton.TabIndex = 1;
            this.txtcontactno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcontactno.CustomButton.UseSelectable = true;
            this.txtcontactno.CustomButton.Visible = false;
            this.txtcontactno.ForeColor = System.Drawing.Color.Black;
            this.txtcontactno.Lines = new string[0];
            this.txtcontactno.Location = new System.Drawing.Point(838, 560);
            this.txtcontactno.MaxLength = 32767;
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.PasswordChar = '\0';
            this.txtcontactno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcontactno.SelectedText = "";
            this.txtcontactno.SelectionLength = 0;
            this.txtcontactno.SelectionStart = 0;
            this.txtcontactno.ShortcutsEnabled = true;
            this.txtcontactno.Size = new System.Drawing.Size(289, 33);
            this.txtcontactno.TabIndex = 22;
            this.txtcontactno.UseSelectable = true;
            this.txtcontactno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcontactno.WaterMarkFont = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontactno_KeyPress);
            // 
            // txtdesignation
            // 
            // 
            // 
            // 
            this.txtdesignation.CustomButton.Image = null;
            this.txtdesignation.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtdesignation.CustomButton.Name = "";
            this.txtdesignation.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtdesignation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdesignation.CustomButton.TabIndex = 1;
            this.txtdesignation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdesignation.CustomButton.UseSelectable = true;
            this.txtdesignation.CustomButton.Visible = false;
            this.txtdesignation.ForeColor = System.Drawing.Color.Black;
            this.txtdesignation.Lines = new string[0];
            this.txtdesignation.Location = new System.Drawing.Point(1399, 560);
            this.txtdesignation.MaxLength = 32767;
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.PasswordChar = '\0';
            this.txtdesignation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdesignation.SelectedText = "";
            this.txtdesignation.SelectionLength = 0;
            this.txtdesignation.SelectionStart = 0;
            this.txtdesignation.ShortcutsEnabled = true;
            this.txtdesignation.Size = new System.Drawing.Size(268, 33);
            this.txtdesignation.TabIndex = 23;
            this.txtdesignation.UseSelectable = true;
            this.txtdesignation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdesignation.WaterMarkFont = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtsalary
            // 
            // 
            // 
            // 
            this.txtsalary.CustomButton.Image = null;
            this.txtsalary.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtsalary.CustomButton.Name = "";
            this.txtsalary.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtsalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsalary.CustomButton.TabIndex = 1;
            this.txtsalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsalary.CustomButton.UseSelectable = true;
            this.txtsalary.CustomButton.Visible = false;
            this.txtsalary.ForeColor = System.Drawing.Color.Black;
            this.txtsalary.Lines = new string[0];
            this.txtsalary.Location = new System.Drawing.Point(1399, 643);
            this.txtsalary.MaxLength = 32767;
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.PasswordChar = '\0';
            this.txtsalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsalary.SelectedText = "";
            this.txtsalary.SelectionLength = 0;
            this.txtsalary.SelectionStart = 0;
            this.txtsalary.ShortcutsEnabled = true;
            this.txtsalary.Size = new System.Drawing.Size(268, 33);
            this.txtsalary.TabIndex = 24;
            this.txtsalary.UseSelectable = true;
            this.txtsalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsalary.WaterMarkFont = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalary_KeyPress);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(416, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(536, 30);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Employee name";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(450, 35);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Employee name";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // ad_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtdesignation);
            this.Controls.Add(this.txtcontactno);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.metroSetLabel7);
            this.Controls.Add(this.cmbdepartment);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.metroSetLabel6);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ad_employee";
            this.Size = new System.Drawing.Size(1685, 855);
            this.Load += new System.EventHandler(this.ad_employee_Load);
            this.Leave += new System.EventHandler(this.ad_employee_Leave);
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
        private MetroSet_UI.Controls.MetroSetComboBox cmbgender;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private XanderUI.XUIButton xuiButton1;
        private XanderUI.XUIButton btnRemove;
        private XanderUI.XUIButton btnUpdate;
        private MetroSet_UI.Controls.MetroSetComboBox cmbdepartment;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroFramework.Controls.MetroTextBox txtempname;
        private MetroFramework.Controls.MetroTextBox txtempid;
        private MetroFramework.Controls.MetroTextBox txtcontactno;
        private MetroFramework.Controls.MetroTextBox txtdesignation;
        private MetroFramework.Controls.MetroTextBox txtsalary;
        private MetroFramework.Controls.MetroTextBox txtSearch;
    }
}
