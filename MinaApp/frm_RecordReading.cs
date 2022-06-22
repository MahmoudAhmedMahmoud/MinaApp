using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MinaApp
{
    public partial class frm_RecordReading : Form
    {
        public frm_RecordReading()
        {
            InitializeComponent();
        }

        //------------------------CLS----------------------
        DataAccesLayer DAC = new DataAccesLayer();
        cls_Message ClsMessage = new cls_Message();
        cls_MeterBavement clsMeterBavement = new cls_MeterBavement();
        cls_Readers clsReaders = new cls_Readers();
        //---------------------Function--------------------
        public string GetID()
        {
            string ID;
            DataTable Dt = DAC.SelectQue("select isnull(MAX(Reader_ID),1)from Readers_Table");
            ID = Dt.Rows[0][0].ToString();
            return ID;
        }

        public string Consumption()
        {
            string Consumption_Valu= (int.Parse(txt_CorrectionRead.Text) - int.Parse(txt_PrevReading.Text)).ToString();
            return Consumption_Valu;
        }

        //--------------------Frm Load---------------------
        private void frm_RecordReading_Load(object sender, EventArgs e)
        {
            lbl_Now.Text = DateTime.Now.ToString();
           
            //------Load List with Data--------------
            cmb_Reader.DataSource = clsReaders.SelectAllReaders();
            cmb_Reader.DisplayMember = "اسم القارئ";
            cmb_Reader.ValueMember = "كود القارئ";
            cmb_Reader.Text = "";
            
            //-------Auto Generate ID---------------
            txt_ReadingID.Text= GetID();
            
            //-------Load Grid With Data-------------
            dgv_Location.DataSource = clsMeterBavement.SelectAllMeterBav();

            //-------Current User & ID --------------
            lbl_User.Text = Properties.Settings.Default.CurruntUserName;
            lbl_UserID.Text = Properties.Settings.Default.CurrentUserID;
        }
        //----------------- Time on frm--------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Now.Text = DateTime.Now.ToString();
        }

        //---------------------Btns------------------------
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edite_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reads_Click(object sender, EventArgs e)
        {

        }

       //--------------Pic
        private void btn_AddPic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Op = new OpenFileDialog();
                if (Op.ShowDialog() == DialogResult.OK)
                {
                    pb_MeterPic.Image = Image.FromFile(Op.FileName);
                    btn_DeletePic.Enabled = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("يرجى التاكد من ان الملف الذى تم اختياره - صورة..");
            }
        }

        private void btn_DeletePic_Click(object sender, EventArgs e)
        {
            DialogResult R = new DialogResult();
            R = ClsMessage.AskDeleteMessage();
            if (R==DialogResult.Yes)
            {
                pb_MeterPic.Image = null;
                btn_DeletePic.Enabled = false;
            }
        }

       //--------------Search
        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_Location.DataSource = clsMeterBavement.SearchMeterBav(txt_LocationSearch.Text);
        }

       //-------------GridClick
        private void dgv_Location_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_LocationID.Text = dgv_Location.CurrentRow.Cells[0].Value.ToString();
            txt_Bronz.Text = dgv_Location.CurrentRow.Cells[1].Value.ToString();
        }
        //------- Work - Broken -----------------------------------------
        private void rb_Work_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Work.Checked==true)
            {
                txt_CorrectionRead.Text = txt_NowReading.Text;
                txt_CorrectionRead.Enabled = false;
            }
        }

        private void rb_Broken_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Broken.Checked==true)
            {
                txt_CorrectionRead.Enabled = true;
            }
        }

        private void txt_NowReading_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_CorrectionRead.Enabled == false)
                {
                    txt_CorrectionRead.Text = txt_NowReading.Text;
                    txt_Consumption.Text = Consumption();
                }
                else
                {
                    txt_Consumption.Text = Consumption();
                }
            }
            catch (Exception)
            {
                txt_Consumption.Clear();
            }

        }
    }
}
