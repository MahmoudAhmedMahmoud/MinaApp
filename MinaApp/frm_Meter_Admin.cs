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
    public partial class frm_Meter_Admin : Form
    {
        public frm_Meter_Admin()
        {
            InitializeComponent();
        }

        private void btn_RecordReaders_Click(object sender, EventArgs e)
        {
            frm_Main_Admin FM = new frm_Main_Admin();
            frm_Readers FR = new frm_Readers();
            FR.ShowDialog();
        }

        private void btn_RecordBavement_Click(object sender, EventArgs e)
        {
            frm_Bavment FBav = new frm_Bavment();
            FBav.ShowDialog();
        }

        private void btn_RecordMeter_Click(object sender, EventArgs e)
        {
            frm_Meters FMeters = new frm_Meters();
            FMeters.ShowDialog();
        }

        private void btn_ConnectBanMet_Click(object sender, EventArgs e)
        {
            frm_MeterBavment FMB = new frm_MeterBavment();
            FMB.ShowDialog();
        }

        private void btn_ReadMeter_Click(object sender, EventArgs e)
        {
            frm_RecordReading FRR = new frm_RecordReading();
            FRR.ShowDialog();
        }
    }
}
