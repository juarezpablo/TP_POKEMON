using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
   
    internal class Usuario
    {
        private string _nombre;
        private string _contrasenia;
        private string _rol;
        private bool _active;
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        public string Rol { get; set; }

        public bool Active { get; set; }
        public Usuario(string Nombre, string Contrasenia, string Rol, bool Active)
        {
            _nombre = Nombre;
            _contrasenia = Contrasenia;
            _rol = Rol;
            _active = Active;
        }


        

    }
}
