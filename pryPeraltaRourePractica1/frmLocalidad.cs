using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryPeraltaRourePractica1
{
    public partial class frmLocalidad : Form
    {
        public frmLocalidad()
        {
            InitializeComponent();
        }

    
    private void frmLocalidad_Load(object sender, EventArgs e)
        {
           // File.Create("./localidad.txt");
        }

        private void btGrabar_Click(object sender, EventArgs e)
        {
            TextWriter Escribir = new StreamWriter("./localidad.txt", true);

            Escribir.WriteLine(Convert.ToString(txtNombre.Text));
            Escribir.Close();


            MessageBox.Show("La localidad se guardo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNombre.Text = "";
            txtNombre.Focus();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {

                btnEliminar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro que desea eliminar el archivo?" + "\nAtencion: Si elimina el archivo todo el contenido se perdera" + "\n¿Aun desea continuar?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (r == DialogResult.OK)
            {
                File.Delete("./localidad.txt");


                MessageBox.Show("Archivo eliminado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (r == DialogResult.Cancel)
            {
                MessageBox.Show("Accion cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}


