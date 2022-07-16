using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERC_03_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1 = 0, N2 = 0, N3 = 0, N4 = 0, MD=0;
            string NOME=" ";

            Console.WriteLine("INFORMAR NOME  : ");
            NOME = Console.ReadLine();

            while(NOME != "FIM")
            {
                Console.WriteLine("Informar nota : ");
                N1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Informar nota : ");
                N2= float.Parse(Console.ReadLine());
               
                Console.WriteLine("Informar nota : ");
                N3 = float.Parse(Console.ReadLine());

                Console.WriteLine("Informar nota : ");
                N4 = float.Parse(Console.ReadLine());

                MD = (N1 + N2 + N3 + N4) / 4;

                Console.Write("MEDIA : " + MD);
                Console.WriteLine();
               
                Console.WriteLine();

                Console.WriteLine("INFORMAR NOME :  ");
                NOME = Console.ReadLine();


            }


            
            
            
            Console.ReadKey();

        }
    }
}
