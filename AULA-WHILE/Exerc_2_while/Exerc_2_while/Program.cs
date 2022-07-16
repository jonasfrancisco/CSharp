using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_2_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOME,MAISVELHO="",MAISNOVO="";
            int ANO, IDADE = 0, MAIOR = 0, MENOR =1000, RESP = 1;

           
            
            while(RESP==1)
           {
               Console.Write("Informar o Nome: ");
               NOME = Console.ReadLine();


               Console.Write("Informar o Ano Nascimento: ");
               ANO=int.Parse(Console.ReadLine());

               IDADE = 2015 - ANO;
              
                if (IDADE > MAIOR)
               {
                   MAIOR = IDADE;
                   MAISVELHO = NOME;


               }

               if (IDADE < MENOR)
               {
                   MENOR = IDADE;
                   MAISNOVO = NOME;

               }

            
               
                Console.WriteLine("Deseja Continuar: 1 - Sim  2- Nao");

                RESP = int.Parse(Console.ReadLine());

            
              

           }


            Console.WriteLine("MAIS VELHO  :  " + MAISVELHO +" " + MAIOR);
            MAISVELHO = Console.ReadLine();


            Console.WriteLine("MAIS NOVO :  " + MAISNOVO + " " + MENOR);
            MAISNOVO = Console.ReadLine();
             


           

            Console.ReadKey();
        
        
        }
  
    
    }
}
