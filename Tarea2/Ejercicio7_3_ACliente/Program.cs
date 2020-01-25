using System;
using System.Collections;

namespace Ejercicio7_3_ACliente
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Hashtable Diccionario = new Hashtable();
            Diccionario.Add("Badulaque", "Persona necia, inconsistente.");
            Diccionario.Add("Apodyopsis", "El acto de desverstir mentalmente a una persona.");
            Diccionario.Add("Kalopsia", "La ilusion de creer que algo es mas lindo de lo que en realidad es.");

            Console.WriteLine("|-|-| Diccionario |-|-| ");
            foreach (DictionaryEntry datos in Diccionario)
            Console.WriteLine("\n–{0}:   {1}", datos.Key, datos.Value);

        }



    }
}
