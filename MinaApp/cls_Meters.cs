using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MinaApp
{
    class cls_Meters
    {
        DataAccesLayer DAC = new DataAccesLayer();

        public DataTable SelectAllMeters()
        {
            DataTable Dt = new DataTable();
            Dt = DAC.Select("Sp_SelectAllMeters", null);
            return Dt;
        }

        public DataTable SelectMeter(string Meater_B_ID)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("@Meater_B_ID", SqlDbType.NVarChar, 50);
            Par[0].Value = Meater_B_ID;
            Dt = DAC.Select("Sp_SelectMeter", Par);
            return Dt;
        }

        public void InsertNewMeter(string Meater_B_ID, string Meater_no, string Diameter, string Start_Reading, string M_Status, string Notes)
        {
            SqlParameter[] Par = new SqlParameter[6];
            Par[0] = new SqlParameter("@Meater_B_ID", SqlDbType.NVarChar, 50);
            Par[0].Value = Meater_B_ID;
            Par[1] = new SqlParameter("@Meater_no", SqlDbType.NVarChar, 50);
            Par[1].Value = Meater_no;
            Par[2] = new SqlParameter("@Diameter", SqlDbType.NVarChar, 50);
            Par[2].Value = Diameter;
            Par[3] = new SqlParameter("@Start_Reading", SqlDbType.NVarChar, 50);
            Par[3].Value = Start_Reading;
            Par[4] = new SqlParameter("@M_Status", SqlDbType.NVarChar, 50);
            Par[4].Value = M_Status;
            Par[5] = new SqlParameter("@Notes", SqlDbType.NVarChar, 200);
            Par[5].Value = Notes;
            DAC.ExcCmd("SP_InsertMeter", Par);
        }

        public void UpdateMeter(string Meater_B_ID, string Meater_no, string Diameter, string Start_Reading, string M_Status, string Notes)
        {
            SqlParameter[] Par = new SqlParameter[6];
            Par[0] = new SqlParameter("@Meater_B_ID", SqlDbType.NVarChar, 50);
            Par[0].Value = Meater_B_ID;
            Par[1] = new SqlParameter("@Meater_no", SqlDbType.NVarChar, 50);
            Par[1].Value = Meater_no;
            Par[2] = new SqlParameter("@Diameter", SqlDbType.NVarChar, 50);
            Par[2].Value = Diameter;
            Par[3] = new SqlParameter("@Start_Reading", SqlDbType.NVarChar, 50);
            Par[3].Value = Start_Reading;
            Par[4] = new SqlParameter("@M_Status", SqlDbType.NVarChar, 50);
            Par[4].Value = M_Status;
            Par[5] = new SqlParameter("@Notes", SqlDbType.NVarChar, 200);
            Par[5].Value = Notes;
            DAC.ExcCmd("SP_UpdateMeter", Par);
        }

        public void DeleteMeter(string Meater_B_ID)
        {
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("Meater_B_ID", SqlDbType.NVarChar, 50);
            Par[0].Value = Meater_B_ID;
            DAC.ExcCmd("SP_DeleteMeter", Par);
        }

        public DataTable SearchMeter(string @Search)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] Par = new SqlParameter[1];
            Par[0] = new SqlParameter("@Search", SqlDbType.NVarChar, 50);
            Par[0].Value = Search;
            Dt = DAC.Select("Sp_SearchMeter", Par);
            return Dt;
        }
    }
}
