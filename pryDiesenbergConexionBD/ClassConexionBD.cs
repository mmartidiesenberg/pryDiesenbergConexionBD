using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.OleDb;
using System.Windows.Forms;


namespace pryDiesenbergConexionBD
{
    internal class ClassConexionBD
    {
        OleDbConnection conn;
        
        public void ConectarBD()
        {
            conn = new OleDbConnection();

            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\..\\..\\BaseDatos\\baseJuegoRPG.accdb";

            conn.Open();

        }


    }
}
