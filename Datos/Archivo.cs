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
           // var contenido = sr.ReadLine();
           // Console.Write(contenido);

            while(sr.Peek() != -1)
            {
                var contenido = sr.ReadLine();
                Console.WriteLine(contenido);
            }

            sr.Close();
            sr.Dispose();

        }
        public static List<string> DevolverListaArchivoUsuarios(string path)
        {
            StreamReader sr = File.OpenText(path);
            var lista_users= new List<string>();
            while (sr.Peek() != -1)
            {
                var contenido = sr.ReadLine();
                // Console.WriteLine(contenido);
                lista_users.Add(contenido);
            }

            sr.Close();
            sr.Dispose();
            return lista_users;

        }


        public static List<Dictionary<string, string>> DevolverListaDiccUsuarios(string path)
        {
            StreamReader sr = File.OpenText(path);
            var lista_users = new List<Dictionary<string, string>>();
            while (sr.Peek() != -1)
            {
                Dictionary<string, string> user = new Dictionary<string, string>();
                for (int i=0; i < 3; i++) {
                    var contenido=sr.ReadLine();
                    if (i == 0){
                        user.Add("nombre", contenido);
                    }
                    else if (i == 1)
                    {
                        user.Add("contrasenia", contenido);
                    }
                    else
                    {
                        user.Add("rol", contenido);
                    } 
                }    
                // Console.WriteLine(contenido);
                lista_users.Add(user);
            }

            sr.Close();
            sr.Dispose();
            return lista_users;

        }

    }
}
