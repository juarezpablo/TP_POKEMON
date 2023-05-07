namespace Datos
{
    using global::Datos.Models;


    public class DatosUsuarios
    {
        private static List<Usuario> listaUsuarios;

       
        
        

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
            var retorno = new object();
            foreach(var userAux in listaUsuarios)
            {
                if (userAux.Active == true)
                {
                    retorno=userAux; 
                }
            }
            return retorno;
        }

    }
        


    
}