using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class LogicaJuego
    {

        
        public static int Pelear(Pokemon retadorIngresadp, Pokemon oponenteIngresado)
        { 
            var retador=retadorIngresadp;
            var oponente=oponenteIngresado;
            Random numeroRandom = new Random();
            int numeroPorcentaje = numeroRandom.Next(10);

            
            if (numeroPorcentaje < 8)//80porciento probabilidad de dano total
             {
                 oponente.Vida -= retador.PoderAtaque;
             }
             else
                 {
                   oponente.Vida -= (retador.PoderAtaque / 2);
                }
                    
             numeroPorcentaje=numeroRandom.Next(10);






            int resultado = oponente.Vida;
            return resultado;

           
        }

        
    }
}
