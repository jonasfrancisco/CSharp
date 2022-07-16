using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_09_Empresa_pecas
{
    class Program
    {
        struct CAD_PECAS
        {
            public double valor;
            public string tipo;
            public int num;
            public string nome;

        }

        static void Main(string[] args)
        {
            string RESP = "SIM";
            CAD_PECAS cliente;
            int PA = 0, PO = 0, ARR = 0;
            double sd = 0,preco_desc=0, prec_po=0, prec_pa=0, prec_arr=0,total_compra=0,total_desconto=0;
            Console.Write("Informar Nome :  ");
            cliente.nome = Console.ReadLine();

            while (RESP.ToUpper() == "SIM")
            {
                Console.Clear();
                Console.WriteLine("Menu Peças");

                Console.WriteLine("Tipo ------- Valor");
                Console.WriteLine("Parafuso------- 0.70");
                Console.WriteLine("Porcas----------0.80");
                Console.WriteLine("Arruela---------0.90");

               
                Console.Write(" Informar Tipo : ");
                cliente.tipo = Console.ReadLine();

                Console.Write("Informar Quantidade : ");
                cliente.num = int.Parse(Console.ReadLine());

                switch (cliente.tipo.ToUpper())
                {
                    case "PARAFUSO":

                        sd =cliente.num * 0.70;
                        cliente.valor = (cliente.num * 0.70) * 0.20;
                        preco_desc = sd - cliente.valor;

                        PA = cliente.num; //quantidade parafusos
                        prec_pa = preco_desc; // calcular total da compra
                        total_desconto =sd- preco_desc;

                        break;

                    case "PORCAS":
                        sd = cliente.num * 0.80;
                        cliente.valor = (cliente.num * 0.80) * 0.10;
                        PO = cliente.num;

                        preco_desc = sd - cliente.valor;
                        prec_po = preco_desc;
                        total_desconto = sd - preco_desc;
                        break;

                    case "ARRUELAS":
                        sd = cliente.num * 0.90;

                        cliente.valor = (cliente.num * 0.90) * 0.30;
                        ARR=cliente.num;


                        preco_desc = sd - cliente.valor;
                        prec_arr = preco_desc;

                        total_desconto = sd - preco_desc;
                        break;


                }

                total_compra = prec_pa + prec_po + prec_arr;

                Console.WriteLine();
                Console.WriteLine("Dados -Compra ");
                Console.WriteLine(" Nome Cliente :  "+ cliente.nome);
                Console.WriteLine(" Numero de Parafusos Comprados :  "+PA);
                Console.WriteLine(" Numero de Porcas Compradas :  " + PO);
                Console.WriteLine(" Numero de Arruelas Compradas :  " + ARR);

                Console.WriteLine();
                Console.WriteLine("Preco sem Desconto :  " + sd);

                Console.WriteLine("Preco com Desconto :  " + preco_desc);

                Console.WriteLine("TOTAL COMPRA :  " +total_compra);

                Console.WriteLine("TOTAL desconto  :  " + total_desconto);

                Console.Write("Deseja Continuar ?  " + cliente.nome +": SIM - NAO ....:   ");
                RESP = Console.ReadLine();



            }


            Console.ReadKey();


        }
    }
}
