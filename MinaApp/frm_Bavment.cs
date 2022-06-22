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
    public partial class frm_Bavment : Form
    {
        public frm_Bavment()
        {
            InitializeComponent();
        }

        //-------------------------CLS------------------------------
        DataAccesLayer DAC = new DataAccesLayer();
        cls_Bavements ClsBav = new cls_Bavements();
        cls_Message ClsMessage = new cls_Message();

        //----------------------Functions---------------------------
        int insert_type;   //for Insert set 0 , for update set 1

        public void GetData()
        {
            dgv_Bavements.DataSource = ClsBav.SelectAllBavements();
        }

        public void ClearData()
        {
            foreach (Control Ctr in gb_Details.Controls)
            {
                if (Ctr is TextBox)
                {
                    Ctr.Text = "";
                }
            }
        }

        public string GetID()
        {
            string ID;
            DataTable Dt = DAC.SelectQue("select ISNULL(max(Bav_ID)+1,1) from Bavements_Table");
            ID = Dt.Rows[0][0].ToString();
            return ID;
        }


        //---------------------formLoad-----------------------------
        private void frm_Bavment_Load(object sender, EventArgs e)
        {
            GetData();
            gb_Details.Enabled = false;
            btn_Add.Enabled = true;
            btn_Cancel.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Edite.Enabled = false;
            btn_Save.Enabled = false;
        }

        //---------------------Buttons------------------------------
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
            gb_Bavements.Enabled = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ClearData();
            txt_BavID.Text=GetID();
            insert_type = 0;
            btn_Add.Enabled = false;
            btn_Cancel.Enabled = true;
            btn_Delete.Enabled = false;
            btn_Edite.Enabled = false;
            btn_Save.Enabled = true;
            gb_Details.Enabled = true;
            gb_Bavements.Enabled= false;
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
            gb_Bavements.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (insert_type == 0)
            {
                ClsBav.InsertNewBavement(txt_BavID.Text, txt_BavName.Text, txt_Notes.Text);
                ClsMessage.InsertMessage();
            }
            else
            {
                ClsBav.UpdateBavement(txt_BavID.Text, txt_BavName.Text, txt_Notes.Text);
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
            gb_Bavements.Enabled = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = ClsMessage.AskDeleteMessage();
            if (R == DialogResult.Yes)
            {
                ClsBav.DeleteBavement(txt_BavID.Text);
                GetData();
                ClearData();
            }
        }

        private void dgv_Bavements_DoubleClick(object sender, EventArgs e)
        {
            btn_Edite.Enabled = true;
            btn_Delete.Enabled = true;
            txt_BavID.Text = dgv_Bavements.CurrentRow.Cells[0].Value.ToString();
            txt_BavName.Text = dgv_Bavements.CurrentRow.Cells[1].Value.ToString();
            txt_Notes.Text = dgv_Bavements.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
