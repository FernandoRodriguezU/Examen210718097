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



namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss= new ClienteBss();
        public void button1_Click(object sender, EventArgs e)
        {
            Cliente C = new Cliente();
            C.TipoCliente = textBox1.Text;
            C.CodigoCliente = textBox2.Text;
            C.IdCliente = Convert.ToInt32(textBox3.Text);
            bss.InsertarClienteBss(C);
            MessageBox.Show("El cliente se guardo correctamente");
        }
    }
}
