using CapadeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Inventario
{
    public partial class AgregarUsuario : Form
    {
        Negocio con = new Negocio();
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            TablaUsuarios.DataSource = con.consultaUsuarios();
        }

        private void botonAgregarUsuario_Click(object sender, EventArgs e)
        {
            con.crearUsuarioCN(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.Text);
            TablaUsuarios.DataSource = con.consultaUsuarios();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Inventario form = new Inventario();
            form.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
