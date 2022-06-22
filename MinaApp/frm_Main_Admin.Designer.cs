namespace MinaApp
{
    partial class frm_Main_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main_Admin));
            this.pnl_Side = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnl_SelectBtn = new System.Windows.Forms.Panel();
            this.btn_Audit = new System.Windows.Forms.Button();
            this.btn_CashBox = new System.Windows.Forms.Button();
            this.btn_Accounting = new System.Windows.Forms.Button();
            this.btn_Filling = new System.Windows.Forms.Button();
            this.Btn_Meters = new System.Windows.Forms.Button();
            this.pnl_Logo = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Head = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_ScreenName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Side)).BeginInit();
            this.pnl_Side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Logo)).BeginInit();
            this.pnl_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Head)).BeginInit();
            this.pnl_Head.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Side
            // 
            this.pnl_Side.Controls.Add(this.pnl_SelectBtn);
            this.pnl_Side.Controls.Add(this.btn_Audit);
            this.pnl_Side.Controls.Add(this.btn_CashBox);
            this.pnl_Side.Controls.Add(this.btn_Accounting);
            this.pnl_Side.Controls.Add(this.btn_Filling);
            this.pnl_Side.Controls.Add(this.Btn_Meters);
            this.pnl_Side.Controls.Add(this.pnl_Logo);
            this.pnl_Side.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Side.Location = new System.Drawing.Point(1140, 0);
            this.pnl_Side.Name = "pnl_Side";
            this.pnl_Side.Size = new System.Drawing.Size(239, 842);
            this.pnl_Side.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnl_Side.TabIndex = 0;
            // 
            // pnl_SelectBtn
            // 
            this.pnl_SelectBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_SelectBtn.Location = new System.Drawing.Point(231, 788);
            this.pnl_SelectBtn.Name = "pnl_SelectBtn";
            this.pnl_SelectBtn.Size = new System.Drawing.Size(5, 51);
            this.pnl_SelectBtn.TabIndex = 3;
            // 
            // btn_Audit
            // 
            this.btn_Audit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_Audit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Audit.FlatAppearance.BorderSize = 0;
            this.btn_Audit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Audit.Font = new System.Drawing.Font("Hacen Tunisia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Audit.ForeColor = System.Drawing.Color.White;
            this.btn_Audit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Audit.Image")));
            this.btn_Audit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Audit.Location = new System.Drawing.Point(0, 324);
            this.btn_Audit.Name = "btn_Audit";
            this.btn_Audit.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btn_Audit.Size = new System.Drawing.Size(239, 56);
            this.btn_Audit.TabIndex = 7;
            this.btn_Audit.Text = "قسم المراجعة";
            this.btn_Audit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Audit.UseVisualStyleBackColor = false;
            this.btn_Audit.Click += new System.EventHandler(this.btn_Audit_Click);
            // 
            // btn_CashBox
            // 
            this.btn_CashBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_CashBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CashBox.FlatAppearance.BorderSize = 0;
            this.btn_CashBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CashBox.Font = new System.Drawing.Font("Hacen Tunisia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CashBox.ForeColor = System.Drawing.Color.White;
            this.btn_CashBox.Image = ((System.Drawing.Image)(resources.GetObject("btn_CashBox.Image")));
            this.btn_CashBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CashBox.Location = new System.Drawing.Point(0, 268);
            this.btn_CashBox.Name = "btn_CashBox";
            this.btn_CashBox.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.btn_CashBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_CashBox.Size = new System.Drawing.Size(239, 56);
            this.btn_CashBox.TabIndex = 6;
            this.btn_CashBox.Text = "قسم الخزينة";
            this.btn_CashBox.UseVisualStyleBackColor = false;
            this.btn_CashBox.Click += new System.EventHandler(this.btn_CashBox_Click);
            // 
            // btn_Accounting
            // 
            this.btn_Accounting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_Accounting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Accounting.FlatAppearance.BorderSize = 0;
            this.btn_Accounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Accounting.Font = new System.Drawing.Font("Hacen Tunisia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accounting.ForeColor = System.Drawing.Color.White;
            this.btn_Accounting.Image = ((System.Drawing.Image)(resources.GetObject("btn_Accounting.Image")));
            this.btn_Accounting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Accounting.Location = new System.Drawing.Point(0, 212);
            this.btn_Accounting.Name = "btn_Accounting";
            this.btn_Accounting.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.btn_Accounting.Size = new System.Drawing.Size(239, 56);
            this.btn_Accounting.TabIndex = 5;
            this.btn_Accounting.Text = "قسم الحسابات";
            this.btn_Accounting.UseVisualStyleBackColor = false;
            this.btn_Accounting.Click += new System.EventHandler(this.btn_Accounting_Click);
            // 
            // btn_Filling
            // 
            this.btn_Filling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_Filling.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Filling.FlatAppearance.BorderSize = 0;
            this.btn_Filling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filling.Font = new System.Drawing.Font("Hacen Tunisia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filling.ForeColor = System.Drawing.Color.White;
            this.btn_Filling.Image = ((System.Drawing.Image)(resources.GetObject("btn_Filling.Image")));
            this.btn_Filling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Filling.Location = new System.Drawing.Point(0, 156);
            this.btn_Filling.Name = "btn_Filling";
            this.btn_Filling.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btn_Filling.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Filling.Size = new System.Drawing.Size(239, 56);
            this.btn_Filling.TabIndex = 4;
            this.btn_Filling.Text = "قسم التموين";
            this.btn_Filling.UseVisualStyleBackColor = false;
            this.btn_Filling.Click += new System.EventHandler(this.btn_Filling_Click);
            // 
            // Btn_Meters
            // 
            this.Btn_Meters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Btn_Meters.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Meters.FlatAppearance.BorderSize = 0;
            this.Btn_Meters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Meters.Font = new System.Drawing.Font("Hacen Tunisia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Meters.ForeColor = System.Drawing.Color.White;
            this.Btn_Meters.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Meters.Image")));
            this.Btn_Meters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Meters.Location = new System.Drawing.Point(0, 100);
            this.Btn_Meters.Name = "Btn_Meters";
            this.Btn_Meters.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Btn_Meters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_Meters.Size = new System.Drawing.Size(239, 56);
            this.Btn_Meters.TabIndex = 3;
            this.Btn_Meters.Text = "قسم العدادات";
            this.Btn_Meters.UseVisualStyleBackColor = false;
            this.Btn_Meters.Click += new System.EventHandler(this.Btn_Meters_Click);
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.Controls.Add(this.pb_Logo);
            this.pnl_Logo.Controls.Add(this.label1);
            this.pnl_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(239, 100);
            this.pnl_Logo.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnl_Logo.TabIndex = 2;
            // 
            // pb_Logo
            // 
            this.pb_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pb_Logo.ErrorImage = null;
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.InitialImage = null;
            this.pb_Logo.Location = new System.Drawing.Point(161, 12);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(66, 73);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Logo.TabIndex = 3;
            this.pb_Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Hacen Tunisia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "فرع الميناء";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_Head
            // 
            this.pnl_Head.Controls.Add(this.btn_Minimize);
            this.pnl_Head.Controls.Add(this.btn_Exit);
            this.pnl_Head.Controls.Add(this.lbl_ScreenName);
            this.pnl_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Head.Location = new System.Drawing.Point(0, 0);
            this.pnl_Head.Name = "pnl_Head";
            this.pnl_Head.Size = new System.Drawing.Size(1140, 100);
            this.pnl_Head.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnl_Head.TabIndex = 1;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Location = new System.Drawing.Point(41, 8);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(33, 30);
            this.btn_Minimize.TabIndex = 4;
            this.btn_Minimize.Text = "-";
            this.btn_Minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(12, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(33, 30);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_ScreenName
            // 
            this.lbl_ScreenName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ScreenName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_ScreenName.Font = new System.Drawing.Font("Hacen Tunisia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScreenName.ForeColor = System.Drawing.Color.White;
            this.lbl_ScreenName.Location = new System.Drawing.Point(3, 35);
            this.lbl_ScreenName.Name = "lbl_ScreenName";
            this.lbl_ScreenName.Size = new System.Drawing.Size(1131, 28);
            this.lbl_ScreenName.TabIndex = 2;
            this.lbl_ScreenName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_Main_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 842);
            this.Controls.Add(this.pnl_Head);
            this.Controls.Add(this.pnl_Side);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frm_Main_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Main_Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Side)).EndInit();
            this.pnl_Side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Logo)).EndInit();
            this.pnl_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_Head)).EndInit();
            this.pnl_Head.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnl_Side;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnl_Logo;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnl_Head;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Audit;
        private System.Windows.Forms.Button btn_CashBox;
        private System.Windows.Forms.Button btn_Accounting;
        private System.Windows.Forms.Button btn_Filling;
        private System.Windows.Forms.Button Btn_Meters;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lbl_ScreenName;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel pnl_SelectBtn;
        private System.Windows.Forms.Button btn_Minimize;
    }
}