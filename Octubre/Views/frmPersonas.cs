using Octubre.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Octubre.Views
{
    public partial class frmPersonas : Form
    {
        Datos datos = new Datos();
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT id as \"Id\",nombre as \"Nombre\", " +
                            " apaterno as \"A. Paterno\", amaterno as \"A. Materno\"," +
                            "direccion as \"Direccion\", telefono as \"Telefono\" FROM agenda" +
                            " Where Nombre like '" + txtBuscar.Text + "%'");
            if (ds != null)
            {
                dgv.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos.", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            DataSet ds = datos.getAllData("SELECT id as \"Id\",nombre as \"Nombre\", " +
               " apaterno as \"A. Paterno\", amaterno as \"A. Materno\"," +
               "direccion as \"Direccion\", telefono as \"Telefono\" FROM agenda");
            if (ds != null)
            {
                dgv.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos.", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
