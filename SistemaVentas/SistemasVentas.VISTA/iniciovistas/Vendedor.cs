using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.inicio
{
    public partial class Vendedor : Form
    {
        public Vendedor()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();
        private void Vendedor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuarioBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
