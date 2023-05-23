using Datos;
using Datos.Models;

namespace Consola_Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Hello, World!");
            var direccion = "C:\\Users\\VAIO}\\source\\repos\\TP_POKEMON\\Datos\\usuarios.txt";
            //Archivo.LeerArchivo(direccion);

            //1 Archivo.LeerLineaALinea(direccion);
            //2 var lista_usuarios = Archivo.DevolverListaArchivoUsuarios(direccion);
            //2 foreach(var item in lista_usuarios) {
            //2     Console.WriteLine(item);
            //2 }

            var lista_users = Archivo.DevolverListaDiccUsuarios(direccion);

            
            var userNombre = "admin";
            var userPass = "0000";

            DatosUsuarios.CrearListaUsuarios(lista_users);
            // DatosUsuarios.MostrarListaUsuarios();
            // if (DatosUsuarios.VerificarUsuario(userNombre, userPass))
            // {
            //     Console.WriteLine("ok");
            // }


            // var lista_pokemons = DatosPokemon.CrearListaPokemon();
            List<Pokemon> Lista;
            Lista=new List<Pokemon>();
            Lista=DatosPokemon.CrearListaPokemon();
            foreach(var pokemon in Lista)
            {
                Console.WriteLine(pokemon.Nombre);
            }
          //  DatosPokemon.MostrarListaPokemon();

           
        }
    }
}