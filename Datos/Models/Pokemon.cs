using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Pokemon
    {
        private int _id;
        public string _nombre;
        private int _poderAtaque;
        private int _vida;
        private string _tipo;
        public string path_imagen;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int PoderAtaque { get; set; }
        public int Vida { get; set; }
        public string Tipo { get; set; }

        public Pokemon(int ID, string NOMBRE, int PODERATAQUE, int VIDA, string TIPO, string path_imagen)
        {
            Id = ID;
            Nombre = NOMBRE;
            PoderAtaque = PODERATAQUE;
            Vida = VIDA;
            Tipo = TIPO;
            _id = Id;
            _nombre = Nombre;
            _poderAtaque = PoderAtaque;
            _vida = Vida;
            _tipo = Tipo;
            this.path_imagen = path_imagen;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(_nombre);
          //  sb.AppendLine(...);
          //  sb.AppendLine(_tipo);

            return sb.ToString();
        }
    }
}
