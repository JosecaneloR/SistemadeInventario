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
    public partial class Form1 : Form
    {
        Negocio con = new Negocio();        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuario.Text == "" | usuario.Text == " " | usuario.Text == "  ")
            {
                MessageBox.Show("El campo Nombre de Usuario está vacío");
            }
            else if (contrasena.Text == "" | contrasena.Text == " " | contrasena.Text == "  ")
            {
                MessageBox.Show("El campo Contraseña está vacío");
            }
            else
            {
                if (con.ConexionSQL(usuario.Text, contrasena.Text) == 1 || con.ConexionSQL(usuario.Text, contrasena.Text) == 2)
                {
                    this.Hide();
                    Inventario inventario = new Inventario();
                    inventario.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                }
            }
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
            iniciarSesion.BackColor = SystemColors.Control;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            iniciarSesion.BackColor = Color.White;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
