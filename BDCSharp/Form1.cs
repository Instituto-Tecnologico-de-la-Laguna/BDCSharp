using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool f;
            Datos carrera = new Datos();
            f = carrera.ejecutarComando("Insert Into Carrera" +
                "(carrera,clave)" +
                "Values('"+ txtCarrera.Text + "','" + 
                txtClave.Text + "')");
            if (f == true)
                MessageBox.Show("Carrera Agregada");
            else
                MessageBox.Show("Error");
        }
    }
}
