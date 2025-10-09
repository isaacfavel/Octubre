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
    public partial class frmAgenda : Form
    {
        int id = 0;
        public frmAgenda()
        {
            InitializeComponent();
            
        }

        public frmAgenda(int id)
        {
            InitializeComponent();
            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM \"Agenda\" WHERE id=" + id);
            txtNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            txtPaterno.Text = ds.Tables[0].Rows[0]["apaterno"].ToString();
            rtbDireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
            mtbTelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
            this.id = id;
            btnAgregar.Text = "Actualizar";
        }

        

       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Datos data = new Datos();
            string query = "INSERT INTO agenda(nombre,apaterno,amaterno," +
                "direccion,telefono)Values('" + txtNombre.Text + "','" +
                txtPaterno.Text + "','" +
                rtbDireccion.Text + "','" + mtbTelefono.Text + "')";
            resultado = data.ExecuteQuery(query);
            if (resultado)
            {
                MessageBox.Show("Registro agregado","Siste",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al agregar el registro","Sistema",
                    MessageBoxButtons.OK ,MessageBoxIcon.Error );
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
