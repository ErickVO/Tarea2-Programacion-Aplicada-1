using System;

namespace Ejercicio9_4
{
    class Program
    {
        enum Neumaticos {Diagonal=1,Radial,Verano,Invierno,AllSeason,Asimetrico,Direccionales,Tubuless,
        PerfilBajo,ReCauchutados,RunFlat,Ecologicos}
        static void Main(string[] args)
        {
            Neumaticos neumaticos;
            neumaticos = Neumaticos.Diagonal;
            Console.WriteLine("Los neumaticos son: {0}", neumaticos); 
        }
    }
}
