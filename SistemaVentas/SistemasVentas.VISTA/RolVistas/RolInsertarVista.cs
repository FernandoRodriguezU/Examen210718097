using SistemasVentas.BSS;
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

namespace SistemasVentas.VISTA.RolVistas
{
    public partial class RolInsertarVista : Form
    {
        public RolInsertarVista()
        {
            InitializeComponent();
        }
        RolBss bss = new RolBss();
      

        private void button1_Click(object sender, EventArgs e)
        {
            Rol p= new Rol();
            p.Nombre = textBox1.Text;
            bss.InsertarRolbss(p);
            MessageBox.Show("Se guardo correctamente la persona");

        }
    }
}
