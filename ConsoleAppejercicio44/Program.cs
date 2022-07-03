using System;

namespace ConsoleAppejercicio44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("promedio de las notas");

            double promedio;

            Console.Write("ingrese la primera nota");
            var nota1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese la segunda nota");
            var nota2 = int.Parse(Console.ReadLine());
            Console.Write("ingrese la tercera nota");
            var nota3 = int.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"el promedio es {promedio}");
            Console.ReadLine();

            if (promedio = "1" || "2" || "3" || "4") ;


            ;

        }
    }
}
