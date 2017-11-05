using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    public class Calculator : ICalculator
    {
        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Dividir(int a, int b)
        {
            if (a < b)
                throw new InvalidOperationException();
            if (a <= 0)
                return 0;

            if (b == 0)
                return a;

            return a / b;
        }
    }
}
