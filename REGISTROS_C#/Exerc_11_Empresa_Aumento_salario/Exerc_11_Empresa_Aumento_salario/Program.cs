using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_11_Empresa_Aumento_salario
{
    class Program
    {
         struct CAD_EMPRESA
        {
            public string nome;
            public string categoria;
            public double salario;

        }



        static void Main(string[] args)
        {
            CAD_EMPRESA FUNC;
            double Novo_Salario = 0;
            String RESP = "SIM";
            while (RESP.ToUpper() == "SIM")
            {
                Console.Clear();
                Console.Write("Informar Nome : ");
                FUNC.nome = Console.ReadLine();

                Console.Write("Informar Salario : (R$)  ");
                FUNC.salario = double.Parse(Console.ReadLine());

                Console.Write("Informar Categoria : ");
                FUNC.categoria = Console.ReadLine();

                if (FUNC.categoria.ToUpper() == "A" || FUNC.categoria.ToUpper() == "C" || FUNC.categoria.ToUpper() == "F" || FUNC.categoria.ToUpper() == "H")
                {

                    Novo_Salario = FUNC.salario + (FUNC.salario * 0.10);
                }

                // segunda categoria

                if (FUNC.categoria.ToUpper() == "B" || FUNC.categoria.ToUpper() == "D" || FUNC.categoria.ToUpper() == "E" || FUNC.categoria.ToUpper() == "I" || FUNC.categoria.ToUpper() == "J" || FUNC.categoria.ToUpper() == " T")
                {

                    Novo_Salario = FUNC.salario + (FUNC.salario * 0.15);

                }

                //TERCEIRA CATEGORIA 


                if (FUNC.categoria.ToUpper() == "K" || FUNC.categoria.ToUpper() == "R")
                {
                    Novo_Salario = FUNC.salario + (FUNC.salario * 0.25);
                }

                //QUARTA CATEGORIA

                if (FUNC.categoria.ToUpper() == "L" || FUNC.categoria.ToUpper() == "M" || FUNC.categoria.ToUpper() == "N" || FUNC.categoria.ToUpper() == "O" || FUNC.categoria.ToUpper() == "P" || FUNC.categoria.ToUpper() == "Q" || FUNC.categoria.ToUpper() == "S")
                {
                    Novo_Salario = FUNC.salario + (FUNC.salario * 0.35);
                }

                // QUINTA CATEGORIA

                if (FUNC.categoria.ToUpper() == "U" || FUNC.categoria.ToUpper() == "V" || FUNC.categoria.ToUpper() == "X" || FUNC.categoria.ToUpper() == "Y" || FUNC.categoria.ToUpper() == "W" || FUNC.categoria.ToUpper() == "Z")
                {
                    Novo_Salario = FUNC.salario + (FUNC.salario * 0.50);
                }

                Console.WriteLine();

                Console.WriteLine("DADOS FUNCIONARIO ");


                Console.WriteLine("Nome Funcionario :  " + FUNC.nome);

                Console.WriteLine(" Categoria  :  " + FUNC.categoria);

                Console.WriteLine(" Salario Reajustado  : (R$)  " + Novo_Salario);

                Console.WriteLine();

                Console.Write("Deseja Continuar ? -- SIM -- NAO.....:   ");
                RESP = Console.ReadLine();
            }
           



            Console.ReadKey();


        }
    }
}
