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

    public partial class Guardar : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=JR\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        public Guardar()
        {
            InitializeComponent();
        }

        private void Guardar_Load(object sender, EventArgs e)
        {
            command.Connection=con;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (idtextBox.Text != "" && descripciontextBox.Text != "")
                {
                    con.Open();
                    command.CommandText="UPDATE Movie SET descripcion='"+descripciontextBox.Text+"' WHERE id='"+idtextBox.Text+"'";
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Actualizacion Realizada");

                }
            }
            catch (IndexOutOfRangeException) { MessageBox.Show("Digite el codigo y La descripcion a Cambiar"); }
        }
    }
}
