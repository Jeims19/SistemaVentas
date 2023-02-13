﻿using System;
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
            Usuario ousuario = new CN_Usuario().Listar().
                Where(u => u.Documento == txt_documento.Text //uso de expresiones lambda// ayuda a automatizar la busqueda de un usuario en nuestra lista
                && u.Clave == txt_contrasena.Text).FirstOrDefault(); //que nos traiga el primero

            
            Inicio form1 = new Inicio();
            form1.ShowDialog();

            txt_documento.Text = "";
            txt_contrasena.Text = "";

        }

    }
}
