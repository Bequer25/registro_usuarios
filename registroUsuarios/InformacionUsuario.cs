using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registroUsuarios
{
    public partial class InformacionUsuario : UserControl
    {
        public InformacionUsuario()
        {
            InitializeComponent();
        }
         private int id = 0;
       // private int comercioId = 0;
        //private string descripcion = "Descripcion del producto";
        private string nombres = "";
        private string apellidoPa = "";
        private string apellidoMa = "";
        private string correo = "";


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombres
        {
            get { return lblNombres.Text; }
            set { lblNombres.Text = value; }
        }

        public string ApellidoPa
        {
            get { return lblApelllidoP.Text; }
            set { lblApelllidoP.Text = value; }
        }

        public string ApellidoMa
        {
            get { return lblApellidoM.Text; }
            set { lblApellidoM.Text = value; }
        }

        public string Correo
        {
            get { return lblCorreo.Text; }
            set { lblCorreo.Text = value; }
        }

       
       
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
