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
    public partial class Nuevo_producto : Form
    {
        Negocio con = new Negocio();
        public Nuevo_producto()
        {
            InitializeComponent();
        }

        private void Nuevo_producto_Load(object sender, EventArgs e)
        {
            TablaDatos.DataSource = con.consultaCN();
        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            con.insertarProductosCN(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            MessageBox.Show("Producto añadido correctamente");
            TablaDatos.DataSource = con.consultaCN();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Inventario form = new Inventario();
            form.Show();
        }
    }
}
