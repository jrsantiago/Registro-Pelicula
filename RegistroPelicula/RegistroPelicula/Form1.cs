using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegistroPelicula
{
    public partial class RegistroPelicula : Form
    {
        public RegistroPelicula()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nuevo nuevo = new Nuevo();
            nuevo.Show();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
         
            SqlConnection con = new SqlConnection(@"Data Source=JR\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Movie where id= '"+ idtextBox.Text + "'", con);

            try
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                descripciontextBox.Text = dt.Rows[0][1].ToString();
                label4.Text = dt.Rows[0][2].ToString();
             
            }
            catch (IndexOutOfRangeException) { MessageBox.Show("ID no Existente"); }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eliminar delete = new Eliminar();
            delete.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guardar safe = new Guardar();
            safe.Show();
        }
    }
}
