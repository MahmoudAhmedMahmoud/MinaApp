using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MinaApp
{
    class cls_MeterBavement
    {
        DataAccesLayer DAC = new DataAccesLayer();

        public DataTable SelectAllMeterBav()
        {
            DataTable Dt = new DataTable();
            Dt = DAC.Select("Sp_SelectAllMeterBav", null);
            return Dt;
        }

        public DataTable SelectMeterBav(string M_BAV_ID)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("@M_BAV_ID", SqlDbType.NVarChar, 50);
            Par[0].Value = M_BAV_ID;
            Dt = DAC.Select("Sp_SelectMeterBav", Par);
            return Dt;
        }

        public void InsertMeterBav(string M_BAV_ID, string Meater_B_ID, string Bav_ID, string Notes)
        {
            SqlParameter[] Par = new SqlParameter[4];
            Par[0] = new SqlParameter("@M_BAV_ID", SqlDbType.NVarChar, 50);
            Par[0].Value = M_BAV_ID;
            Par[1] = new SqlParameter("@Meater_B_ID", SqlDbType.NVarChar, 50);
            Par[1].Value = Meater_B_ID;
            Par[2] = new SqlParameter("@Bav_ID", SqlDbType.NVarChar, 50);
            Par[2].Value = Bav_ID;
            Par[3] = new SqlParameter("@Notes", SqlDbType.NVarChar, 200);
            Par[3].Value = Notes;
            DAC.ExcCmd("SP_InsertMeterBav", Par);
        }

        public void UpdateMeterBav(string M_BAV_ID, string Meater_B_ID, string Bav_ID, string Notes)
        {
            SqlParameter[] Par = new SqlParameter[4];
            Par[0] = new SqlParameter("@M_BAV_ID", SqlDbType.NVarChar, 50);
            Par[0].Value = M_BAV_ID;
            Par[1] = new SqlParameter("@Meater_B_ID", SqlDbType.NVarChar, 50);
            Par[1].Value = Meater_B_ID;
            Par[2] = new SqlParameter("@Bav_ID", SqlDbType.NVarChar, 50);
            Par[2].Value = Bav_ID;
            Par[3] = new SqlParameter("@Notes", SqlDbType.NVarChar, 200);
            Par[3].Value = Notes;
            DAC.ExcCmd("SP_UpdateMeterBav", Par);
        }

        public void DeleteMeterBav(string M_BAV_ID)
        {
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("M_BAV_ID", SqlDbType.NVarChar, 50);
            Par[0].Value = @M_BAV_ID;
            DAC.ExcCmd("SP_DeleteMeterBav", Par);
        }

        public DataTable SearchMeterBav(string @Search)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("@Search", SqlDbType.NVarChar, 50);
            Par[0].Value = Search;
            Dt = DAC.Select("Sp_SearchMeterBav", Par);
            return Dt;
        }

    }
}
