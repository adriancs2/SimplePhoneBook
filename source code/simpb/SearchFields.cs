using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace SimPB
{
    class SearchFields
    {
        public bool Name = true;
        public bool Tel = true;
        public bool HomeTel = true;
        public bool MobileTel = true;
        public bool WorkTel = true;
        public bool Email = true;
        public bool Address = true;
        public bool Remarks = true;
        public bool Fax = true;

        public SearchFields()
        {
            LoadData();
        }

        public void LoadData()
        {
            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    dt = SQLHelper.Select(cmd, "select * from searchfield where id = 1;");

                    conn.Close();
                }
            }

            Name = DataParse.BoolParse(dt.Rows[0]["name"]);
            Tel = DataParse.BoolParse(dt.Rows[0]["tel"]);
            HomeTel = DataParse.BoolParse(dt.Rows[0]["hometel"]);
            MobileTel = DataParse.BoolParse(dt.Rows[0]["mobiletel"]);
            WorkTel = DataParse.BoolParse(dt.Rows[0]["worktel"]);
            Email = DataParse.BoolParse(dt.Rows[0]["email"]);
            Fax = DataParse.BoolParse(dt.Rows[0]["fax"]);
            Address = DataParse.BoolParse(dt.Rows[0]["address"]);
            Remarks = DataParse.BoolParse(dt.Rows[0]["remarks"]);

            dt = null;
        }
    }
}
