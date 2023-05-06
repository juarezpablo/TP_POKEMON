using Datos;
namespace Consola_Pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var direccion = "C:\\Users\\VAIO}\\source\\repos\\TP_POKEMON\\Datos\\usuarios.txt";
            //Archivo.LeerArchivo(direccion);

            //1 Archivo.LeerLineaALinea(direccion);
            //2 var lista_usuarios = Archivo.DevolverListaArchivoUsuarios(direccion);
            //2 foreach(var item in lista_usuarios) {
            //2     Console.WriteLine(item);
            //2 }

            var lista_usuarios = Archivo.DevolverListaArchivoDiccUsuarios(direccion);
            foreach (var item in lista_usuarios)
            {
                Console.WriteLine(item["nombre"]);
                Console.WriteLine(item["contrasenia"]);
                Console.WriteLine(item["rol"]);
                Console.WriteLine("-----------------");
            }

           
        }
    }
}