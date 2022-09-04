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
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            TextWriter Escribir = new StreamWriter("./cultivos.txt", true);

            Escribir.WriteLine(Convert.ToString (txtCultivos.Text));
            Escribir.Close();

            MessageBox.Show("El cultivo se guardo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            txtCultivos.Text = "";
            txtCultivos.Focus();
        }

        private void frmCultivos_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("./Localidad.txt");
            while (!streamReader.EndOfStream)
            {
               cboCultivos.Items.Add(streamReader.ReadLine().ToString());
            }

            streamReader.Close();
        }
    }
}
