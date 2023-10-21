using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortugalProductos
{
    public partial class Gestion_Productos : Form
    {
        List<Lista> MiList = new List<Lista>();

        public Gestion_Productos(string user)
        {
            InitializeComponent();

            lblEnLinea.Text = user; //Muestro el usuario logeado

        }

        private void Gestion_Productos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Result;
            Result = MessageBox.Show("¿Desea cerrar sesión?", "", MessageBoxButtons.OKCancel);
            if (Result == DialogResult.OK)
            {
                Form1 inicio = new Form1();
                inicio.Show();
                this.Close();
            }
            else 
            {
                return;
            }
            
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            //Instancio el objeto Lista
            Lista producto = new Lista();
            producto.codigo = int.Parse(txtCodigo.Text);
            producto.descrip = txtDesc.Text;
            producto.precio = double.Parse(txtPrecio.Text);
            producto.costo = double.Parse(txtCosto.Text);
            producto.stock = int.Parse(txtStock.Text);
            producto.proveedor = txtProvee.Text;

            MiList.Add(producto);

            //Muestro en tabla datagrid
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = MiList;
        }
        
        
        
        //Botón de Baja de producto mediante el número de código
        private void btnBaja_Click(object sender, EventArgs e)
        {

        }
    }
}
