using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            var options = new ArgumentsOptions();
            var isValid = CommandLine.Parser.Default.ParseArguments(args, options);

            if (isValid)
            {
                var c = new Calculator();
                double result = 0;
                switch (options.Operacion)
                {
                    case OperationType.suma:
                        result = c.Suma(options.Value1, options.Value2);
                        break;
                    case OperationType.divide:
                        result = c.Dividir(options.Value1, options.Value2);
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"Resultado esperado: {result}");

                Console.WriteLine();
                c.Dividir(1, 3);
                Console.WriteLine();

                Console.WriteLine("Pulse INTRO para finalizar...");
                Console.ReadLine();
            }
    }
}
