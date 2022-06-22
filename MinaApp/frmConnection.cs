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
    public partial class frmConnection : Form
    {
        public frmConnection()
        {
            InitializeComponent();
        }
        DataAccesLayer DAC = new  DataAccesLayer();
        //------------------frm load -----------------------------
        public void loadData()
        {
            txt_ServerName.Text = Properties.Settings.Default.Server;
            txt_DBName.Text = Properties.Settings.Default.DataBase;
            txt_UserName.Text = Properties.Settings.Default.UserName;
            txt_Password.Text = Properties.Settings.Default.Password;
            btn_Connect.Focus();
        }
        private void frmConnection_Load(object sender, EventArgs e)
        {
            loadData();
        }
        //--------------------------btn--------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txt_ServerName.Text;
            Properties.Settings.Default.DataBase = txt_DBName.Text;
            Properties.Settings.Default.UserName = txt_UserName.Text;
            Properties.Settings.Default.Password = txt_Password.Text;
            Properties.Settings.Default.Save();
            loadData();
            SqlConnection Cn = new SqlConnection();
            string Server_Name = Properties.Settings.Default.Server;
            string DataBase_Name = Properties.Settings.Default.DataBase;
            string DB_User = Properties.Settings.Default.UserName;
            string DB_Password = Properties.Settings.Default.Password;

            Cn = new SqlConnection("Server=" + Server_Name + ";Database=" + DataBase_Name + ";UID=" + DB_User + ";PWD=" + DB_Password + ";");
            try
            {
                Cn.Open();
                if (Cn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connection successful");
                    this.Close();
                }
                Cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Faild");
            }

        }


    }
}
