using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Inicio form1 = new Inicio();
            form1.ShowDialog();

            txt_documento.Text = "";
            txt_contrasena.Text = "";

        }

    }
}
