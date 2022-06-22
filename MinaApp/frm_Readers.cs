using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MinaApp
{
    public partial class frm_Readers : Form
    {
        public frm_Readers()
        {
            InitializeComponent();
        }
        //-------------------------------------cls---------------------------------------
        DataAccesLayer DAC = new DataAccesLayer();
        cls_Readers ClsReaders = new cls_Readers();
        cls_Message ClsMessage = new cls_Message();
        
        //-------------------------------------Functions----------------------------------
        int insert_type;   //for Insert set 0 , for update set 1
        public void GetData()
        {
            dgv_Readers.DataSource = ClsReaders.SelectAllReaders();
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
            string ID ;
            DataTable Dt = DAC.SelectQue("select ISNULL(max(Reader_ID)+1,1) from Readers_Table");
            ID  = Dt.Rows[0][0].ToString();
            return ID;
        }

        //------------------------------------FrmLoad------------------------------------
        private void frm_Readers_Load(object sender, EventArgs e)
        {
            GetData();
            gb_Details.Enabled = false;
            btn_Add.Enabled = true;
            btn_Cancel.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Edite.Enabled = false;
            btn_Save.Enabled = false;
        }

        //------------------------------------Buttons------------------------------------

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
            gb_Readers.Enabled = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ClearData();
            txt_ReaderId.Text = GetID(); 
            insert_type = 0;
            btn_Add.Enabled = false;
            btn_Cancel.Enabled = true;
            btn_Delete.Enabled = false;
            btn_Edite.Enabled = false;
            btn_Save.Enabled = true;
            gb_Details.Enabled = true;
            gb_Readers.Enabled = false;
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
            gb_Readers.Enabled = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (insert_type==0)
            {
                ClsReaders.InsertNewReader(txt_ReaderId.Text, txt_ReaderName.Text, txt_Number.Text, txt_Notes.Text);
                ClsMessage.InsertMessage();
            }
            else
            {
                ClsReaders.UpdateReader(txt_ReaderId.Text, txt_ReaderName.Text, txt_Number.Text, txt_Notes.Text);
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
            gb_Readers.Enabled = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult R;
            R = ClsMessage.AskDeleteMessage();
            if (R==DialogResult.Yes)
            {
                ClsReaders.DeleteReader(txt_ReaderId.Text);
                GetData();
                ClearData();
            }
        }

        private void dgv_Readers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Edite.Enabled = true;
            btn_Delete.Enabled = true;
            txt_ReaderId.Text = dgv_Readers.CurrentRow.Cells[0].Value.ToString();
            txt_ReaderName.Text = dgv_Readers.CurrentRow.Cells[1].Value.ToString();
            txt_Number.Text = dgv_Readers.CurrentRow.Cells[2].Value.ToString();
            txt_Notes.Text = dgv_Readers.CurrentRow.Cells[3].Value.ToString();
        }

    }
}
