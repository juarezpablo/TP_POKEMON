namespace Datos
{
    using global::Datos.Models;
    using Microsoft.VisualBasic;
    using System.ComponentModel;

    public class DatosUsuarios
    {
        private static List<Usuario> listaUsuarios;
        public static List<Usuario> LISTA { get { return listaUsuarios; } }


       
        
        

        public static void AgregarUsuario(string nombre, string contrasenia, string rol, bool active = false)
        {
            

            var usuario = new Usuario(nombre, contrasenia, rol, active);
            listaUsuarios.Add(usuario);

        }

        public static void CrearListaUsuarios(List<Dictionary<string, string>> listaAux)
        {
            listaUsuarios = new List<Usuario>();
            foreach (var user in listaAux)
            {
                AgregarUsuario(user["nombre"], user["contrasenia"], user["rol"]);
            }
            
        }

        public static void MostrarListaUsuarios()
        {
            foreach (var userAux in listaUsuarios)
            {
                Console.WriteLine(userAux);
            }
        }

        public static object ObtenerUsuarioLogueado()
        {
            
            foreach(var userAux in listaUsuarios)
            {
                if (userAux.Active == true)
                {
                    return  userAux; 
                }
            }
            return "Error";
        }

        public static bool VerificarUsuario(string nombreIngresado, string contraseniaIngresada)
        {
            bool retorno = false;
            foreach (var userAux in listaUsuarios)
            {
                //string nombre = userAux.MostrarUser();
              //  Console.WriteLine(nombre);

                // if (userAux.Nombre == nombreIngresado && userAux.Contrasenia==contraseniaIngresada) 
                if (userAux.IsUser(nombreIngresado, contraseniaIngresada)) 
                {
                    Console.WriteLine("Valido en Datos");
                    userAux.Active = true;
                    retorno= true;
                }
                else
                {

                    Console.WriteLine("no coincide");
                    Console.WriteLine(nombreIngresado);
                }
            }
            return retorno;
        }
        
        public static bool IsLogin()
        {
            var retorno = false;
            foreach(var item in listaUsuarios)
            {
                if(item.IsLogin())
                {
                    retorno = true;
                }
            }
            return retorno;
        }

       // public static List<Usuario> ObtenerListaUsuarios() 
       // { 
        //    return listaUsuarios;
        //}

        public static void HarcodearListaPokeUsuario()
        {
            var contador = 1;
            foreach (var usuario in listaUsuarios)
            {
               // usuario.ArraydeEnteros;
            }
        }
        
    }
        


    
}