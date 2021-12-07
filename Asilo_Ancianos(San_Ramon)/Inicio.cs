using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asilo_Ancianos_San_Ramon_
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            ButtonAcceder.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (textUsuario.Text == "Usuario")
            {
                textUsuario.Text = "";
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Text=="")
            {
                textUsuario.Text = "Usuario";

            }

        }

        private void textContraseña_Enter(object sender, EventArgs e)
        {
            if (textContraseña.Text == "Contraseña")
            {
                textContraseña.Text = "";
                textContraseña.UseSystemPasswordChar = true;
            }
        }

        private void textContraseña_Leave(object sender, EventArgs e)
        {
            if (textContraseña.Text == "")
            {
                textContraseña.Text = "Contraseña";
                textContraseña.UseSystemPasswordChar = false;
            }
        }

        private void rectangleShape3_Click(object sender, EventArgs e)
        {

        }

        private void controlBotones()
        {
            if (textUsuario.Text.Trim() != "Usuario" && textContraseña.Text.Trim() != "Contraseña") {
                ButtonAcceder.Enabled = true;
                errorProvider1.SetError(textUsuario,"");
                errorProvider1.SetError(textContraseña, "");
            } else if(textUsuario.Text.Trim() == "Usuario")
            { 
                errorProvider1.SetError(textUsuario, "El usuario NO puede quedar en blanco");
                ButtonAcceder.Enabled = false;
            } else if (textContraseña.Text.Trim() != "Contraseña")
            {
                errorProvider1.SetError(textContraseña, "La contraseña NO puede quedar en blanco");
                ButtonAcceder.Enabled = false;
            }
            else { errorProvider1.SetError(textUsuario, "El usuario NO puede quedar en blanco");
                   errorProvider1.SetError(textContraseña, "La contraseña NO puede quedar en blanco");
                    ButtonAcceder.Enabled = false;
            }
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonAcceder_Click(object sender, EventArgs e)
        {

        }

        private void linkCrearNuevoUsuario_Click(object sender, EventArgs e)
        {
            using (CrearUsuario ventanaCrearUsuario = new CrearUsuario())
                ventanaCrearUsuario.ShowDialog();
     

        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
    }
}
