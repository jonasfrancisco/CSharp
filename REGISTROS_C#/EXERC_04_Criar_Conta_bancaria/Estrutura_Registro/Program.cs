using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria
{
    class Program
    {
        struct cad_cliente

        {

            public string nome;
            public float deposito;
            public string cpf;

        }
   

        static void Main(string[] args)
        {
            int i=0;
            float D = 0,novo_saldo=0,S=0, novo_saldo2=0;

            cad_cliente[] CLIENTE = new cad_cliente[3];

            for (i = 0; i <= 2; i++)
            {
                Console.Write("Informar o Nome do Cliente : ");
                CLIENTE[i].nome = Console.ReadLine();

                Console.Write("Informar CPF :  ");
                CLIENTE[i].cpf=Console.ReadLine();

                Console.Write("Informar Valor Deposito :  ");
               CLIENTE[i].deposito =float.Parse( Console.ReadLine());
            }
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------");
                Console.Write("Conta Criada ");
         
                Console.WriteLine();
                Console.WriteLine("Menu");
                Console.WriteLine("-----------------");
                Console.WriteLine("[1]-Efetuar Novo Deposito ");
                Console.WriteLine("[2]-Efetuar Saque ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.Write("Informar novo Deposito : ");
                        D = float.Parse(Console.ReadLine());

                        novo_saldo = CLIENTE[i].deposito + D;

                        Console.WriteLine("DADOS :  Nome..: {0}  / SALDO FINAL..: {1} ", CLIENTE[i].nome,novo_saldo);



                        break;

                    case 2:

                        Console.Write("Informar valor Saque : ");
                        S = float.Parse(Console.ReadLine());

                        novo_saldo2 = CLIENTE[i].deposito - S;

                        Console.WriteLine("DADOS :  Nome..: {0}  / SALDO FINAL..: {1} ", CLIENTE[i].nome, novo_saldo2);



                        break;





                }




            }



            Console.ReadKey();



        }
    }
}
