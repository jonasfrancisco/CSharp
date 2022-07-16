using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERC_04_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOME = " ";
             int NUM_NOMES=0;
           
            while(NOME!="FIM")
            {
                Console.Write("Informar Nome : ");
                NOME = Console.ReadLine();
                NUM_NOMES++;

                Console.WriteLine("DESEJA SAIR -FIM ");
                NOME = Console.ReadLine();
          
            }
            if (NUM_NOMES<=0)
            {
                Console.Write("Nome Inserido  ");


            }
            else
            {
                Console.Write("Total Nomes :  "+NUM_NOMES);
            
            
            } 





            Console.ReadKey();


        }
    }
}
