using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Security.Cryptography;
using System.Drawing;
using System.Data.SQLite;

namespace SimPB
{
    class config
    {
        // Last Update: 30 Aug 2013 (v1.3.3)

        public static Icon AppIcon;
        public const string AppVersion = "1.4";
        public static Assembly SQLiteDLL;
        public static string SQLiteFile;
        public static string Conn = "";

        public static int LocationX = 0;
        public static int LocationY = 0;
        public static int Width = 0;
        public static int Heiht = 0;

        public static ContactFields ContactFields;
        public static SearchFields SearchFields;

        public static bool IsNewDatabase = false;

        public static Dictionary<string, string> dicDisplayColNames;

        //public static void LoadSQLiteDLL()
        //{
        //    string tempFolderSQLite = Path.GetTempPath() + "\\System.Data.SQLite.dll";
        //    string currentFolderSQLite = Environment.CurrentDirectory + "\\System.Data.SQLite.dll";

        //    byte[] SQLiteBA = null;

        //    using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SimPB.System.Data.SQLite.dll"))
        //    {
        //        SQLiteBA = new byte[stream.Length];
        //        stream.Read(SQLiteBA, 0, (int)stream.Length);
        //    }

        //    SHA256Managed sha256 = new SHA256Managed();
        //    byte[] hashArray = sha256.ComputeHash(SQLiteBA);

        //    string SQLiteHash = BitConverter.ToString(hashArray);

        //    // Temp Folder
        //    SQLiteFile = tempFolderSQLite;
        //    if (File.Exists(tempFolderSQLite))
        //    {
        //        byte[] ba = File.ReadAllBytes(tempFolderSQLite);
        //        string h = BitConverter.ToString(sha256.ComputeHash(ba));

        //        if (h == SQLiteHash)
        //        {

        //            SQLiteDLL = Assembly.LoadFile(tempFolderSQLite);
        //            return;
        //        }
        //    }

        //    try
        //    {
        //        File.WriteAllBytes(tempFolderSQLite, SQLiteBA);
        //        SQLiteDLL = Assembly.LoadFile(tempFolderSQLite);
        //        return;
        //    }
        //    catch
        //    { }

        //    // Current Folder

        //    SQLiteFile = currentFolderSQLite;

        //    if (File.Exists(currentFolderSQLite))
        //    {
        //        byte[] ba = File.ReadAllBytes(currentFolderSQLite);
        //        string h = BitConverter.ToString(sha256.ComputeHash(ba));

        //        if (h == SQLiteHash)
        //        {

        //            SQLiteDLL = Assembly.LoadFile(currentFolderSQLite);
        //            return;
        //        }
        //    }

        //    try
        //    {
        //        File.WriteAllBytes(currentFolderSQLite, SQLiteBA);
        //        SQLiteDLL = Assembly.LoadFile(currentFolderSQLite);
        //        return;
        //    }
        //    catch
        //    { }

        //    System.Windows.Forms.MessageBox.Show("The current folder doesn't have write permission. Please copy the program to a folder with write permission. This program will exit now.");
        //    Environment.Exit(0);
        //}

        public static void InitializeProgram()
        {
            AppIcon = new Icon(Assembly.GetExecutingAssembly().GetManifestResourceStream("SimPB.AddressBook.ico"));

            //LoadSQLiteDLL();

            string dataFile = Environment.CurrentDirectory + "\\data.simpb";

            if (!System.IO.File.Exists(dataFile))
            {
                IsNewDatabase = true;
            }

            Conn = "Data Source=" + dataFile;

            PrepareDatabase();

            config.ContactFields = new ContactFields();
            config.SearchFields = new SearchFields();

            dicDisplayColNames = new Dictionary<string, string>();
            dicDisplayColNames["name"] = "Name";
            dicDisplayColNames["tel"] = "Tel";
            dicDisplayColNames["hometel"] = "Home Tel";
            dicDisplayColNames["mobiletel"] = "Mobile Tel";
            dicDisplayColNames["worktel"] = "Work Tel";
            dicDisplayColNames["address"] = "Address";
            dicDisplayColNames["email"] = "Email";
            dicDisplayColNames["fax"] = "Fax";
            dicDisplayColNames["remarks"] = "Remarks";
        }

        static void PrepareDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(config.Conn))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = @"create table if not exists `formlayout`
                            (
                            id integer primary key autoincrement,
                            locationx integer,
                            locationy integer,
                            formwidth integer,
                            formheight integer,
                            colnname integer,
                            colntel integer,
                            colnhomeTel integer,
                            colnmobiletel integer,
                            colnworktel integer,
                            colnemail integer,
                            colnfax integer,
                            colnaddress integer,
                            colnremarks integer
                            );";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS `phonebook`
                            (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            name TEXT,
                            tel TEXT,
                            hometel TEXT,
                            mobiletel TEXT,
                            worktel TEXT,
                            email TEXT,
                            fax TEXT,
                            address TEXT,
                            remarks TEXT
                            );";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS `config`
                            (
                            `id` INTEGER PRIMARY KEY AUTOINCREMENT, 
                            `key` TEXT, 
                            `value` TEXT
                            );";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"create table if not exists `usedcontactfield`
                            (
                            `id` integer primary key autoincrement,
                            tel integer,
                            hometel integer,
                            mobiletel integer,
                            worktel integer,
                            email integer,
                            fax integer,
                            address integer,
                            remarks integer
                            );";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"create table if not exists `searchfield`
                            (
                            `id` integer primary key autoincrement,
                            name integer,
                            tel integer,
                            hometel integer,
                            mobiletel integer,
                            worktel integer,
                            email integer,
                            fax integer,
                            address integer,
                            remarks integer
                            )
                            ";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "begin transaction;";
                    cmd.ExecuteNonQuery();

                    int a = SQLHelper.ExecuteScalarInt(cmd, "select count(*) from formlayout where id = 1;");
                    if (a == 0)
                    {
                        cmd.CommandText = "insert into formlayout values(1, 100, 100, 350, 450, 100, 100, 100, 100, 100, 100, 100, 100, 100);";
                        cmd.ExecuteNonQuery();
                    }

                    string b = SQLHelper.ExecuteScalarString(cmd, "select `value` from `config` where `key` = 'appversion';");
                    if (b != config.AppVersion)
                    {
                        cmd.CommandText = "delete from `config` where `key` = 'appversion';";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "insert into `config`(`key`,`value`)values('appversion','" + config.AppVersion + "');";
                        cmd.ExecuteNonQuery();
                    }

                    int c = SQLHelper.ExecuteScalarInt(cmd, "select count(*) from `config` where `key` = 'datecreated';");
                    if (c == 0)
                    {
                        cmd.CommandText = "insert into `config`(`key`,`value`)values('datecreated','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "');";
                        cmd.ExecuteNonQuery();
                    }

                    int d = SQLHelper.ExecuteScalarInt(cmd, "select count(*) from `usedcontactfield` where id = 1;");
                    if (d == 0)
                    {
                        cmd.CommandText = "insert into usedcontactfield values(1,1,1,1,1,1,1,1,1);";
                        cmd.ExecuteNonQuery();
                    }

                    int e = SQLHelper.ExecuteScalarInt(cmd, "select count(*) from searchfield where id = 1;");
                    if (e == 0)
                    {
                        cmd.CommandText = "insert into searchfield values(1,1,1,1,1,1,1,1,1,0);";
                        cmd.ExecuteNonQuery();
                    }

                    cmd.CommandText = "commit;";
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }
    }
}
