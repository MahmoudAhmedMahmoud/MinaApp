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
    public partial class frm_Meters : Form
    {
        public frm_Meters()
        {
            InitializeComponent();
        }

        //------------------------CLS---------------------
        DataAccesLayer DAC   = new DataAccesLayer();
        cls_Message ClsMessage = new cls_Message();
        cls_Meters ClsMeter = new cls_Meters();

        //--------------------Function-------------------
        int insert_type;   //for Insert set 0 , for update set 1

        public void GetData()
        {
           dgv_Meters.DataSource = ClsMeter.SelectAllMeters();
        }

        public void ClearData()
        {
            foreach (Control Ctr in gb_Details.Controls)
            {
                if (Ctr is TextBox || Ctr is ComboBox)
                {
                    Ctr.Text = "";
                }
            }
        }

        //-------------------FrmLoad---------------------
        private void frm_Meters_Load(object sender, EventArgs e)
        {
            GetData();
            gb_Details.Enabled = false;
            btn_Add.Enabled = true;
            btn_Cancel.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Edite.Enabled = false;
            btn_Save.Enabled = false;
            btn_ConnectToBavment.Enabled = false;
        }

        //-------------------Buttons--------------------
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearData();
            btn_Add.Enabled = true;
            btn_Cancel.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Edite.Enabled = false;
            btn_Save.Enabled = false;
            btn_ConnectToBavment.Enabled = false;
            gb_Details.Enabled = false;
            gb_Meter.Enabled = true;
            gb_Search.Enabled = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ClearData();
            insert_type = 0;
            btn_Add.Enabled = false;
            btn_Cancel.Enabled = true;
            btn_Delete.Enabled = false;
            btn_Edite.Enabled = false;
            btn_Save.Enabled = true;
            btn_ConnectToBavment.Enabled = false;
            gb_Details.Enabled = true;
            gb_Meter.Enabled = false;
            gb_Search.Enabled = false;
        }

        private void btn_Edite_Click(object sender, EventArgs e)
        {
            insert_type = 1;
            btn_Add.Enabled = false;
            btn_Cancel.Enabled = true;
            btn_Delete.Enabled = false;
            btn_Edite.Enabled = false;
            btn_Save.Enabled = true;
            gb_Details.Enabled = true;
            gb_Meter.Enabled = false;
            gb_Search.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (insert_type == 0)
            {
                ClsMeter.InsertNewMeter(txt_MeterBronze.Text,txt_MeterNo.Text,txt_Diameter.Text,txt_StartReading.Text,cmb_MeterStatu.SelectedText.ToString(),txt_Notes.Text);
                ClsMessage.InsertMessage();
            }
            else
            {
                ClsMeter.UpdateMeter(txt_MeterBronze.Text, txt_MeterNo.Text, txt_Diameter.Text, txt_StartReading.Text, cmb_MeterStatu.SelectedItem.ToString(), txt_Notes.Text);
                ClsMessage.Updatemessage();
            }
            GetData();
            gb_Details.Enabled = false;
            btn_Add.Enabled = true;
            btn_Cancel.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Edite.Enabled = false;
            btn_Save.Enabled = false;
            gb_Details.Enabled = false;
            gb_Meter.Enabled = true;
            gb_Search.Enabled = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = ClsMessage.AskDeleteMessage();
            if (R == DialogResult.Yes)
            {
                ClsMeter.DeleteMeter(txt_MeterBronze.Text);
                GetData();
                ClearData();
            }
        }

        private void btn_ConnectToBavment_Click(object sender, EventArgs e)
        {
            frm_MeterBavment FMB = new frm_MeterBavment();
            FMB.Show();
            this.Hide();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            dgv_Meters.DataSource = ClsMeter.SearchMeter(txt_Search.Text);
        }

        private void dgv_Meters_DoubleClick(object sender, EventArgs e)
        {
            btn_Edite.Enabled = true;
            btn_Delete.Enabled = true;
            txt_MeterBronze.Text = dgv_Meters.CurrentRow.Cells[0].Value.ToString();
            txt_MeterNo.Text = dgv_Meters.CurrentRow.Cells[1].Value.ToString();
            txt_Diameter.Text = dgv_Meters.CurrentRow.Cells[2].Value.ToString();
            txt_StartReading.Text = dgv_Meters.CurrentRow.Cells[3].Value.ToString();
            cmb_MeterStatu.Text = dgv_Meters.CurrentRow.Cells[4].Value.ToString();
            txt_Notes.Text = dgv_Meters.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
