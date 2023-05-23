using Datos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_POKEMON_FORM
{
    public partial class Form_Batalla : Form
    {
        List<Pokemon> pokemonesTotales;
        List<Pokemon> pokemonesUsuario;
        List<Pokemon> ListaPokemonesUser;
        Pokemon pokemonOponente;
        Pokemon pokemonRetador;
        public Form_Batalla(List<Pokemon> ListaPokemones, List<Pokemon> Lista_Pokemones_user)
        {
            InitializeComponent();
            ListaPokemonesUser = new List<Pokemon>();
            pokemonesTotales = ListaPokemones;
            pokemonesUsuario = Lista_Pokemones_user;
            foreach (Pokemon p in pokemonesUsuario)
            {
                ListaPokemonesUser.Add(p);
            }
            comboBoxMisPokemones.DataSource = ListaPokemonesUser;



        }

        private void buttonBuscarOponente_Click(object sender, EventArgs e)
        {

            Random itemrandom = new Random();
            int indicerandom = itemrandom.Next(pokemonesTotales.Count);
            var pokemonRandom = pokemonesTotales[indicerandom];

            pictureBoxOponente.Image = Image.FromFile(pokemonRandom.path_imagen);
            labelOponente.Text = pokemonRandom.Nombre.ToString();
            pokemonOponente = pokemonRandom;
            ActualizarBatalla();

        }

        private void comboBoxMisPokemones_SelectedIndexChanged(object sender, EventArgs e)
        {

            int IndiceSeleccionado = comboBoxMisPokemones.SelectedIndex;
            Pokemon pokemonSeleccionado = ListaPokemonesUser[IndiceSeleccionado];
            pictureBoxMiPokemon.Image = Image.FromFile(pokemonSeleccionado.path_imagen);
            labelMipokemon.Text = pokemonSeleccionado.Nombre;
            pokemonRetador = pokemonSeleccionado;
        }

        private void Form_Batalla_Load(object sender, EventArgs e)
        {
            comboBoxMisPokemones.DataSource = ListaPokemonesUser;
            
        }

        private void Form_Batalla_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void ActualizarBatalla()
        {
            progressBarOponente.Maximum = pokemonOponente.Vida;
            progressBarOponente.Value = pokemonOponente.Vida;
            progressBarpokemon.Maximum = pokemonRetador.Vida;
            progressBarpokemon.Value = pokemonRetador.Vida;
        }

        private void buttonAtaque_Click(object sender, EventArgs e)
        {
            foreach (Pokemon p in pokemonesUsuario)
            {
                MessageBox.Show(p.Nombre);
            }
        }
    }
}
