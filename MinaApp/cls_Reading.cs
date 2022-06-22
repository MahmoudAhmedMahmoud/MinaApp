using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MinaApp
{
    internal class cls_Reading
    {
        DataAccesLayer DAC = new DataAccesLayer();

        public DataTable SelectAllReads()
        {
            DataTable Dt = new DataTable();
            Dt = DAC.Select("", null);
            return Dt;
        }

        public DataTable SelectReads(string ReaderID)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("@ReaderID", SqlDbType.NVarChar, 50);
            Par[0].Value = ReaderID;
            Dt = DAC.Select("Sp_SelectReader", Par);
            return Dt;
        }

        //public void InsertNewReader(string ReaderID, string ReaderName, string ReaderNumber, string Notes)
        //{
        //    //SqlParameter[] Par = new SqlParameter[4];
        //    //Par[0] = new SqlParameter("@ReaderID", SqlDbType.NVarChar, 50);
        //    //Par[0].Value = ReaderID;
        //    //Par[1] = new SqlParameter("@ReaderName", SqlDbType.NVarChar, 50);
        //    //Par[1].Value = ReaderName;
        //    //Par[2] = new SqlParameter("@Number", SqlDbType.NVarChar, 50);
        //    //Par[2].Value = ReaderNumber;
        //    //Par[3] = new SqlParameter("@Notes", SqlDbType.NVarChar, 50);
        //    //Par[3].Value = Notes;
        //    //DAC.ExcCmd("SP_InsertReader", Par);
        //}

        //public void UpdateReader(string ReaderID, string ReaderName, string ReaderNumber, string Notes)
        //{
        //    //SqlParameter[] Par = new SqlParameter[4];
        //    //Par[0] = new SqlParameter("@ReaderID", SqlDbType.NVarChar, 50);
        //    //Par[0].Value = ReaderID;
        //    //Par[1] = new SqlParameter("@ReaderName", SqlDbType.NVarChar, 50);
        //    //Par[1].Value = ReaderName;
        //    //Par[2] = new SqlParameter("@Number", SqlDbType.NVarChar, 50);
        //    //Par[2].Value = ReaderNumber;
        //    //Par[3] = new SqlParameter("@Notes", SqlDbType.NVarChar, 50);
        //    //Par[3].Value = Notes;
        //    //DAC.ExcCmd("SP_UpdateReader", Par);
        //}

        //public void DeleteReader(string ReaderID)
        //{
        //    SqlParameter[] Par = new SqlParameter[1];
        //    Par[0] = new SqlParameter("@ReaderID", SqlDbType.NVarChar, 50);
        //    Par[0].Value = ReaderID;
        //    DAC.ExcCmd("SP_DeleteReader", Par);
        //}
    }
}
