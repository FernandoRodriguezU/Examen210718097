using SistemasVentas.DAL;
using SistemasVentas.VISTA.inicio;
using SistemasVentas.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SistemasVentas.VISTA.login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
          
                this.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string usuario = user.Text;
            string contraseña = pass.Text;

            if (conexion.VerificarCredenciales(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                In formulario = new In();
                formulario.Show();

                // Aquí puedes abrir el formulario principal o realizar cualquier otra acción después del inicio de sesión exitoso
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {


        }

    }
}