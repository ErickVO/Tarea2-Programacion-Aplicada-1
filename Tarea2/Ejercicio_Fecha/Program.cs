using System;

namespace Ejercicio_Fecha
{
    class Program
    {
        static void Main(string[] args)
        {
            String formato;

            formato = String.Format("La fecha es: {0:HH:mmtt yyyy dd MMM }", DateTime.Now);
            Console.WriteLine(formato);
        }
    }
}
