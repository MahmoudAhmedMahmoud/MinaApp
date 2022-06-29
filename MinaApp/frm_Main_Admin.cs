using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinaApp
{
    public partial class frm_Main_Admin : Form
    {
        public frm_Main_Admin()
        {
            InitializeComponent();
            pnl_SelectBtn.Visible = false;
        }

        //----------------------------Functions---------------------------------

        public void SelectBtn(Button Bt)
        {
            pnl_SelectBtn.Visible = true;
            pnl_SelectBtn.Height = Bt.Height;
            pnl_SelectBtn.Top = Bt.Top;
            pnl_SelectBtn.Left = Bt.Left;
            foreach (Control C in pnl_Side.Controls)
            {
                if (C is Button)
                {
                    C.BackColor = Color.FromArgb(39, 45, 45);
                }
            }
            Bt.BackColor = Color.FromArgb(64, 64, 64);
            lbl_ScreenName.Text = Bt.Text;

        }

        //-------------------------pnl_Head Btns--------------------------------
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_Connection_Click(object sender, EventArgs e)
        {

        }

        //------------------------pnl_Side Btns----------------------------------

        private void Btn_Meters_Click(object sender, EventArgs e)
        {
            frm_Meter_Admin FMA = new frm_Meter_Admin();
            FMA.MdiParent = this;
            FMA.Show();
            FMA.Dock = DockStyle.Fill;
            SelectBtn(Btn_Meters);
        }

        private void btn_Filling_Click(object sender, EventArgs e)
        {
            frm_Fill_Admin FFA = new frm_Fill_Admin();
            FFA.MdiParent = this;
            FFA.Show();
            FFA.Dock = DockStyle.Fill;
            SelectBtn(btn_Filling);
        }

        private void btn_Accounting_Click(object sender, EventArgs e)
        {
            SelectBtn(btn_Accounting);
        }

        private void btn_CashBox_Click(object sender, EventArgs e)
        {
            SelectBtn(btn_CashBox);
        }

        private void btn_Audit_Click(object sender, EventArgs e)
        {
            SelectBtn(btn_Audit);
        }

  
    }
}
