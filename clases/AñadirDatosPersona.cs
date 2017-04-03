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
    public partial class AñadirDatosPersona : Form
    {
        public AñadirDatosPersona()
        {
            InitializeComponent();
        }
        Page p;

        private void button1_Click(object sender, EventArgs e)
        {
            AñadirPaginaDatos apd = new AñadirPaginaDatos();
            apd.ShowDialog();

            p = apd.p;
            txtPage.Text = apd.p.ToString();

            //apd.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {

            DatosPersona dp = new DatosPersona(txtUser.Text, txtPassUser.Text);
            dp.pages.Add(p);

            setDatosFirebase(dp);
        }


        private async void setDatosFirebase(DatosPersona dp)
        {
            conexionFireBase.dp = dp;
            await conexionFireBase.setDatosFB();
            dp = conexionFireBase.dp;
        }
    }
}
