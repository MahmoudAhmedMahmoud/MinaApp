using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MinaApp
{
    class DataAccesLayer
    {
        //-----------------Connection String --------------------------

        SqlConnection Cn = new SqlConnection();
        string Server_Name = Properties.Settings.Default.Server;
        string DataBase_Name = Properties.Settings.Default.DataBase;
        string DB_User = Properties.Settings.Default.UserName;
        string DB_Password = Properties.Settings.Default.Password;

        //-----------------------------------------------------------
        public DataAccesLayer()
        {
            Cn = new SqlConnection("Server=" + Server_Name + ";Database=" + DataBase_Name + ";UID=" + DB_User + ";PWD=" + DB_Password + ";");
        }

        public void CnOpen()
        {
            if (Cn.State==ConnectionState.Closed)
            {
                Cn.Open();
            }
        }

        public void CnClose()
        {
            if (Cn.State==ConnectionState.Open)
            {
                Cn.Close();
            }
        }

        public DataTable Select(string SP, SqlParameter[] Par)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = SP;
            Cmd.Connection = Cn;
            if (Par!=null)
            {
                Cmd.Parameters.AddRange(Par);
            }
            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }

        public DataTable SelectQue(string Que)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = Que;
            Cmd.Connection = Cn;
            SqlDataAdapter Da = new SqlDataAdapter(Cmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }

        public void ExcCmd(String SP, SqlParameter[] Par)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = SP;
            Cmd.Connection = Cn;
            if (Par!=null)
            {
                Cmd.Parameters.AddRange(Par);
            }
            CnOpen();
            Cmd.ExecuteNonQuery();
            CnClose();
        }

        public void ExcQue(string Que)
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = Que;
            Cmd.Connection = Cn;
            CnOpen();
            Cmd.ExecuteNonQuery();
            CnClose();
        }
    }
}
