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

            Archivo.LeerLineaALinea(direccion);
        }
    }
}