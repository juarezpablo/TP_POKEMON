using Login.Models;
using System.Globalization;

namespace Login
{
    
    public class Login
    {
        public void CrearUsuarios(string nombre, string contrasenia, string rol)
        {
            var usuario = new Usuario(nombre,contrasenia, rol);
            

        }


    }
}