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
    public partial class CrearUsuario : Form
    {
        string[] tipoPers = {"Personal Salud","Personal Tecnico","Director"};
        string[] personasSalud = {"Enfermero", "Psicologo", "Nutricionista", "Medico interno"};
        string[] personasTecnico = { "Coordinador", "Cuidador", "Trabajador Social" };
        string tipoUs;
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void VerifDatos()
        {
            if (UtextNombre.Text == "Nombres" || UtextApellido.Text == "Apellidos" || UtextUsuario.Text=="Usuario" || UtextCorreo.Text=="Correo" || UtextCel.Text=="Nro Celular" || UtextCi.Text=="Nro de Carnet")
            {
                UbuttonCrearUsuario.Enabled = false;
                errorProvider1.SetError(panelSesion, "Complete todos los datos correspondientes");
            }
            else if (UtextNombre.Text != "Nombres" && UtextApellido.Text != "Apellidos" && UtextUsuario.Text != "Usuario" && UtextCorreo.Text != "Correo" && UtextCel.Text != "Nro Celular" && UtextCi.Text != "Nro de Carnet")
            {
                errorProvider1.SetError(panelSesion, "");
                UbuttonCrearUsuario.Enabled = true;
            }
        }
        private void rectangleShape3_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            UbuttonCrearUsuario.Enabled = false;
            USelectorSexo.Items.Add("Hombre");
            USelectorSexo.Items.Add("Mujer");

            USelectorTurno.Items.Add("Mañana");
            USelectorTurno.Items.Add("Tarde");
            USelectorTurno.Items.Add("Noche");

            USelectorTipo_Contrato.Items.Add("Contrato Regular");
            USelectorTipo_Contrato.Items.Add("Contrato por item");
            USelectorTipo_Contrato.Items.Add("Voluntario");
            USelectorTipo_Contrato.Items.Add("Designado");

            foreach (string item in tipoPers)
            {
                SelectorTipoPersona.Items.Add(item);
            }
            SelectorPersona.Visible = false;
            selectorPersonaFondo.Visible = false;
            panelSesion.Visible = false;
            labelSelecTipoPers.Visible = false;
        }

        private void addUsuario()
        {


        }

        private void SelectorTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tipoUs = SelectorTipoPersona.Text;
            UlabelTurno.Visible = true;
            UrectangleShapeSalario.Visible = true;
            UlabelTurno.Visible = true;
            UtextSalario.Visible = true;
            USelectorTurno.Visible = true;
            UlabelReLab.Visible = true;
            USelectorTipo_Contrato.Visible = true;
            USelectorTipo_Contrato.Enabled = true;
            labelSelecTipoPers.Visible = false;
            SelectorPersona.Visible = false;
            selectorPersonaFondo.Visible = false;
            SelectorPersona.Items.Clear();
            SelectorPersona.Text = "";
            string str = SelectorTipoPersona.Text.Trim();

            // passing string "str" in 
            // switch statement
            switch (str)
            {

                case "Personal Salud":
                    panelSesion.Visible = false;
                    pictureBoxImagIzq.Image = Properties.Resources.Botiquin;
                    SelectorPersona.Visible = true;
                    selectorPersonaFondo.Visible = true;
                    labelSelecTipoPers.Visible = true;
                    foreach (string item in personasSalud)
                    {
                        SelectorPersona.Items.Add(item);
                    }
                    break;

                case "Personal Tecnico":
                    panelSesion.Visible = false;
                    pictureBoxImagIzq.Image = Properties.Resources.Maletin;
                    SelectorPersona.Visible = true;
                    selectorPersonaFondo.Visible = true;
                    labelSelecTipoPers.Visible = true;
                    foreach (string item in personasTecnico)
                    {
                        SelectorPersona.Items.Add(item);
                    }
                    break;

                case "Director":
                    UlabelTurno.Visible = false;
                    USelectorTurno.Visible = false;
                    USelectorTipo_Contrato.SelectedItem = "Designado";
                    USelectorTipo_Contrato.Enabled = false;
                    panelSesion.Visible = true;
                    UrectangleShapeEspec.Visible = false;
                    UtextEspecialidad.Visible = false;
                    pictureBoxImagIzq.Image = Properties.Resources.Director;
                    break;

                default:
                    pictureBoxImagIzq.Image = Properties.Resources.question;
                    break;
            }
        }

        private void SelectorPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrectangleShapeEspec.Visible = true;
            UtextEspecialidad.Visible = true;
            panelSesion.Visible = true;
            string str = SelectorPersona.Text.Trim();
            this.tipoUs= SelectorPersona.Text;
            // passing string "str" in 
            // switch statement
            switch (str)
            {
                case "Medico interno":
                    pictureBoxImagIzq.Image = Properties.Resources.doctor;
                    break;
                case "Enfermero":
                    pictureBoxImagIzq.Image = Properties.Resources.nurse;
                    break;

                case "Psicologo":
                    pictureBoxImagIzq.Image = Properties.Resources.psychologist;
                    break;

                case "Nutricionista":
                    pictureBoxImagIzq.Image = Properties.Resources.nutritionist;
                    break;

                case "Coordinador":
                    pictureBoxImagIzq.Image = Properties.Resources.coordinator;
                    break;

                case "Cuidador":
                    pictureBoxImagIzq.Image = Properties.Resources.carer;
                    break;

                case "Trabajador Social":
                    pictureBoxImagIzq.Image = Properties.Resources.socialWorker;
                    break;

                default:
                    pictureBoxImagIzq.Image = Properties.Resources.question;
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            VerifDatos();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            VerifDatos();
        }

        private void UtextCorreo_TextChanged(object sender, EventArgs e)
        {
            VerifDatos();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            VerifDatos();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void UtextApellido_Enter(object sender, EventArgs e)
        {

        }

        private void UtextNombre_Enter(object sender, EventArgs e)
        {
            if (UtextNombre.Text == "Nombres")
            {
                UtextNombre.Text = "";
            }
        }

        private void rectangleShape10_Enter(object sender, EventArgs e)
        {

        }

        private void UtextApellido_Enter_1(object sender, EventArgs e)
        {
            if (UtextApellido.Text == "Apellidos")
            {
                UtextApellido.Text = "";
            }
        }

        private void UtextUsuario_Enter(object sender, EventArgs e)
        {
            if (UtextUsuario.Text == "Usuario")
            {
                UtextUsuario.Text = "";
            }
        }

        private void UtextCorreo_Enter(object sender, EventArgs e)
        {
            if (UtextCorreo.Text == "Correo")
            {
                UtextCorreo.Text = "";
            }
        }

        private void UtextCel_Enter(object sender, EventArgs e)
        {
            if (UtextCel.Text == "Nro Celular")
            {
                UtextCel.Text = "";
            }
        }

        private void UtextNombre_Leave(object sender, EventArgs e)
        {
            if (UtextNombre.Text == "")
            {
                UtextNombre.Text = "Nombres";
            }
        }

        private void UtextApellido_Leave(object sender, EventArgs e)
        {
            if (UtextApellido.Text == "")
            {
                UtextApellido.Text = "Apellidos";
            }
        }

        private void UtextUsuario_Leave(object sender, EventArgs e)
        {
            if (UtextUsuario.Text == "")
            {
                UtextUsuario.Text = "Usuario";
            }
        }

        private void UtextCorreo_Leave(object sender, EventArgs e)
        {
            if (UtextCorreo.Text == "")
            {
                UtextCorreo.Text = "Correo";
            }
        }

        private void UtextCel_Leave(object sender, EventArgs e)
        {
            if (UtextCel.Text == "")
            {
                UtextCel.Text = "Nro Celular";
            }
        }
        private void UtextEspecialidad_Enter(object sender, EventArgs e)
        {
            if (UtextEspecialidad.Text == "Especialidad")
            {
                UtextEspecialidad.Text = "";
            }
        }

        private void UtextEspecialidad_Leave(object sender, EventArgs e)
        {
            if (UtextEspecialidad.Text == "")
            {
                UtextEspecialidad.Text = "Especialidad";
            }
        }
        private void UtextSalario_Enter(object sender, EventArgs e)
        {
            if (UtextSalario.Text == "Salario (Bs)")
            {
                UtextSalario.Text = "";
            }
        }

        private void UtextSalario_Leave(object sender, EventArgs e)
        {
            if (UtextSalario.Text == "")
            {
                UtextSalario.Text = "Salario (Bs)";
            }
        }
        private void seleccionarSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UtextCi_Enter(object sender, EventArgs e)
        {
            if (UtextCi.Text == "Nro de Carnet")
            {
                UtextCi.Text = "";
            }
        }

        private void UtextCi_Leave(object sender, EventArgs e)
        {
            if (UtextCi.Text == "")
            {
                UtextCi.Text = "Nro de Carnet";
            }
        }

        private void UtextEspecialidad_TextChanged(object sender, EventArgs e)
        {
            VerifDatos();

        }

        private void ButtonCrearUsuario_Click(object sender, EventArgs e)
        {
            DialogResult d= MessageBox.Show("USUARIO AÑADIDO CON EXITO!!!\nDesea seguir añadiendo usuarios?","Advertencia",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (d == DialogResult.Yes) {
                
                using (CrearUsuario ventanaCrearUsuario = new CrearUsuario())
                    ventanaCrearUsuario.ShowDialog();
                this.Close();

            }
            
            Console.WriteLine(tipoUs);
            switch (tipoUs)
                
            {
                case "Director":

                    break;

                case "Enfermero": 

                    break;

                case "Psicologo":
                    
                    break;

                case "Nutricionista":
                    
                    break;

                case "Medico interno":

                    break;

                case "Coordinador":
                    
                    break;

                case "Cuidador":
                    
                    break;

                case "Trabajador Social":
                    
                    break;

                default:
                    
                    break;
            }
        }

        private void UtextApellido_TextChanged(object sender, EventArgs e)
        {
            VerifDatos();
        }

        private void UtextCi_TextChanged(object sender, EventArgs e)
        {
            VerifDatos();
        }

        private void UbuttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}


//REPOSITORIOS
/*
                case "Anciano":
                    UrectangleShapeSalario.Visible = false;
UlabelTurno.Visible = false;
UtextSalario.Visible = false;
USelectorTurno.Visible = false;
panelSesion.Visible = true;
USelectorTipo_Contrato.Visible = false;
UlabelReLab.Visible = false;
UrectangleShapeEspec.Visible = false;
UtextEspecialidad.Visible = false;
pictureBoxImagIzq.Image = Properties.Resources.Anciano;
break;*/