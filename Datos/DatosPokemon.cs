using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using global::Datos.Models;
namespace Datos
{
    public class DatosPokemon
    {
       //private static List<Pokemon> ListaPokemon;
      // public static List<Pokemon> LISTA { get { return ListaPokemon; } }
        public static List<Pokemon> pokemonslistaUsuario = new List<Pokemon>();

        public static void AgregarPokemon(int Id, string Nombre, int PoderAtaque, int Vida, string Tipo,string PathImagen)
        {
            var pokemon = new Pokemon(Id, Nombre, PoderAtaque, Vida, Tipo, PathImagen);
          //  ListaPokemon.Add(pokemon);

        }
        
       
        public static List<Pokemon> HarcodearListaPokemon(List<Pokemon>Lista)
        {
            Lista.Add( new Pokemon(1, "Pikachu", 100, 700, "electrico", "C:/Users/VAIO}/source/repos/TP_POKEMON/Datos/images_pokemon/pikachu.jpg"));
            Lista.Add(new Pokemon(9, "Charmander", 90, 700, "fuego", "C:/Users/VAIO}/source/repos/TP_POKEMON/Datos/images_pokemon/charmander.jpg"));
            Lista.Add(new Pokemon(2, "Bulbasur", 90, 700, "planta", "C:/Users/VAIO}/source/repos/TP_POKEMON/Datos/images_pokemon/bulbasur.jpg"));
            Lista.Add(new Pokemon(3, "Charizard", 120, 700, "fuego", "C:/Users/VAIO}/source/repos/TP_POKEMON/Datos/images_pokemon/charizard.jpg"));
            Lista.Add(new Pokemon(4, "Squirtle", 90, 700, "agua", "C:/Users/VAIO}/source/repos/TP_POKEMON/Datos/images_pokemon/squirtle.jpg"));
            Lista.Add(new Pokemon(5, "Snorlax", 120, 700, "fisico", "C:/Users/VAIO}/source/repos/TP_POKEMON/Datos/images_pokemon/snorlax.jpg"));
            Lista.Add(new Pokemon(6, "Pidggeoto", 90, 700, "volador", "C:/Users/VAIO}/source/repos/TP_POKEMON/Datos/images_pokemon/pidgeotto.jpg"));
            Lista.Add(new Pokemon(7, "Butterfly", 70, 700, "volador", "C:/Users/VAIO}/source/repos/TP_POKEMON/Datos/images_pokemon/butterfly.jpg"));
            Lista.Add(new Pokemon(8, "Machop", 10, 700, "roca", "C:/Users/VAIO}/source/repos/TP_POKEMON/Datos/images_pokemon/machop.jpg"));

            return Lista;
        }

        public static List<Pokemon> HarcodearListaPokemon(List<Pokemon> Lista,bool user)
        {
            Lista.Add(new Pokemon(1, "Pikachu", 100, 700, "electrico", "C:/Users/VAIO}/source/repos/TP_POKEMON/Datos/images_pokemon/pikachu.jpg"));
            

            return Lista;
        }
        public static List<Pokemon> CrearListaPokemon()
        {
            List<Pokemon> ListaPokemon;
            ListaPokemon = new List<Pokemon>();
            ListaPokemon=HarcodearListaPokemon(ListaPokemon);
            return ListaPokemon;
        }

      //  }
        //b/ic static void MostrarListaPokemon()
        //
         // foreach(var pokemon in LISTA)
          //{
           //     Console.WriteLine(pokemon);
           // }
        //}

    }
}
