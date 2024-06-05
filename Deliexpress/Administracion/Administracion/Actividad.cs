using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion
{
    public partial class Actividad : Form
    {
        string Nombre_usuario;
        string Password_Usu;
        public Actividad(string NombreUsu, string Password)
        {
            InitializeComponent();
            Nombre_usuario = NombreUsu;
            Password_Usu = Password;
        }

        private void Actividad_Load(object sender, EventArgs e)
        {

        }
    }
}
