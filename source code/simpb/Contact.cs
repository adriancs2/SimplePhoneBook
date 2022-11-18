using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace SimPB
{
    class Contact
    {
        public int Id = 0;
        public string Name = "";
        public string Tel = "";
        public string HomeTel = "";
        public string MobileTel = "";
        public string WorkTel = "";
        public string Email = "";
        public string Fax = "";
        public string Address = "";
        public string Remarks = "";

        public Contact()
        { }

        public Contact(SQLiteCommand cmd, int id)
        {
            DataTable dt = SQLHelper.Select(cmd, "select * from phonebook where id = " + id);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                Id = DataParse.IntParse(dr["id"]);
                Name = dr["name"] + "";
                Tel = dr["tel"] + "";
                HomeTel = dr["hometel"] + "";
                MobileTel = dr["mobiletel"] + "";
                WorkTel = dr["worktel"] + "";
                Email = dr["email"] + "";
                Fax = dr["fax"] + "";
                Address = dr["address"] + "";
                Remarks = dr["remarks"] + "";
            }
        }
    }
}
