using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;


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

        public OleDbConnection ObtenerConexion()
        {
            return conn;
        }

        public DataTable CargarPersonajes()
        {
            DataTable dt = new DataTable();

            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = "Personaje";

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar personajes: " + ex.Message);
            }

            return dt;
        }
    }
}
