using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MinaApp
{
    class cls_Bavements
    {
        DataAccesLayer DAC = new DataAccesLayer();

        public DataTable SelectAllBavements()
        {
            DataTable Dt = new DataTable();
            Dt = DAC.Select("Sp_SelectAllBavements", null);
            return Dt;
        }

        public DataTable SelectBavemet(string ReaderID)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("@BavID", SqlDbType.NVarChar, 50);
            Par[0].Value = ReaderID;
            Dt = DAC.Select("Sp_SelectBavement", Par);
            return Dt;
        }

        public void InsertNewBavement(string BavId, string BavName, string Notes)
        {
            SqlParameter[] Par = new SqlParameter[3];
            Par[0] = new SqlParameter("@BavId", SqlDbType.NVarChar, 50);
            Par[0].Value = BavId;
            Par[1] = new SqlParameter("@BavName", SqlDbType.NVarChar, 50);
            Par[1].Value = BavName;
            Par[2] = new SqlParameter("@Notes", SqlDbType.NVarChar, 200);
            Par[2].Value = Notes;
            DAC.ExcCmd("SP_InsertBavement", Par);
        }

        public void UpdateBavement(string BavId, string BavName, string Notes)
        {
            SqlParameter[] Par = new SqlParameter[3];
            Par[0] = new SqlParameter("@BavId", SqlDbType.NVarChar, 50);
            Par[0].Value = BavId;
            Par[1] = new SqlParameter("@BavName", SqlDbType.NVarChar, 50);
            Par[1].Value = BavName;
            Par[2] = new SqlParameter("@Notes", SqlDbType.NVarChar, 200);
            Par[2].Value = Notes;
            DAC.ExcCmd("SP_UpdateBavement", Par);
        }

        public void DeleteBavement(string BavId)
        {
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("@BavId", SqlDbType.NVarChar, 50);
            Par[0].Value = BavId;
            DAC.ExcCmd("SP_DeleteBavement", Par);
        }
    }
}
