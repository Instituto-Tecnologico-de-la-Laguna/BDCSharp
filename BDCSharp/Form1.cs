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
        string id;
        public Form1()
        {
            InitializeComponent();
            btnAgregar.Text = "Agregar";
        }

        public Form1(string carrera,string clave,string id)
        {
            InitializeComponent();
            txtCarrera.Text = carrera;
            txtClave.Text = clave;
            this.id = id;
            btnAgregar.Text = "Actualizar";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool f = false; ;
            Datos carrera = new Datos();
            if (btnAgregar.Text == "Agregar")
            {

                f = carrera.ejecutarComando("Insert Into Carreras" +
                    "(carrera,clave)" +
                    "Values('" + txtCarrera.Text + "','" +
                    txtClave.Text + "')");
            }
            else
            {
                f = carrera.ejecutarComando("Update Carreras Set carrera='"+txtCarrera.Text+
                    "', clave='"+txtClave.Text+"' Where idCarrera="+id);
            }
            if (f == true)
            {
                MessageBox.Show("Carrera Actualizada");
                txtCarrera.Clear();
                txtClave.Clear();
                this.Close();
            }
            else
                MessageBox.Show("Error");
        }
    }
}
