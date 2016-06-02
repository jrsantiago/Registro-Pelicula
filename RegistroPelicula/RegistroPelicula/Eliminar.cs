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
    public partial class Eliminar : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=JR\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True");
        SqlCommand command = new SqlCommand();


        public Eliminar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            command.Connection = con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

               if (EliminartextBox.Text != "")
                {

                  con.Open();
                  command.CommandText = "DELETE FROM Movie WHERE id='" + EliminartextBox.Text + "'";
                  command.ExecuteNonQuery();
                  con.Close();
                
                  MessageBox.Show("Pelicula Eliminada");
                  EliminartextBox.Text = "";
                 }

            }
            catch (IndexOutOfRangeException) { MessageBox.Show("iD No Existente"); }
          
        }
    }
}
