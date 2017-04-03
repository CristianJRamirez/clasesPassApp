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
    public partial class Form1 : Form
    {
        public static List<DatosPersona> personas = null;
        public Form1()
        {
            InitializeComponent();
            this.UseWaitCursor = true;
            button1.Enabled = false;
            getDatosAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1
            
            textBox1.Text = personas.Imprimir();
        }

        public async Task getDatosAsync()
        {


            await conexionFireBase.getJugadoresFB();
            personas = conexionFireBase.personas;
            button1.Enabled = true;
            this.UseWaitCursor = false;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AñadirDatosPersona adp = new AñadirDatosPersona();
            adp.ShowDialog();

        }
    }
}
