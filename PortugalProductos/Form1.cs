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
    
    public partial class Form1 : Form
    {
        //Declaro variables del LOGIN

        string user = "CristianoRonaldo";
        string pass = "pass123";
       
        public Form1()

        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = user;
            txtPass.Text = pass;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text== user)
            {
                if(txtPass.Text== pass)
                {
                    Gestion_Productos loginGestion = new Gestion_Productos(user);
                    loginGestion.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                    txtPass.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
                txtUsuario.Text = "";
            }
        }
        //Boton para cerrar
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Result;
            Result = MessageBox.Show("¿Desea salir de la aplicación?", "", MessageBoxButtons.OKCancel);
            if (Result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
            
        }
    }
    

}
