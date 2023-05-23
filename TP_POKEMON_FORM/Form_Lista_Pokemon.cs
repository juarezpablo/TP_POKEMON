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
using Datos.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace TP_POKEMON_FORM
{
    public partial class Form_Lista_Pokemon : Form
    {
        List<Pokemon> ListaPokemones2;
        List<Pokemon> ListaPokemonesUser;

        public static List<Pokemon> ListaPokemonesUsers;



        public Form_Lista_Pokemon(List<Pokemon> ListaPokemones)
        {
            InitializeComponent();
            ListaPokemones2 = ListaPokemones;
            listBoxPokedex.DataSource = ListaPokemones2;
            comboBoxPokemones.DataSource = ListaPokemones2;
            ListaPokemonesUser = new List<Pokemon>();
            bool user = true;
            ListaPokemonesUser = DatosPokemon.HarcodearListaPokemon(ListaPokemonesUser, user);
            listBox1.DataSource = ListaPokemonesUser;

            ListaPokemonesUsers = ListaPokemonesUser;
        }

        private void Form_Lista_Pokemon_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Lista_Pokemon_Load(object sender, EventArgs e)
        {
            //ListaPokemones = DatosPokemon.CrearListaPokemon();
            //  dataGridListPokemon.DataSource = ListaPokemones2;

        }

        private void listBoxPokedex_Click(object sender, EventArgs e)
        {
            int Indicepokemonseleccionado = listBoxPokedex.SelectedIndex;
            var pokemonSelected = ListaPokemones2[Indicepokemonseleccionado];

            string path_imagen = ListaPokemones2[Indicepokemonseleccionado].path_imagen;

            picBoxPokeSelected.Image = Image.FromFile(path_imagen);
            labelPokeSelected.Text = pokemonSelected.Nombre.ToString();
            labelFuerzaPoke.Text = pokemonSelected.PoderAtaque.ToString();
            labelTipoPoke.Text = pokemonSelected.Tipo.ToString();


        }



        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxPokemones_Click(object sender, EventArgs e)
        {

            var pokemonSelected = ObtenerPokemonDelCombox();

            string path_imagen = pokemonSelected.path_imagen;

            picBoxPokeSelected.Image = Image.FromFile(path_imagen);
            labelPokeSelected.Text = pokemonSelected.Nombre.ToString();
            labelFuerzaPoke.Text = pokemonSelected.PoderAtaque.ToString();
            labelTipoPoke.Text = pokemonSelected.Tipo.ToString();
        }

        private void buttonAgregarPoke_Click(object sender, EventArgs e)
        {
            var pokemonSelec = ObtenerPokemonDelCombox();
            if (pokemonSelec != null && ListaPokemonesUser.Count < 4)
            {
                if (ListaPokemonesUser.Contains(pokemonSelec))
                {
                    MessageBox.Show("Pokemon ya seleccionado");
                }
                else
                {
                    ListaPokemonesUser.Add(pokemonSelec);
                    ActualizarListbox();
                }

            }
            else
            {
                MessageBox.Show("Mochila llena, No entran mas pokemones");
            }

        }

        private void ActualizarListbox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = ListaPokemonesUser;

        }

        private Pokemon ObtenerPokemonDelCombox()
        {
            int Indicepokemonseleccionado = listBoxPokedex.SelectedIndex;
            var pokemonSelected = ListaPokemones2[Indicepokemonseleccionado];
            return pokemonSelected;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            int IndiceMiPokemon = listBox1.SelectedIndex;
            var miPokemon = ListaPokemonesUser[IndiceMiPokemon];
            pictureBoxMiPokemon.Image = Image.FromFile(miPokemon.path_imagen);
            labelMipoke.Text = miPokemon.Nombre.ToString();
        }

        private void comboBoxPokemones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int IndiceMiPokemon = listBox1.SelectedIndex;
            var miPokemon = ListaPokemonesUser[IndiceMiPokemon];

            if (miPokemon != null)
            {
                ListaPokemonesUser.Remove(miPokemon);
                ActualizarListbox();
            }
        }

        private void comboBoxPokemones_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void comboBoxPokemones_MouseLeave(object sender, EventArgs e)
        {

        }

        private void comboBoxPokemones_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPokemones_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // MessageBox.Show("Alerta");
            var pokemonSelected = ObtenerPokemonDelCombox();

            string path_imagen = pokemonSelected.path_imagen;

            picBoxPokeSelected.Image = Image.FromFile(path_imagen);
            labelPokeSelected.Text = pokemonSelected.Nombre.ToString();
            labelFuerzaPoke.Text = pokemonSelected.PoderAtaque.ToString();
            labelTipoPoke.Text = pokemonSelected.Tipo.ToString();
        }
    }
}


