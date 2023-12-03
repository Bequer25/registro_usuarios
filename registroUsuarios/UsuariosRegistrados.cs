using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static registroUsuarios.conetionBD;

namespace registroUsuarios
{
    public partial class UsuariosRegistrados : Form
    {
        private readonly List<Control> controlesMostrados = new List<Control>();
        public UsuariosRegistrados()
        {
            InitializeComponent();
        }
        private void MostrarUsuariosDesdeBD(FlowLayoutPanel contenedor)
        {
            try
            {
                // Obtén la conexión a la base de datos utilizando el Singleton
                using (MySqlConnection conexion = DatabaseConnection.Instance.GetConnection())
                {
                    //conexion.Open();

                    // Definir la consulta SQL para obtener usuarios
                    string consulta = "SELECT NOMBRES, APELLIDO_P, APELLIDO_M, CORREO FROM usuarios";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            // Iterar a través de los resultados y crear controles para mostrar los usuarios
                            while (reader.Read())
                            {
                                string nombres = reader["NOMBRES"].ToString();
                                string apellidoP = reader["APELLIDO_P"].ToString();
                                string apellidoM = reader["APELLIDO_M"].ToString();
                                string correo = reader["CORREO"].ToString();

                                InformacionUsuario btn = new InformacionUsuario();
                                btn.Nombres = nombres;
                                btn.ApellidoPa = apellidoP;
                                btn.ApellidoMa = apellidoM;
                                btn.Correo = correo;

                                contenedor.Controls.Add(btn);
                             
                            }
                        }
                    }
                    conexion.Close();
                    conexion.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener usuarios desde la base de datos: " + ex.Message);
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (controlesMostrados.Count == 0)
            {

                MostrarUsuariosDesdeBD(flowLayoutPanel1);
            }
        }
    }
}
