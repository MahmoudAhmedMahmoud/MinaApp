namespace MinaApp
{
    partial class frm_RecordReading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RecordReading));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Now = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.gb_MeterPic = new System.Windows.Forms.GroupBox();
            this.btn_DeletePic = new System.Windows.Forms.Button();
            this.btn_AddPic = new System.Windows.Forms.Button();
            this.pb_MeterPic = new System.Windows.Forms.PictureBox();
            this.gb_Consumption = new System.Windows.Forms.GroupBox();
            this.txt_Consumption = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gb_Work_Broken = new System.Windows.Forms.GroupBox();
            this.rb_Broken = new System.Windows.Forms.RadioButton();
            this.rb_Work = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_Location = new System.Windows.Forms.DataGridView();
            this.txt_LocationSearch = new System.Windows.Forms.TextBox();
            this.cmb_Reader = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_CorrectionRead = new System.Windows.Forms.TextBox();
            this.txt_PrevReading = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ReadingID = new System.Windows.Forms.TextBox();
            this.txt_NowReading = new System.Windows.Forms.TextBox();
            this.txt_LocationID = new System.Windows.Forms.TextBox();
            this.dtp_TimeRead = new System.Windows.Forms.DateTimePicker();
            this.dtp_ReadDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edite = new System.Windows.Forms.Button();
            this.btn_Reads = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_Bronz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_MeterPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MeterPic)).BeginInit();
            this.gb_Consumption.SuspendLayout();
            this.gb_Work_Broken.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Location)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_UserID);
            this.panel1.Controls.Add(this.lbl_User);
            this.panel1.Controls.Add(this.lbl_Now);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 91);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(145, 68);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "المستخدم :";
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.ForeColor = System.Drawing.Color.White;
            this.lbl_UserID.Location = new System.Drawing.Point(207, 68);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_UserID.Size = new System.Drawing.Size(39, 21);
            this.lbl_UserID.TabIndex = 2;
            this.lbl_UserID.Text = "00";
            this.lbl_UserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_UserID.Visible = false;
            // 
            // lbl_User
            // 
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.Color.White;
            this.lbl_User.Location = new System.Drawing.Point(12, 68);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_User.Size = new System.Drawing.Size(136, 21);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "محمدود احمد";
            // 
            // lbl_Now
            // 
            this.lbl_Now.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Now.ForeColor = System.Drawing.Color.White;
            this.lbl_Now.Location = new System.Drawing.Point(523, 68);
            this.lbl_Now.Name = "lbl_Now";
            this.lbl_Now.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Now.Size = new System.Drawing.Size(182, 21);
            this.lbl_Now.TabIndex = 2;
            this.lbl_Now.Text = "15-10-2021 10:00 PM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(703, 68);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "التاريخ :";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(3, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(33, 30);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "تسجيل قراءات العدادات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_Notes);
            this.groupBox1.Controls.Add(this.gb_MeterPic);
            this.groupBox1.Controls.Add(this.gb_Consumption);
            this.groupBox1.Controls.Add(this.gb_Work_Broken);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmb_Reader);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_CorrectionRead);
            this.groupBox1.Controls.Add(this.txt_Bronz);
            this.groupBox1.Controls.Add(this.txt_PrevReading);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_ReadingID);
            this.groupBox1.Controls.Add(this.txt_NowReading);
            this.groupBox1.Controls.Add(this.txt_LocationID);
            this.groupBox1.Controls.Add(this.dtp_TimeRead);
            this.groupBox1.Controls.Add(this.dtp_ReadDate);
            this.groupBox1.Location = new System.Drawing.Point(2, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(769, 509);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(668, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "ملاحظـــــات";
            // 
            // txt_Notes
            // 
            this.txt_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Notes.Location = new System.Drawing.Point(343, 367);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(319, 128);
            this.txt_Notes.TabIndex = 11;
            // 
            // gb_MeterPic
            // 
            this.gb_MeterPic.Controls.Add(this.btn_DeletePic);
            this.gb_MeterPic.Controls.Add(this.btn_AddPic);
            this.gb_MeterPic.Controls.Add(this.pb_MeterPic);
            this.gb_MeterPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_MeterPic.Location = new System.Drawing.Point(11, 329);
            this.gb_MeterPic.Name = "gb_MeterPic";
            this.gb_MeterPic.Size = new System.Drawing.Size(326, 168);
            this.gb_MeterPic.TabIndex = 9;
            this.gb_MeterPic.TabStop = false;
            this.gb_MeterPic.Text = "صورة";
            // 
            // btn_DeletePic
            // 
            this.btn_DeletePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DeletePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_DeletePic.Enabled = false;
            this.btn_DeletePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeletePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeletePic.ForeColor = System.Drawing.Color.White;
            this.btn_DeletePic.Location = new System.Drawing.Point(8, 137);
            this.btn_DeletePic.Name = "btn_DeletePic";
            this.btn_DeletePic.Size = new System.Drawing.Size(32, 25);
            this.btn_DeletePic.TabIndex = 9;
            this.btn_DeletePic.Text = "X";
            this.btn_DeletePic.UseVisualStyleBackColor = false;
            this.btn_DeletePic.Click += new System.EventHandler(this.btn_DeletePic_Click);
            // 
            // btn_AddPic
            // 
            this.btn_AddPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_AddPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPic.ForeColor = System.Drawing.Color.White;
            this.btn_AddPic.Location = new System.Drawing.Point(8, 26);
            this.btn_AddPic.Name = "btn_AddPic";
            this.btn_AddPic.Size = new System.Drawing.Size(32, 25);
            this.btn_AddPic.TabIndex = 9;
            this.btn_AddPic.Text = "+";
            this.btn_AddPic.UseVisualStyleBackColor = false;
            this.btn_AddPic.Click += new System.EventHandler(this.btn_AddPic_Click);
            // 
            // pb_MeterPic
            // 
            this.pb_MeterPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_MeterPic.BackgroundImage")));
            this.pb_MeterPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_MeterPic.InitialImage = null;
            this.pb_MeterPic.Location = new System.Drawing.Point(46, 26);
            this.pb_MeterPic.Name = "pb_MeterPic";
            this.pb_MeterPic.Size = new System.Drawing.Size(265, 136);
            this.pb_MeterPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MeterPic.TabIndex = 0;
            this.pb_MeterPic.TabStop = false;
            // 
            // gb_Consumption
            // 
            this.gb_Consumption.Controls.Add(this.txt_Consumption);
            this.gb_Consumption.Controls.Add(this.label13);
            this.gb_Consumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Consumption.Location = new System.Drawing.Point(11, 262);
            this.gb_Consumption.Name = "gb_Consumption";
            this.gb_Consumption.Size = new System.Drawing.Size(212, 67);
            this.gb_Consumption.TabIndex = 9;
            this.gb_Consumption.TabStop = false;
            this.gb_Consumption.Text = "الاستهلاك";
            // 
            // txt_Consumption
            // 
            this.txt_Consumption.Enabled = false;
            this.txt_Consumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Consumption.Location = new System.Drawing.Point(44, 28);
            this.txt_Consumption.Name = "txt_Consumption";
            this.txt_Consumption.Size = new System.Drawing.Size(162, 26);
            this.txt_Consumption.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "طن";
            // 
            // gb_Work_Broken
            // 
            this.gb_Work_Broken.Controls.Add(this.rb_Broken);
            this.gb_Work_Broken.Controls.Add(this.rb_Work);
            this.gb_Work_Broken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Work_Broken.Location = new System.Drawing.Point(465, 262);
            this.gb_Work_Broken.Name = "gb_Work_Broken";
            this.gb_Work_Broken.Size = new System.Drawing.Size(83, 67);
            this.gb_Work_Broken.TabIndex = 9;
            this.gb_Work_Broken.TabStop = false;
            this.gb_Work_Broken.Text = "حالة العداد";
            // 
            // rb_Broken
            // 
            this.rb_Broken.AutoSize = true;
            this.rb_Broken.Location = new System.Drawing.Point(14, 40);
            this.rb_Broken.Name = "rb_Broken";
            this.rb_Broken.Size = new System.Drawing.Size(51, 20);
            this.rb_Broken.TabIndex = 0;
            this.rb_Broken.Text = "معطل";
            this.rb_Broken.UseVisualStyleBackColor = true;
            this.rb_Broken.CheckedChanged += new System.EventHandler(this.rb_Broken_CheckedChanged);
            // 
            // rb_Work
            // 
            this.rb_Work.AutoSize = true;
            this.rb_Work.Checked = true;
            this.rb_Work.Location = new System.Drawing.Point(18, 17);
            this.rb_Work.Name = "rb_Work";
            this.rb_Work.Size = new System.Drawing.Size(46, 20);
            this.rb_Work.TabIndex = 0;
            this.rb_Work.TabStop = true;
            this.rb_Work.Text = "سليم";
            this.rb_Work.UseVisualStyleBackColor = true;
            this.rb_Work.CheckedChanged += new System.EventHandler(this.rb_Work_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Search);
            this.groupBox2.Controls.Add(this.dgv_Location);
            this.groupBox2.Controls.Add(this.txt_LocationSearch);
            this.groupBox2.Location = new System.Drawing.Point(8, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 178);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المواقع";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(6, 14);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(32, 25);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "....";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_Location
            // 
            this.dgv_Location.AllowUserToAddRows = false;
            this.dgv_Location.AllowUserToDeleteRows = false;
            this.dgv_Location.AllowUserToResizeColumns = false;
            this.dgv_Location.AllowUserToResizeRows = false;
            this.dgv_Location.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Location.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(223)))));
            this.dgv_Location.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Location.Location = new System.Drawing.Point(6, 42);
            this.dgv_Location.Name = "dgv_Location";
            this.dgv_Location.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Location.Size = new System.Drawing.Size(743, 130);
            this.dgv_Location.TabIndex = 10;
            this.dgv_Location.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Location_CellMouseDoubleClick);
            // 
            // txt_LocationSearch
            // 
            this.txt_LocationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LocationSearch.Location = new System.Drawing.Point(44, 15);
            this.txt_LocationSearch.Name = "txt_LocationSearch";
            this.txt_LocationSearch.Size = new System.Drawing.Size(705, 23);
            this.txt_LocationSearch.TabIndex = 9;
            // 
            // cmb_Reader
            // 
            this.cmb_Reader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Reader.FormattingEnabled = true;
            this.cmb_Reader.Location = new System.Drawing.Point(520, 54);
            this.cmb_Reader.Name = "cmb_Reader";
            this.cmb_Reader.Size = new System.Drawing.Size(140, 28);
            this.cmb_Reader.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(668, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "القــارئ";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(161, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 53);
            this.label9.TabIndex = 5;
            this.label9.Text = "وقت القراءة الفعلى";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(368, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 53);
            this.label8.TabIndex = 5;
            this.label8.Text = "تاريخ القراءة الفعلى";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(350, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "القراءة التصحيحية";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(668, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "برونز العداد";
            // 
            // txt_CorrectionRead
            // 
            this.txt_CorrectionRead.Enabled = false;
            this.txt_CorrectionRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CorrectionRead.Location = new System.Drawing.Point(229, 301);
            this.txt_CorrectionRead.Name = "txt_CorrectionRead";
            this.txt_CorrectionRead.Size = new System.Drawing.Size(115, 26);
            this.txt_CorrectionRead.TabIndex = 6;
            // 
            // txt_PrevReading
            // 
            this.txt_PrevReading.Enabled = false;
            this.txt_PrevReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrevReading.Location = new System.Drawing.Point(465, 335);
            this.txt_PrevReading.Name = "txt_PrevReading";
            this.txt_PrevReading.Size = new System.Drawing.Size(197, 26);
            this.txt_PrevReading.TabIndex = 6;
            this.txt_PrevReading.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(350, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "القراءة الحالية";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(666, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "كود القراءة";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(668, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "كود الموقع";
            // 
            // txt_ReadingID
            // 
            this.txt_ReadingID.Enabled = false;
            this.txt_ReadingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReadingID.Location = new System.Drawing.Point(552, 15);
            this.txt_ReadingID.Name = "txt_ReadingID";
            this.txt_ReadingID.Size = new System.Drawing.Size(108, 26);
            this.txt_ReadingID.TabIndex = 6;
            // 
            // txt_NowReading
            // 
            this.txt_NowReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NowReading.Location = new System.Drawing.Point(229, 266);
            this.txt_NowReading.Name = "txt_NowReading";
            this.txt_NowReading.Size = new System.Drawing.Size(115, 26);
            this.txt_NowReading.TabIndex = 6;
            this.txt_NowReading.TextChanged += new System.EventHandler(this.txt_NowReading_TextChanged);
            // 
            // txt_LocationID
            // 
            this.txt_LocationID.Enabled = false;
            this.txt_LocationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LocationID.Location = new System.Drawing.Point(554, 268);
            this.txt_LocationID.Name = "txt_LocationID";
            this.txt_LocationID.Size = new System.Drawing.Size(108, 26);
            this.txt_LocationID.TabIndex = 6;
            // 
            // dtp_TimeRead
            // 
            this.dtp_TimeRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_TimeRead.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_TimeRead.Location = new System.Drawing.Point(56, 44);
            this.dtp_TimeRead.Name = "dtp_TimeRead";
            this.dtp_TimeRead.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_TimeRead.RightToLeftLayout = true;
            this.dtp_TimeRead.ShowUpDown = true;
            this.dtp_TimeRead.Size = new System.Drawing.Size(99, 23);
            this.dtp_TimeRead.TabIndex = 0;
            // 
            // dtp_ReadDate
            // 
            this.dtp_ReadDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ReadDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ReadDate.Location = new System.Drawing.Point(263, 44);
            this.dtp_ReadDate.Name = "dtp_ReadDate";
            this.dtp_ReadDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_ReadDate.RightToLeftLayout = true;
            this.dtp_ReadDate.Size = new System.Drawing.Size(99, 23);
            this.dtp_ReadDate.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 658);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 10);
            this.panel2.TabIndex = 18;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_Cancel);
            this.groupBox4.Controls.Add(this.btn_Add);
            this.groupBox4.Controls.Add(this.btn_Edite);
            this.groupBox4.Controls.Add(this.btn_Reads);
            this.groupBox4.Controls.Add(this.btn_Delete);
            this.groupBox4.Controls.Add(this.btn_Save);
            this.groupBox4.Location = new System.Drawing.Point(3, 607);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(769, 46);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancel.Location = new System.Drawing.Point(614, 13);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(113, 27);
            this.Btn_Cancel.TabIndex = 4;
            this.Btn_Cancel.Text = "الغاء";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(501, 13);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(113, 27);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "اضافة";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edite
            // 
            this.btn_Edite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Edite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_Edite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edite.ForeColor = System.Drawing.Color.White;
            this.btn_Edite.Location = new System.Drawing.Point(388, 13);
            this.btn_Edite.Name = "btn_Edite";
            this.btn_Edite.Size = new System.Drawing.Size(113, 27);
            this.btn_Edite.TabIndex = 4;
            this.btn_Edite.Text = "تعديل";
            this.btn_Edite.UseVisualStyleBackColor = false;
            this.btn_Edite.Click += new System.EventHandler(this.btn_Edite_Click);
            // 
            // btn_Reads
            // 
            this.btn_Reads.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Reads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_Reads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reads.ForeColor = System.Drawing.Color.White;
            this.btn_Reads.Location = new System.Drawing.Point(49, 13);
            this.btn_Reads.Name = "btn_Reads";
            this.btn_Reads.Size = new System.Drawing.Size(113, 27);
            this.btn_Reads.TabIndex = 4;
            this.btn_Reads.Text = "شاشة القراءات";
            this.btn_Reads.UseVisualStyleBackColor = false;
            this.btn_Reads.Click += new System.EventHandler(this.btn_Reads_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(162, 13);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(113, 27);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "حذف";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(275, 13);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(113, 27);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_Bronz
            // 
            this.txt_Bronz.Enabled = false;
            this.txt_Bronz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bronz.Location = new System.Drawing.Point(554, 302);
            this.txt_Bronz.Name = "txt_Bronz";
            this.txt_Bronz.Size = new System.Drawing.Size(108, 26);
            this.txt_Bronz.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(668, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "القراءة السابقة";
            // 
            // frm_RecordReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(775, 668);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_RecordReading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Reading";
            this.Load += new System.EventHandler(this.frm_RecordReading_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_MeterPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_MeterPic)).EndInit();
            this.gb_Consumption.ResumeLayout(false);
            this.gb_Consumption.PerformLayout();
            this.gb_Work_Broken.ResumeLayout(false);
            this.gb_Work_Broken.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Location)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Now;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_ReadDate;
        private System.Windows.Forms.ComboBox cmb_Reader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_LocationID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_TimeRead;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Location;
        private System.Windows.Forms.TextBox txt_LocationSearch;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox gb_Work_Broken;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_PrevReading;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gb_Consumption;
        private System.Windows.Forms.TextBox txt_Consumption;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rb_Broken;
        private System.Windows.Forms.RadioButton rb_Work;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_CorrectionRead;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_NowReading;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.GroupBox gb_MeterPic;
        private System.Windows.Forms.PictureBox pb_MeterPic;
        private System.Windows.Forms.Button btn_DeletePic;
        private System.Windows.Forms.Button btn_AddPic;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_ReadingID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edite;
        private System.Windows.Forms.Button btn_Reads;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Bronz;
    }
}