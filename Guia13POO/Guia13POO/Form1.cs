using Guia13POO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia13POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Controlador chino = new Controlador();
        private void button1_Click(object sender, EventArgs e)
        {
            FormDatos nacho = new FormDatos();
            int cp = 0;
            double peso = 0;
            int emp = 0;
            bool escert = false;
            while(nacho.ShowDialog() == DialogResult.OK)
            {
                cp = Convert.ToInt32(nacho.tbCP.Text);
                peso = Convert.ToInt32(nacho.tbPeso.Text);
                emp = Convert.ToInt32(nacho.cbNumero.Text);
                escert = nacho.chbCertificada.Checked;
                chino.Despachar(cp, peso, emp, escert);
            }
            nacho.Dispose();

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FormResultado nacho = new FormResultado();
        }
    }
}
