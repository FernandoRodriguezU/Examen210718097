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
using SistemasVentas.BSS;

namespace SistemasVentas.VISTA.PersonaVistas
{
    public partial class PersonaInsertarVista : Form
    {
        public PersonaInsertarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;
            p.Telefono = textBox3.Text;
            p.Ci = textBox4.Text;
            p.Correo = textBox5.Text;
            bss.InsertarPersonaBss(p);
            MessageBox.Show("Se guardo correctamente la persona");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVIsta fr = new PersonaListarVIsta();
        }
    }
}
