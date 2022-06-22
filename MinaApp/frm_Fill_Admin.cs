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
    public partial class frm_Fill_Admin : Form
    {
        public frm_Fill_Admin()
        {
            InitializeComponent();
        }

        private void btn_RecordFill_Click(object sender, EventArgs e)
        {

        }

        private void btn_RecordFillPerson_Click(object sender, EventArgs e)
        {
            frm_FillPersons FFP = new frm_FillPersons();
            FFP.ShowDialog();
        }

        private void btn_Agents_Click(object sender, EventArgs e)
        {
            frm_Agents FA = new frm_Agents();
            FA.ShowDialog();
        }

        private void btn_AgentType_Click(object sender, EventArgs e)
        {
            frm_AgentType FAT = new frm_AgentType();
            FAT.ShowDialog();
        }

        private void btn_Ships_Click(object sender, EventArgs e)
        {
            frm_Ships FS = new frm_Ships();
            FS.ShowDialog();
        }

        private void btn_Nationality_Click(object sender, EventArgs e)
        {
            frm_ShipNationality FSN = new frm_ShipNationality();
            FSN.ShowDialog();
        }

    }
}
