using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioactual;
        private static  IconMenuItem itemactivo=null;
        private static  Form formularioactivo=null;

        public Inicio(Usuario objUsuario) //se mando el usuario como parametro
        {
            usuarioactual=objUsuario; //capturar el usuario
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e) //hacer doble click en encabezado de inicio
        {
            lbl_usuario.Text = usuarioactual.NombreCompleto; //mostar el usuario conectado
        }

        private void AbrirFormulario(IconMenuItem item, Form formulario)
        {
           
            if (itemactivo != null)
            {
                itemactivo.BackColor = Color.White; //si ya hay otro icono activo, lo vuelve blanco
            }
            item.BackColor = Color.Silver;
            itemactivo = item;

            if (formularioactivo != null)
            {
                formularioactivo.Close();
            }
            formularioactivo = formulario;
            formulario.TopLevel = false;  //no sea superior
            formulario.FormBorderStyle= FormBorderStyle.None; //no tenga bordes
            formulario.Dock = DockStyle.Fill; //pueda rellenar todo el espacion posible
            formulario.BackColor= Color.SteelBlue;

            contenedor_principal.Controls.Add(formulario); //contener al formulario en el contenedor
            formulario.Show();
            

        }
        private void menu_usuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frm_usuario());
        }
    
        private void iconMenuItem4_Click(object sender, EventArgs e){} private void menuSuperior_ItemClicked(object sender, ToolStripItemClickedEventArgs e){}

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            //continuar con poner gris los botones y mostrar los formularios respectivos
        }
    }

     
}
