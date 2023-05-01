using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivo
    {
        public static void LeerArchivo(string path)
        {
            string contenidoArchivo = File.ReadAllText(path);
            Console.Write(contenidoArchivo);
            
        }

        public static void LeerLineaALinea(string path)
        {
            StreamReader sr = File.OpenText(path);
            sr.ReadLine();  

        }

    }
}
