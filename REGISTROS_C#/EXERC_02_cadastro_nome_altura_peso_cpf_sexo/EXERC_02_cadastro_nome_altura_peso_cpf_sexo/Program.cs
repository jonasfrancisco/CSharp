using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERC_02_cadastro_nome_altura_peso_cpf_sexo
{
    
        
       class Program
    {
       


                 public struct CAD_IMC
               {

                   public string nome;
                   public string SEXO;
                   public float altura;
                   public float peso;
                   public string cpf;
                   public float IMC;
                   
            
                 
                }

                 static void Main(string[] args)
                 {
                     int I;
                     bool ACHA;
                     string PESQ1,RESP=" ";

                     CAD_IMC[] PESQ = new CAD_IMC[3];

                     for (I = 0; I <= 1; I++)
                     {

                         Console.Write("Informar NOME : ");
                         PESQ[I].nome = Console.ReadLine();

                         Console.Write("Informar CPF : ");
                         PESQ[I].cpf = Console.ReadLine();


                         Console.Write("Informar SEXO F - M  : ");
                         PESQ[I].SEXO = Console.ReadLine();

                         Console.Write("Informar Altura : ");
                         PESQ[I].altura = float.Parse(Console.ReadLine());


                         Console.Write("Informar Peso : ");
                         PESQ[I].peso = float.Parse(Console.ReadLine());

                         PESQ[I].IMC=(PESQ[I].peso/PESQ[I].altura*PESQ[I].altura);


                                              
                     
              
                     
                }
                     Console.Write("Fazer Pesquisa -S -N :  ");
                     RESP = Console.ReadLine();


                     while (RESP == "S")
                     {
                         Console.WriteLine("Informar CPF :  ");
                         PESQ1 = Console.ReadLine();

                         ACHA = false;
                         
                         while (ACHA != false)
                         {

                             if (PESQ1 == PESQ[I].cpf)
                             {
                                 
                                 ACHA = true;
                             }

                             if (ACHA == true)
                             {


                                 Console.WriteLine("IMC : " + PESQ[I].IMC);
                                 
                             }

                             else
                             {

                                 Console.WriteLine(" NAo Encontrado ");

                             }

                             Console.WriteLine("Continuar Pesq -S-N");
                             RESP = Console.ReadLine();




                         }
                     }
                     
                     
                     Console.WriteLine();
                   
                     
                     



                     Console.ReadKey();  



       }      
    }
}
