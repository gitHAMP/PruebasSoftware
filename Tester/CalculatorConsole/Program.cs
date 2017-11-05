using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            var c = new Calculator();
            double result1 = 0;
            double result2 = 0;

            result1 = c.Suma(3, 2);

            result2 = c.Dividir(3, 2);

            Console.WriteLine($"Resultado esperado de suma: {result1}");
            

            Console.WriteLine($"Resultado esperado de resta: {result2}");
            



            Console.WriteLine();
            c.Dividir(1, 3);
            Console.WriteLine();

            Console.WriteLine("Pulse INTRO para finalizar...");
            Console.ReadLine();
            }
        }
}

