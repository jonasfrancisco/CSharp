using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_3_Cadastro_produtos
{
    class Program
    {

        public struct CAD_PROD
        {
            public string nome;
            public float COD;
            public float PRECO;

        }

        static void Main(string[] args)
        {
            int I;
            bool ACHA;
            string PESQ1, RESP = " ";

            CAD_PROD[] PESQ = new CAD_PROD[3];

            for (I = 0; I <= 1; I++)
            {
                Console.Write("Informar NOME PRODUTO: ");
                PESQ[I].nome = Console.ReadLine();

                Console.Write("Informar PRECO  : ");
                PESQ[I].PRECO = float.Parse(Console.ReadLine());

                Console.Write("Informar CODIGO : ");
                PESQ[I].COD = float.Parse(Console.ReadLine());

            }

            Console.WriteLine();
          
            for (I = 0; I <= 1; I++)
            {

                Console.WriteLine("{0} {1} ", PESQ[I].nome, PESQ[I].COD);
            }
             
            Console.Write("Fazer Pesquisa -S -N :  ");
            RESP = Console.ReadLine();

            while (RESP == "S")
            {
                Console.WriteLine("Informar codigo  :  ");
                PESQ1 = Console.ReadLine();

                ACHA = false;
                I = 0;
                while (ACHA == false)
                {
                    if (float.Parse (PESQ1 )== (PESQ[I].COD))
                    {
                        ACHA = true;
                    }
                    else
                    {
                        I++;
                    }
                }
                if (ACHA == true)
                {
                    Console.WriteLine("PRECO DO PRODUTO  : " + PESQ[I].PRECO);
                }
                else
                {
                    Console.WriteLine(" NAo Encontrado ");
                }
                
                Console.WriteLine("Continuar Pesq -S-N");
                RESP = Console.ReadLine();
            }
            
            Console.WriteLine();

            Console.ReadKey();         
        }
    }
}
