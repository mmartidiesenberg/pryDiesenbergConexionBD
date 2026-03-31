using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryDiesenbergConexionBD
{
    internal class ClassConexionBD
    {
        OleDbConnection conn;

        public void ConectarBD()
        {
            string relativePath = Path.Combine(Application.StartupPath, "..", "..", "BaseDatos", "baseJuegoRPG.accdb");
            string dbPath = Path.GetFullPath(relativePath);

            if (!File.Exists(dbPath))
            {
                throw new FileNotFoundException("No se encontró la base de datos:", dbPath);
            }

            conn = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};");
            conn.Open();
        }

        public OleDbConnection ObtenerConexion()
        {
            return conn;
        }

        public DataTable CargarPersonajes()
        {
            var dt = new DataTable();

            try
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    ConectarBD();
                }

                using (var cmd = new OleDbCommand("SELECT * FROM Personaje", conn))
                using (var adapter = new OleDbDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar personajes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
    }
}