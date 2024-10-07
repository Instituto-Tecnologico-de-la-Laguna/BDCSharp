using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDCSharp
{
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void ActualizaGrid()
        {
            Datos datos = new Datos();
            DataSet ds = new DataSet();

            ds = datos.informacion("Select idCarrera as [No. Carrrera],Carrera,Clave From Carreras");
            if (ds != null)
            {
                dgvCarreras.DataSource = ds.Tables[0];
            }
            else { MessageBox.Show("Error"); }
        }
        private void frmCarreras_Load(object sender, EventArgs e)
        {
            ActualizaGrid();
        }
        private void dgvCarreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool b = false;
            if (e.ColumnIndex == 0)
            {
                //MessageBox.Show(dgvCarreras[1,e.RowIndex].Value .ToString());
                Form1 actualiza= new Form1(dgvCarreras[2,e.RowIndex].Value .ToString(),
                    dgvCarreras[3, e.RowIndex].Value.ToString(), 
                    dgvCarreras[1,e.RowIndex].Value.ToString());
                actualiza.Show();
            }
        }
        private void frmCarreras_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }
    }
}
