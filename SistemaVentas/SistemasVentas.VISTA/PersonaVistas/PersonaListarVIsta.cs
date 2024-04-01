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
using SistemasVentas.VISTA.UsuarioVistas;

namespace SistemasVentas.VISTA.PersonaVistas
{
    public partial class PersonaListarVIsta : Form
    {
        public PersonaListarVIsta()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();

        private void PersonaListarVIsta_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPersonaBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioInsertarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonaInsertarVista fr = new PersonaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPersonaBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PersonaEditarVista fr = new PersonaEditarVista(IdPersonaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPersonaBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar esta persona", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarPersonBss(IdPersonaSeleccionada);
                dataGridView1.DataSource = bss.ListarPersonaBss();
            }
        }
    }
}
