using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clases
{
    public partial class AñadirPaginaDatos : Form
    {
        public Page p;

        public AñadirPaginaDatos()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
             p = new Page(txtPapp.Text, txtUser.Text, txtPass.Text, txtCorreo.Text, txtOtro.Text);
            this.Close();
        }
    }
}
