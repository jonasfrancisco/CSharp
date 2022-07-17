using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERC_05_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM,VALOR=0,MENOR_V=0,MENOR=99999;

            Console.Write("ENTRE COM  Valor : ");
            NUM = int.Parse(Console.ReadLine());
            
            while(NUM !=-1)
            {
               
                if(NUM<MENOR)
                {
                    MENOR_V = NUM;
                }
                Console.Write("ENTRE COM  Valor : " );
                NUM = int.Parse(Console.ReadLine());
   
            }
            Console.WriteLine("Menor valor é {0}", MENOR_V);
            
            Console.ReadKey();

        }
    }
}
