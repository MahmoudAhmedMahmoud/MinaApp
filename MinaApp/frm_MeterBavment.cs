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
    public partial class frm_MeterBavment : Form
    {
        public frm_MeterBavment()
        {
            InitializeComponent();
        }

        //-----------------------------Cls-----------------------
        DataAccesLayer DAC = new DataAccesLayer();
        cls_Bavements CLSBav= new cls_Bavements();
        cls_Meters CLSMeters = new cls_Meters();
        cls_Message ClsMessage = new cls_Message();
        cls_MeterBavement CLSMB = new cls_MeterBavement();
       
        //-------------------------Function---------------------
        int insert_type;   //for Insert set 0 , for update set 1

        public void GetData()
        {
            dgv_Location.DataSource = CLSMB.SelectAllMeterBav();
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

        //-----------------------FrmLoad------------------------
        private void frm_MeterBavment_Load(object sender, EventArgs e)
        {
            cmb_BavName.DataSource = CLSBav.SelectAllBavements();
            cmb_BavName.DisplayMember = "اسم الرصيف";
            cmb_BavName.ValueMember = "كود الرصيف";
            //---
            cmb_MeterBronz.DataSource = CLSMeters.SelectAllMeters();
            cmb_MeterBronz.DisplayMember = "برونز العداد";
            cmb_MeterBronz.ValueMember = "برونز العداد";
            //----
            ClearData();
            GetData();
            //-----
            gb_Details.Enabled = false;
            btn_Add.Enabled = true;
            btn_Cancel.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Edite.Enabled = false;
            btn_Save.Enabled = false;
        }
     
        //-----------------------Btn-----------------------------
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
            gb_Details.Enabled = false;
            gb_Locations.Enabled=true; 
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
            gb_Details.Enabled = true;
            gb_Locations.Enabled = false;
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
            gb_Locations.Enabled = false;
            gb_Search.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (insert_type == 0)
            {
                CLSMB.InsertMeterBav(txt_LocationID.Text,cmb_MeterBronz.SelectedValue.ToString(),txt_BavID.Text,txt_Notes.Text);
                ClsMessage.InsertMessage();
            }
            else
            {
                CLSMB.UpdateMeterBav(txt_LocationID.Text,cmb_MeterBronz.SelectedText,txt_BavID.Text,txt_Notes.Text);
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
            gb_Locations.Enabled = true;
            gb_Search.Enabled = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = ClsMessage.AskDeleteMessage();
            if (R == DialogResult.Yes)
            {
                CLSMB.DeleteMeterBav(txt_LocationID.Text);
                GetData();
                ClearData();
            }
        }

        private void cmb_BavName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_BavID.Text = cmb_BavName.SelectedValue.ToString();
        }

    }
}
