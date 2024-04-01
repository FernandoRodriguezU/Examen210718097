using SistemasVentas.BSS;
using SistemasVentas.VISTA.PersonaVistas;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioInsertarVista : Form
    {
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        UsuarioBss bss = new UsuarioBss();
        PersonaBss Bss = new PersonaBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.IdPersona = IdPersonaSeleccionada;
            u.NombreUser = textBox2.Text;
            u.Contraseña = textBox3.Text;
            u.FechaReg = dateTimePicker1.Value;

            bss.InsertarUsuarioBss(u);
            MessageBox.Show("Se guardo correctamente El Usuario");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVIsta fr = new PersonaListarVIsta();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona p = Bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = p.Nombre + " " + p.Apellido;
            }
        }
        UsuarioBss bssuser = new UsuarioBss();

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.IdPersona = IdPersonaSeleccionada;
            usuario.NombreUser = textBox2.Text;
            usuario.Contraseña = textBox3.Text;
            usuario.FechaReg = dateTimePicker1.Value;
            bssuser.InsertarUsuarioBss(usuario);
            MessageBox.Show("Usuario registrado");


        }
    }
}
