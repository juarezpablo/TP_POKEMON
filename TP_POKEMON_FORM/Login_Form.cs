using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
namespace TP_POKEMON_FORM
{
    public partial class Login_Form : Form
    {
        
        Form_Lista_Pokemon Formulario_Usuario;
        Form_principal Formulario_Inicio;
        
        public Login_Form()
        {
            InitializeComponent();
            
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string nombreIngresado = textBoxNombre.Text;
            string contraseniaIngresada = textBoxContrasenia.Text;
            if (DatosUsuarios.VerificarUsuario(nombreIngresado, contraseniaIngresada))
            {
                var usuarioLogeado = DatosUsuarios.ObtenerUsuarioLogueado();

                MessageBox.Show("user logueado");
                
                //Formulario_Usuario.Show();
                if (Formulario_Inicio == null)
                {
                    Formulario_Inicio = new Form_principal(DatosUsuarios.LISTA);
                    Formulario_Inicio.Show();
                }
                //  Formulario_Inicio = new Form_principal();


                // Formulario_Inicio.Show();
                
                this.Hide();

            }

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            //var flagInicio = false;
            var direccion = "C:\\Users\\VAIO}\\source\\repos\\TP_POKEMON\\Datos\\usuarios.txt";
            var lista_users = Archivo.DevolverListaDiccUsuarios(direccion);
            DatosUsuarios.CrearListaUsuarios(lista_users);


        }
    }
}
