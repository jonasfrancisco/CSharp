using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_06_Cadastro_Imoveis
{
    class Program
    {
        struct IMOVEIS
        {
            public string tipo;
            public string bairro;
            public float valor;
            public string endereco;
            public string situacao;

        }



        static void Main(string[] args)
        {
            int I;
            string RESP=" ", PESQ;
            IMOVEIS[] IMOV = new IMOVEIS[5];
            Console.Write("CADASTRO DE IMOVEIS");
            Console.WriteLine();
            for (I = 0; I <= 1; I++)
            {
                Console.Write("Informar Tipo do Imovel : ");
                IMOV[I].tipo = Console.ReadLine();

                Console.Write("Informar Endereco : ");
                IMOV[I].endereco = Console.ReadLine();

                Console.Write("Informar Bairro : ");
                IMOV[I].bairro = Console.ReadLine();

                Console.Write("Informar Valor : ");
                IMOV[I].valor = float.Parse(Console.ReadLine());

                Console.Write("Informar Situacao : ");
                IMOV[I].situacao = Console.ReadLine();

            }

                Console.Write("Deseja Pesquisar -Sim-Nao : ");
                RESP = Console.ReadLine();
                while (RESP == "Sim")
                {

                    Console.Write("Pesquisar Situacao- venda ou compra :   ");
                    PESQ = Console.ReadLine();

                for (I = 0; I <= 1; I++)
                {
                    if (PESQ == IMOV[I].situacao)
                    {
                        Console.WriteLine();

                        Console.Write("Dados do Imovel ");

                        Console.WriteLine();

                        

                            Console.WriteLine(" TIPO ...:    " + IMOV[I].tipo);
                            Console.WriteLine(" ENDERECO ...:    " + IMOV[I].endereco);
                            Console.WriteLine(" BAIRRO ...:    " + IMOV[I].bairro);
                            Console.WriteLine(" VALOR ...:    " + IMOV[I].valor);




                        Console.Write("Deseja Pesquisar -Sim-Nao : ");
                        RESP = Console.ReadLine();


                    }




                }



            }





            Console.ReadKey();




        }
    }
}
