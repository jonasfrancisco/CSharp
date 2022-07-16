using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_maior_Torcida
{
    class Program
    {
        static void Main(string[] args)
        {

          
            float TOT_GREMIO = 0, TOT_INTER = 0,TOT_SP=0, PERCENT_GREMIO, PERCENT_INTER,PERCENT_SAOPAULO=0, SOMA_I = 0, SOMA_G = 0,SOMA_SP=0, TOT_GERAL = 0;
            int OPCAO = 0;

            do
            {

                Console.WriteLine("ESCOLHA SEU TIME ou [4]-Sair");
                Console.WriteLine("[1] INTER");
                Console.WriteLine("[2] GREMIO");
                Console.WriteLine("[3] SÃO PAULO");
                Console.WriteLine("[4] FIM");
                OPCAO = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (OPCAO)
                {
                    case 1:
                        SOMA_I++;

                        break;

                    case 2:
                        SOMA_G++;
                        break;


                    case 3:
                        SOMA_SP++;
                        break;


                }

            } while (OPCAO != 4);

            TOT_GERAL = SOMA_G + SOMA_I+SOMA_SP;
            TOT_GREMIO = SOMA_G;
            TOT_INTER = SOMA_I;
            TOT_SP = SOMA_SP;

            PERCENT_INTER = (SOMA_I * 100) / TOT_GERAL;

            PERCENT_GREMIO = (SOMA_G * 100) / TOT_GERAL;

            PERCENT_SAOPAULO = (SOMA_SP * 100) / TOT_GERAL;

            Console.Write("Total de Torcedores ...:  " + TOT_GERAL);
            Console.WriteLine();
            Console.Write("=================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Total de Torcedores -Gremio ...:  " + TOT_GREMIO);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Total de Torcedores -Inter...:   " + TOT_INTER);
            Console.WriteLine();
            Console.WriteLine();
           
            Console.Write("Total de Torcedores -SÃO PAULO...:   " + TOT_SP);
            Console.WriteLine();
            Console.Write("=================================================");
            Console.WriteLine();
            Console.Write("Percentual de Torcedores-Inter...:  " + PERCENT_INTER+"%");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Percentual de Torcedores-Gremio ...:  " + PERCENT_GREMIO + "%");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Percentual de Torcedores-SÃO PAULO ...:  " + PERCENT_SAOPAULO + "%");


            Console.ReadKey();
          
        }
    }
}
