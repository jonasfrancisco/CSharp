using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_01_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int SOMA=0, I=0;

            while(I<=10)
            {
                SOMA = SOMA + I;
                I = I + 1;
               
            }

            Console.Write("Resultado Soma : " + SOMA);

            Console.ReadKey();
        
        }
    }
}
