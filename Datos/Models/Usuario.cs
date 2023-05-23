using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
   
    public class Usuario
    {
        private string _nombre;
        private string _contrasenia;
        private string _rol;
        private bool _active;
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        public string Rol { get; set; }

        public bool Active { get; set; }
        public int[] ArraydeEnteros ;
        public Usuario(string Nombre, string Contrasenia, string Rol, bool Active)
        {
            _nombre = Nombre;
            _contrasenia = Contrasenia;
            _rol = Rol;
            _active = Active;
            this.ArraydeEnteros = new int[4];
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(_nombre);
            sb.AppendLine(_contrasenia);
            sb.AppendLine(_rol);
            
            return sb.ToString();
        }

        public bool IsAdmin()
        {
            var retorno = false;
            if (_rol== "administrador")
            {
                retorno=true;
            }
            return retorno;
        }
        public bool IsUser(string nombreIngresado,string passIngresada)
        {
            bool retorno = false;
            if((_nombre==nombreIngresado) && (_contrasenia == passIngresada))
            {
                //Console.WriteLine("valido en usuario");
                retorno=true;
            }
            return retorno;
        }

        public bool IsLogin()
        {
            var retorno = false;
            if(_active)
            {
                retorno = true;
            }
            return retorno;
        }
        public string MostrarUser() { return _nombre; }

    }
}
