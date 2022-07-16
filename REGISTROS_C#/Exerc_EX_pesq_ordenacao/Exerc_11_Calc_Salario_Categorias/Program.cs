using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_eXEMPLO_PESQUISA_ORDENACAO
{
    class Program
    {
      public  struct Cad_Reajuste
        {
            public string nome;
            public double salario;
            
        }

        static void Main(string[] args)
        {
            Cad_Reajuste[] Nomes = new Cad_Reajuste[4];
            int I, J;

            string Pesq, X;
            Double Y;
            for (I = 0; I <=3; ++I)
            {
                Console.Write("{0}.o digite o nome: ", I + 1);
                Nomes[I].nome = Console.ReadLine();
                Console.Write("Salario: ");
                Nomes[I].salario = double.Parse(Console.ReadLine());
                
            }

            for (I = 0; I <= 2; ++I)
            {
                for (J = I + 1; J <= 3; ++J)
                {
                    if (Nomes[I].nome.CompareTo(Nomes[J].nome) > 0)
                    {
                        X = Nomes[I].nome;
                        Nomes[I].nome = Nomes[J].nome;
                        Nomes[J].nome = X;


                        Y= Nomes[I].salario;
                        Nomes[I].salario = Nomes[J].salario;
                        Nomes[J].salario = Y;

                    }

                }
            }

            for (I = 0; I <= 3; ++I)
            {   
                    Console.WriteLine("{1}.o nome: {0}", Nomes[I].nome, I + 1);
            }
            Console.Write("Qual nome deseja verificar a posicao: ");
            Pesq = Console.ReadLine();

            for (I = 0; I <= 3; ++I)
            {
                if (Pesq.ToUpper() == Nomes[I].nome.ToUpper())
                {
                    Console.WriteLine("{0} encontrado na posicao {1}, salirio = {2}", Nomes[I].nome, I + 1, Nomes[I].salario);
                }
            }

            Console.WriteLine("Tecle <ENTER> para sair");
            Console.ReadKey();
           
        }
    }
}
