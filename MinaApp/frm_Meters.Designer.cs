namespace MinaApp
{
    partial class frm_Meters
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Details = new System.Windows.Forms.GroupBox();
            this.cmb_MeterStatu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.txt_MeterBronze = new System.Windows.Forms.TextBox();
            this.txt_StartReading = new System.Windows.Forms.TextBox();
            this.txt_MeterNo = new System.Windows.Forms.TextBox();
            this.txt_Diameter = new System.Windows.Forms.TextBox();
            this.gb_Meter = new System.Windows.Forms.GroupBox();
            this.dgv_Meters = new System.Windows.Forms.DataGridView();
            this.gb_Search = new System.Windows.Forms.GroupBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edite = new System.Windows.Forms.Button();
            this.btn_ConnectToBavment = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.gb_Details.SuspendLayout();
            this.gb_Meter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Meters)).BeginInit();
            this.gb_Search.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 72);
            this.panel1.TabIndex = 1;
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
            this.label1.Font = new System.Drawing.Font("Hacen Tunisia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "تسجيل العدادات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gb_Details
            // 
            this.gb_Details.Controls.Add(this.cmb_MeterStatu);
            this.gb_Details.Controls.Add(this.label3);
            this.gb_Details.Controls.Add(this.label2);
            this.gb_Details.Controls.Add(this.label7);
            this.gb_Details.Controls.Add(this.label6);
            this.gb_Details.Controls.Add(this.label8);
            this.gb_Details.Controls.Add(this.label5);
            this.gb_Details.Controls.Add(this.txt_Notes);
            this.gb_Details.Controls.Add(this.txt_MeterBronze);
            this.gb_Details.Controls.Add(this.txt_StartReading);
            this.gb_Details.Controls.Add(this.txt_MeterNo);
            this.gb_Details.Controls.Add(this.txt_Diameter);
            this.gb_Details.Font = new System.Drawing.Font("Hacen Tunisia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Details.Location = new System.Drawing.Point(3, 78);
            this.gb_Details.Name = "gb_Details";
            this.gb_Details.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_Details.Size = new System.Drawing.Size(769, 162);
            this.gb_Details.TabIndex = 7;
            this.gb_Details.TabStop = false;
            this.gb_Details.Text = "تسجيل البيانات";
            // 
            // cmb_MeterStatu
            // 
            this.cmb_MeterStatu.FormattingEnabled = true;
            this.cmb_MeterStatu.Items.AddRange(new object[] {
            "يعمل",
            "عاطل"});
            this.cmb_MeterStatu.Location = new System.Drawing.Point(274, 66);
            this.cmb_MeterStatu.Name = "cmb_MeterStatu";
            this.cmb_MeterStatu.Size = new System.Drawing.Size(100, 29);
            this.cmb_MeterStatu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hacen Tunisia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(641, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "برونز العداد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hacen Tunisia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "قطر العداد";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hacen Tunisia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "حالة العداد";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hacen Tunisia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(641, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "قراءة بداية العداد";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Hacen Tunisia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(380, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "رقم العداد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hacen Tunisia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(641, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "ملاحظــــــــــات";
            // 
            // txt_Notes
            // 
            this.txt_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Notes.Location = new System.Drawing.Point(21, 104);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(614, 47);
            this.txt_Notes.TabIndex = 2;
            // 
            // txt_MeterBronze
            // 
            this.txt_MeterBronze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MeterBronze.Location = new System.Drawing.Point(535, 30);
            this.txt_MeterBronze.Name = "txt_MeterBronze";
            this.txt_MeterBronze.Size = new System.Drawing.Size(100, 26);
            this.txt_MeterBronze.TabIndex = 2;
            // 
            // txt_StartReading
            // 
            this.txt_StartReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StartReading.Location = new System.Drawing.Point(484, 67);
            this.txt_StartReading.Name = "txt_StartReading";
            this.txt_StartReading.Size = new System.Drawing.Size(151, 26);
            this.txt_StartReading.TabIndex = 2;
            // 
            // txt_MeterNo
            // 
            this.txt_MeterNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MeterNo.Location = new System.Drawing.Point(274, 31);
            this.txt_MeterNo.Name = "txt_MeterNo";
            this.txt_MeterNo.Size = new System.Drawing.Size(100, 26);
            this.txt_MeterNo.TabIndex = 2;
            // 
            // txt_Diameter
            // 
            this.txt_Diameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Diameter.Location = new System.Drawing.Point(33, 30);
            this.txt_Diameter.Name = "txt_Diameter";
            this.txt_Diameter.Size = new System.Drawing.Size(100, 26);
            this.txt_Diameter.TabIndex = 2;
            // 
            // gb_Meter
            // 
            this.gb_Meter.Controls.Add(this.dgv_Meters);
            this.gb_Meter.Font = new System.Drawing.Font("Hacen Tunisia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Meter.Location = new System.Drawing.Point(3, 304);
            this.gb_Meter.Name = "gb_Meter";
            this.gb_Meter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_Meter.Size = new System.Drawing.Size(769, 169);
            this.gb_Meter.TabIndex = 8;
            this.gb_Meter.TabStop = false;
            this.gb_Meter.Text = "قراء العدادات";
            // 
            // dgv_Meters
            // 
            this.dgv_Meters.AllowUserToAddRows = false;
            this.dgv_Meters.AllowUserToDeleteRows = false;
            this.dgv_Meters.AllowUserToResizeRows = false;
            this.dgv_Meters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Meters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(223)))));
            this.dgv_Meters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Hacen Tunisia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Meters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Meters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Meters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Meters.EnableHeadersVisualStyles = false;
            this.dgv_Meters.Location = new System.Drawing.Point(3, 24);
            this.dgv_Meters.Name = "dgv_Meters";
            this.dgv_Meters.ReadOnly = true;
            this.dgv_Meters.RowHeadersWidth = 10;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(223)))));
            this.dgv_Meters.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Meters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Meters.Size = new System.Drawing.Size(763, 142);
            this.dgv_Meters.TabIndex = 3;
            this.dgv_Meters.DoubleClick += new System.EventHandler(this.dgv_Meters_DoubleClick);
            // 
            // gb_Search
            // 
            this.gb_Search.Controls.Add(this.txt_Search);
            this.gb_Search.Font = new System.Drawing.Font("Hacen Tunisia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Search.Location = new System.Drawing.Point(3, 246);
            this.gb_Search.Name = "gb_Search";
            this.gb_Search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gb_Search.Size = new System.Drawing.Size(769, 52);
            this.gb_Search.TabIndex = 9;
            this.gb_Search.TabStop = false;
            this.gb_Search.Text = "بحث";
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(9, 19);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(751, 26);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Cancel);
            this.groupBox4.Controls.Add(this.btn_Add);
            this.groupBox4.Controls.Add(this.btn_Edite);
            this.groupBox4.Controls.Add(this.btn_ConnectToBavment);
            this.groupBox4.Controls.Add(this.btn_Delete);
            this.groupBox4.Controls.Add(this.btn_Save);
            this.groupBox4.Location = new System.Drawing.Point(3, 479);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(769, 46);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Hacen Tunisia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(588, 13);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(113, 27);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "الغاء";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Hacen Tunisia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(482, 13);
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
            this.btn_Edite.Font = new System.Drawing.Font("Hacen Tunisia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edite.ForeColor = System.Drawing.Color.White;
            this.btn_Edite.Location = new System.Drawing.Point(376, 13);
            this.btn_Edite.Name = "btn_Edite";
            this.btn_Edite.Size = new System.Drawing.Size(113, 27);
            this.btn_Edite.TabIndex = 4;
            this.btn_Edite.Text = "تعديل";
            this.btn_Edite.UseVisualStyleBackColor = false;
            this.btn_Edite.Click += new System.EventHandler(this.btn_Edite_Click);
            // 
            // btn_ConnectToBavment
            // 
            this.btn_ConnectToBavment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ConnectToBavment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_ConnectToBavment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConnectToBavment.Font = new System.Drawing.Font("Hacen Tunisia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConnectToBavment.ForeColor = System.Drawing.Color.White;
            this.btn_ConnectToBavment.Location = new System.Drawing.Point(53, 13);
            this.btn_ConnectToBavment.Name = "btn_ConnectToBavment";
            this.btn_ConnectToBavment.Size = new System.Drawing.Size(113, 27);
            this.btn_ConnectToBavment.TabIndex = 4;
            this.btn_ConnectToBavment.Text = "ربط العداد برصيف";
            this.btn_ConnectToBavment.UseVisualStyleBackColor = false;
            this.btn_ConnectToBavment.Click += new System.EventHandler(this.btn_ConnectToBavment_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Hacen Tunisia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(164, 13);
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
            this.btn_Save.Font = new System.Drawing.Font("Hacen Tunisia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(270, 13);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(113, 27);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 10);
            this.panel2.TabIndex = 11;
            // 
            // frm_Meters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(775, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gb_Search);
            this.Controls.Add(this.gb_Meter);
            this.Controls.Add(this.gb_Details);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Meters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_Meters_Load);
            this.panel1.ResumeLayout(false);
            this.gb_Details.ResumeLayout(false);
            this.gb_Details.PerformLayout();
            this.gb_Meter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Meters)).EndInit();
            this.gb_Search.ResumeLayout(false);
            this.gb_Search.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.TextBox txt_MeterBronze;
        private System.Windows.Forms.TextBox txt_Diameter;
        private System.Windows.Forms.ComboBox cmb_MeterStatu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_StartReading;
        private System.Windows.Forms.TextBox txt_MeterNo;
        private System.Windows.Forms.GroupBox gb_Meter;
        private System.Windows.Forms.DataGridView dgv_Meters;
        private System.Windows.Forms.GroupBox gb_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edite;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ConnectToBavment;
    }
}