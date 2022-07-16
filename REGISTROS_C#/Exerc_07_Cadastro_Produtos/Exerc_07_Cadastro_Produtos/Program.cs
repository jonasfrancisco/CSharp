using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_07_Cadastro_Produtos
{
    class Program
    {
        struct CAD_PRODUTOS
        {
            public int codigo;
            public string descricao;
            public int estoque_atual;
            public int estoque_Minimo;
            public float preco;


        }

        static void Main(string[] args)
        {
            int i=0;
            for (i = 0; i <= 1; i++)
            {
                Console.WriteLine("CADASTRO DE PRODUTOS");

                CAD_PRODUTOS[] PRODUT = new CAD_PRODUTOS[5];

                Console.Write("Informar Codigo : ");
                PRODUT[i].codigo = int.Parse(Console.ReadLine());

                Console.Write("Informar Descricao : ");
                PRODUT[i].descricao = Console.ReadLine();

                Console.Write("Informar Estoque Minimo :  ");
                PRODUT[i].estoque_Minimo = int.Parse(Console.ReadLine());

                Console.Write("Informar Estoque Atual :  ");
                PRODUT[i].estoque_atual = int.Parse(Console.ReadLine());

                Console.Write("Informar Preco (R$) :  ");
                PRODUT[i].preco = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (PRODUT[i].estoque_atual < PRODUT[i].estoque_Minimo)
                {
                    Console.WriteLine("Dados do Produto");
                    Console.WriteLine();
                    Console.WriteLine("Codigo : " + PRODUT[i].codigo);
                    Console.WriteLine("Descricao :  " + PRODUT[i].descricao);
                    Console.WriteLine("Preco (R$) :  " + PRODUT[i].preco);
                    Console.WriteLine("Estoque Minimo : " + PRODUT[i].estoque_Minimo);
                    Console.WriteLine("Estoque Atual : " + PRODUT[i].estoque_atual);

                    Console.WriteLine();

                }
               


            }


            Console.ReadKey();
        }
    }
}
