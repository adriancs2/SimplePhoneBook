using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;

namespace SimPB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                //AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

                config.InitializeProgram();

                Application.Run(new frmMain());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        //static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        //{
        //    if (args.Name.Contains("System.Data.SQLite"))
        //    {
        //        //return config.SQLiteDLL;
        //        return Assembly.LoadFile(config.SQLiteFile);
        //    }
        //    return null;
        //}
    }
}
