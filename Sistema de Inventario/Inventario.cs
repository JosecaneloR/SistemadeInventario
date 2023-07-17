using CapadeSoporte.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapadeNegocio;

namespace Sistema_de_Inventario
{
    public partial class Inventario : Form
    {
        Negocio con = new Negocio();
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            if (CacheUsuario.rol == Roles.Estandar)
            {
                button3.Enabled = false;
                button3.BackColor = Color.Gray; button3.ForeColor = Color.White;
                button4.Enabled = false;
                button4.BackColor = Color.Gray; button4.ForeColor = Color.White;
                button6.Enabled = false;
                button6.BackColor = Color.Gray; button6.ForeColor = Color.White;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Nuevo_producto nuevo_Producto = new Nuevo_producto();
            nuevo_Producto.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 login = new Form1();
            login.Show();
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            botonCerrarSesion.BackColor = SystemColors.Control;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor= SystemColors.Control;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button6_MouseEnter_1(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void botonCerrarSesion_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void botonCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
