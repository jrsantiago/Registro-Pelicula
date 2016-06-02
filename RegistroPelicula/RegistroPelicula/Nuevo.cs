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
    public partial class Nuevo : Form
    {
            SqlConnection con = new SqlConnection(@"Data Source=JR\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True");
            SqlCommand command = new SqlCommand();
        
        public Nuevo()
        {
            InitializeComponent();
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {
            command.Connection = con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (descripciontextBox.Text != "" & categoriatextBox.Text != "")
            {
                con.Open();
                command.CommandText = "insert into Movie(descripcion,categoria)values('" + descripciontextBox.Text + "','" + categoriatextBox.Text + "')";
                command.ExecuteNonQuery();
                command.Clone();
                MessageBox.Show("Guardado Con exito");
                con.Close();

            }

        }
    }
}
