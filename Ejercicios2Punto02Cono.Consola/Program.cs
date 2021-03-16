using Ejercicios2Punto02Cono.BL;
using System;

namespace Ejercicios2Punto02Cono.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cono cono = new Cono();
            Console.WriteLine("Se informara el Area y Volumen de un Cono");
            Console.Write("Por favor ingrese la Generatriz del cono:  ");
            if (double.TryParse(Console.ReadLine(), out var generatriz))
            {
                cono.Generatriz = generatriz;
                Console.Write("Por favor ingrese la Altura del cono:  ");
                if (double.TryParse(Console.ReadLine(), out var altura))
                {
                    cono.Altura = altura;
                    Console.Write("Por favor ingrese el Radio de giro del cono:   ");
                    if (double.TryParse(Console.ReadLine(), out var radio))
                    {
                        cono.Radio = radio;
                        Console.WriteLine("");
                        Console.WriteLine("Se informara los datos del cono");
                        Console.WriteLine($"Generatriz:{generatriz} Altura:{altura} ; Radio:{radio}");
                        Console.WriteLine($"Area:{cono.GetArea():N2}");
                        Console.WriteLine($"Volumen:{cono.GetVolumen():N2}");
                    }
                    else
                    {
                        Console.WriteLine("Radio de giro no valido");
                    }
                }
                else
                {
                    Console.WriteLine("Altura ingresada no valida");
                }
            }
            else
            {
                Console.WriteLine("Generatriz ingresada no valida");
            }
            Console.ReadLine();
        }
    }
}
