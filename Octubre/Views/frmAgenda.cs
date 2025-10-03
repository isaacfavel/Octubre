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
        public frmAgenda()
        {
            InitializeComponent();
        }

       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado;
            Datos data= new Datos();
            string query = "INSERT INTO agenda(nombre,apaterno,amaterno," +
                "direccion,telefono)Values('" + txtNombre.Text + "','" +
                txtPaterno.Text + "','" + txtMaterno.Text + "','" +
                rtbDireccion.Text + "','" + mtbTelefono.Text + "')";
            resultado=data.ExecuteQuery(query);
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
    }
}
