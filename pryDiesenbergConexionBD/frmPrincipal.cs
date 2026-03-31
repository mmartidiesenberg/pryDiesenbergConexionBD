using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenbergConexionBD
{
    public partial class frmPrincipal : Form
    {
        private ClassConexionBD objConectarBD = new ClassConexionBD();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                objConectarBD.ConectarBD();
                lblEstadoConexion1.Text = "Base Conectada";
                lblEstadoConexion1.BackColor = Color.Green;

                CargarDatos();
            }
            catch (Exception ex)
            {
                lblEstadoConexion.Text = "Sin Conexión";
                lblEstadoConexion.BackColor = Color.Red;
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarDatos()
        {
            try
            {
                string sql = "SELECT * FROM Personaje";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(sql, objConectarBD.ObtenerConexion()))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDatos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

