using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_09_Comissao_Corretores
{
    class Program
    { struct CAD_CORRETORES
        {
            public string nome;
            public double valor_venda;

        }




        static void Main(string[] args)
        {
            int i;
           double COMISSAO = 0, tot_vendas = 0;

            CAD_CORRETORES[] CORRETOR = new CAD_CORRETORES[3];

            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine("CALCULO COMISSAO");

                Console.Write("Informar Nome : ");
                CORRETOR[i].nome = Console.ReadLine();

                Console.Write("Informar Valor de Vendas : (R$)  ");
                CORRETOR[i].valor_venda = double.Parse(Console.ReadLine());
                tot_vendas=tot_vendas+CORRETOR[i].valor_venda;

                if (CORRETOR[i].valor_venda > 50.000)
                {
                    COMISSAO = (CORRETOR[i].valor_venda * 12) / 100;

                }

                if (CORRETOR[i].valor_venda >= 30.000 && CORRETOR[i].valor_venda<= 50.000)
                {
                    COMISSAO = (CORRETOR[i].valor_venda * 9.5) / 100;

                }
                else
                {

                    COMISSAO = (CORRETOR[i].valor_venda * 7) / 100;
                }
                Console.WriteLine();
                Console.Write("Dados Corretor ");
                Console.WriteLine();
                Console.WriteLine("Nome......:  "+CORRETOR[i].nome);
                Console.WriteLine("Valor Vendas......: (R$) "+CORRETOR[i].valor_venda);
                Console.WriteLine("Comissao a receber.........: (R$)  "+COMISSAO);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("DADOS DA EMPRESA - TOTAL DE VENDAS");
            Console.WriteLine();
            Console.Write("Total Vendas : (R$) " + tot_vendas);

            Console.ReadKey();


        }
    }
}
