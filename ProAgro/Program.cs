using App_no_database.DBSET;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_no_database
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var setting = ConfigurationManager.ConnectionStrings;
            string Conectionstring = setting["ProAgro"].ConnectionString;
            try
            {
                SqlHelper helper = new SqlHelper(Conectionstring);
                if (helper.IsConection)
                    Application.Run(new Form1());
            }
            catch
            {
                FormConexaoBase conexaoBase = new FormConexaoBase();
                conexaoBase.ShowDialog();
                if (conexaoBase.Conectado)
                {
                    Application.Run(new Form1());
                }
            }
            
            
        }
    }
}