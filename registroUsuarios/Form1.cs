using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static registroUsuarios.conetionBD;

namespace registroUsuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Registrar()
        {
            try
            {
                // Obtén la conexión a la base de datos utilizando el Singleton
                using (MySqlConnection conexion = DatabaseConnection.Instance.GetConnection())
                {
                    // Abre la conexión
                    //conexion.Open();

                    // Define la consulta SQL para insertar el comercio en la base de datos
                    string consulta = "INSERT INTO usuarios (IDUSUARIO, NOMBRES, APELLIDO_P, APELLIDO_M, CORREO, CONTRASENA)" +
                                      "VALUES ('0',@Nombres, @ApellidoPaterno,@ApellidoMaterno, @Correo, @Password)";

                    // Crea un comando SQL
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {


                        // Agrega los parámetros
                        comando.Parameters.AddWithValue("@Nombres", txtNombres.Text);
                        comando.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                        comando.Parameters.AddWithValue("@ApellidoPaterno", txtAP.Text);
                        comando.Parameters.AddWithValue("@ApellidoMaterno", txtAM.Text);
                        comando.Parameters.AddWithValue("@Password", txtContra.Text);


                        // Ejecuta la consulta
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Usuario insertado correctamente en la base de datos.");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario en la base de datos: " + ex.Message);
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuariosRegistrados obj=new UsuariosRegistrados(); 
            obj.Show();
        }
    }
}
