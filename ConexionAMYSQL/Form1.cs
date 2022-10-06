using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace ConexionAMYSQL
{
    public partial class Form1 : Form
    {
        private MySqlConnection conexion;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txthost.Text))
            {
                MessageBox.Show("El host es campo es requerido");
                return;
            }
            if (string.IsNullOrEmpty(txtuser.Text))
            {
                MessageBox.Show("El usuario es campo es requerido");
                return;
            }
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("La contraseña es campo es requerido");
                return;
            }

            try
            {
                conexion = new MySqlConnection();
                conexion.ConnectionString =
                    "server=" + txthost.Text + ";"
                    + "user id=" + txtuser.Text + ";"
                    + "password=" + txtpass.Text + ";";
                conexion.Open();
                MessageBox.Show("La conexión se realizo exitosamente");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ups hubo un error en la conexion :c");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
