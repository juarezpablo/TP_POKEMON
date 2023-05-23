using Datos;
using Datos.Models;
using System.Runtime.InteropServices.ObjectiveC;

namespace TP_POKEMON_FORM
{
    public partial class Form_principal : Form
    {
        Login_Form formularioLogin;
        List<Usuario> usuarios;
        Form_Lista_Pokemon formularioListaPokemon;
        List<Pokemon> ListaPokemones;
        Form_Batalla formularioBatalla;
        public Form_principal(List<Usuario> usuarios)
        {

            InitializeComponent();
            formularioLogin = new Login_Form();
            formularioLogin.MdiParent = this;
            this.usuarios = usuarios;

            ListaPokemones = new List<Pokemon>();
            ListaPokemones = DatosPokemon.CrearListaPokemon();
            //  if (DatosUsuarios.IsLogin())
            //{
            //     MessageBox.Show("estoylogeado");
            //     loginToolStripMenuItem.Visible = false;
            //      listaPokemonToolStripMenuItem.Visible = true;
            //  }
            formularioListaPokemon = new Form_Lista_Pokemon(ListaPokemones);
            formularioListaPokemon.MdiParent = this;
            //this.usuarioPrincipal = usuarioPrincipal;

            formularioBatalla = new Form_Batalla(ListaPokemones, Form_Lista_Pokemon.ListaPokemonesUsers);
            formularioBatalla.MdiParent = this;

        }

        private void Form_Principa_Load(object sender, EventArgs e)
        {





        }


        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioLogin.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listaPokemonToolStripMenuItem.Visible = true;
        }

        private void listaPokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioListaPokemon.WindowState = FormWindowState.Maximized;
            formularioListaPokemon.Show();
        }

        private void dueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioBatalla.WindowState = FormWindowState.Maximized;
            formularioBatalla.Show();
        }
    }
}