namespace Datos
{
    using global::Datos.Models;
    
    
    public class Datos
    {
        public object CrearUsuario(string nombre, string contrasenia, string rol)
            {
                Usuario usuario = new Usuario(nombre, contrasenia, rol);
                return usuario;
               // Usuario user = new Usuario("pepe", "pepito", "user");

        }
        
        

    }
}