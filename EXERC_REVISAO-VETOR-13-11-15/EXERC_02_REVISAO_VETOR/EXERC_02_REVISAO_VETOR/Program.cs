using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERC_02_REVISAO_VETOR
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[5];
            int[] B = new int[5];
            int I, J,RESP=1;
            while (RESP == 1)
            {
                for (I = 0; I <= 4; I++)
                {
                    Console.Write("POSIÇÃO {0}º Valor Vetor A :  ", I + 1);
                    A[I] = int.Parse(Console.ReadLine());

                }

                for (J = 0; J <= 4; J++)
                {
                    Console.Write("POSIÇÃO {0}º Valor Vetor B:  ", J + 1);
                    B[J] = int.Parse(Console.ReadLine());

                }

                for (I = 0; I <= 4; I++)
                {
                    if (A[I] != B[I])
                    {

                        Console.WriteLine("Posiçao Diferente :   {0}", I + 1);
                    }
                }


                Console.Write("Deseja Continuar? ---1-sim---2--nao:   ");
                RESP = int.Parse(Console.ReadLine());


            }











            Console.ReadKey();
        
        
        
        
        
        
        
        
        
        }
    }
}
