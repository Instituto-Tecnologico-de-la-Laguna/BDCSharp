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

        private void frmCarreras_Load(object sender, EventArgs e)
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
    }
}
