using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace SimPB
{
    class SQLHelper
    {
        public static DataTable Select(SQLiteCommand cmd, string SQL)
        {
            cmd.CommandText = SQL;
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da = null;
            return dt;
        }

        public static DataTable Select(SQLiteCommand cmd, string table, string col, string value)
        {
            string sql = "select * from `" + table + "` where `" + col + "` = '" + value + "';";
            return Select(cmd, sql);
        }

        public static object ExecuteScalar(SQLiteCommand cmd, string SQL)
        {
            cmd.CommandText = SQL;
            return cmd.ExecuteScalar();
        }

        public static string ExecuteScalarString(SQLiteCommand cmd, string SQL)
        {
            return ExecuteScalar(cmd, SQL) + "";
        }

        public static int ExecuteScalarInt(SQLiteCommand cmd, string SQL)
        {
            int i = 0;
            object ob = ExecuteScalar(cmd, SQL);
            int.TryParse(ob + "", out i);
            return i;
        }

        public static string BuildSelectSql(SQLiteCommand cmd, string table, Dictionary<string, object> dicCondition)
        {
            return "select * from `" + table + "`" + GetConditionString(cmd, table, dicCondition);
        }

        public static string BuildSelectSql(SQLiteCommand cmd, string table, string col, string var)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add(col, var);
            return BuildSelectSql(cmd, table, dic);
        }

        public static string BuildInsertSql(SQLiteCommand cmd, string table, Dictionary<string, object> dic)
        {
            if (dic.Count == 0)
                return "";

            if (table == null || table.Length == 0)
                throw new Exception("Table Name is not define.");

            DataTable dt = GetDataType(cmd, table);

            foreach (DataColumn dc in dt.Columns)
            {
                if (dc.ColumnName == "uuid")
                {
                    if (!dic.ContainsKey("uuid"))
                    {
                        dic["uuid"] = null;
                    }
                }
            }

            string columns = "(";
            string values = "values(";
            string sql = "insert into `" + table + "`";

            foreach (KeyValuePair<string, object> kv in dic)
            {
                if (kv.Key == "uuid" && kv.Value == null)
                {
                    columns += "`uuid`,";
                    values += "uuid(),";
                }
                else
                {
                    columns += "`" + kv.Key + "`,";
                    values += GetMySqlDataString(dt.Columns[kv.Key].DataType, kv.Value + "") + ",";
                }
            }

            columns = columns.Remove(columns.Length - 1, 1);
            columns += ")";
            values = values.Remove(values.Length - 1, 1);
            values += ")";

            return sql + columns + values + ";";
        }

        public static string BuildInsertSql(SQLiteCommand cmd, string table, string col, string var)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add(col, var);
            return BuildInsertSql(cmd, table, dic);
        }

        public static string ConvertInsertToReplace(string sql)
        {
            string newsql = sql.Substring(11);
            return "replace into " + newsql;
        }

        public static string BuildUpdateSql(SQLiteCommand cmd, string table, Dictionary<string, object> dic, Dictionary<string, object> dicCondition)
        {
            if (dic.Count == 0)
                return "";

            StringBuilder sb = new StringBuilder();

            DataTable dt = GetDataType(cmd, table);
            //DataTable dtCond = GetDataType(cmd, table, dicCondition);

            sb.Append("update `" + table + "` set");

            foreach (KeyValuePair<string, object> kv in dic)
            {
                sb.Append(" `" + kv.Key + "` = " + GetMySqlDataString(dt.Columns[kv.Key].DataType, kv.Value+"") + ",");
            }

            sb.Remove(sb.Length - 1, 1);

            sb.Append(GetConditionString(cmd, table, dicCondition));

            sb.Append(";");

            return sb.ToString();
        }

        public static string BuildUpdateSql(SQLiteCommand cmd, string table, Dictionary<string, object> dic, string col, string var)
        {
            var dic2 = new Dictionary<string, object>();
            dic2.Add(col, var);
            return BuildUpdateSql(cmd, table, dic, dic2);
        }

        public static string BuildDeleteSql(SQLiteCommand cmd, string table, Dictionary<string, object> dicCondition)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("delete from `" + table + "` " + GetConditionString(cmd, table, dicCondition));

            return sb.ToString();
        }

        public static string BuildDeleteSql(SQLiteCommand cmd, string table, string col, string var)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add(col, var);
            return BuildDeleteSql(cmd, table, dic);
        }

        public static string GetConditionString(SQLiteCommand cmd, string table, Dictionary<string, object> dic)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" where 1 = 1");

            if (dic == null || dic.Count == 0)
                return sb.ToString();

            DataTable dt = GetDataType(cmd, table);

            foreach (KeyValuePair<string, object> kv in dic)
            {
                sb.Append(" and `" + kv.Key + "` = " + GetMySqlDataString(dt.Columns[kv.Key].DataType, kv.Value+""));
            }

            return sb.ToString();
        }

        static DataTable GetDataType(SQLiteCommand cmd, string table)
        {
            string sql = "select * from `" + table + "` where 1 = 2;";
            DataTable dt = new DataTable();
            cmd.CommandText = sql;
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            da = null;
            return dt;
        }

        public static string GetLikeString(string input)
        {
            string[] sa = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            sb.Append("'");
            foreach (string s in sa)
            {
                sb.Append("%" + Escape(s));
            }
            sb.Append("%'");
            return sb.ToString();
        }

        public static string GetMySqlDataString(object ob, string input)
        {
            if (input == null)
                return "null";

            if (input.Trim().ToLower() == "null")
                return "null";

            string type = ((Type)ob).Name;

            if (type == "String" || type == "DateTime")
                return "'" + Escape(input) + "'";

            if (input.Trim().Length == 0)
                return "0";
            return input;
        }

        public static string Escape(string data)
        {
            return data.Replace("'", "''");
        }
    }
}
