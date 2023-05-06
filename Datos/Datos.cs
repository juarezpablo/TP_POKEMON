namespace Datos
{
    using global::Datos.Models;


    public class Datos
    {
        public object CrearUsuario(string nombre, string contrasenia, string rol, bool active=false)
        {
            var usuario = new Usuario(nombre, contrasenia, rol, active);
            return usuario;
            // Usuario user = new Usuario("pepe", "pepito", "user", false);

        }

        


    }
}