using System;
using System.Linq;

namespace Ejercicios2Punto02Cono.BL
    
{
    public class Cono
    {
        //Atributos
        public double Generatriz { get; set; }
        public double Altura { get; set; }
        public double Radio { get; set; }

        public Cono()
        {
              
        }

        public Cono(double generatriz, double altura, double radio)
        {
            Generatriz = generatriz;
            Altura = altura;
            Radio = radio;
        }

        //Métodos

        public double GetArea()
        {
            return Math.PI * Radio * (Radio + Generatriz);
        }
        public double GetVolumen()
        {
            return (Math.PI * Math.Pow(Radio, 2) * Altura) / 3;
        }
    }
}
