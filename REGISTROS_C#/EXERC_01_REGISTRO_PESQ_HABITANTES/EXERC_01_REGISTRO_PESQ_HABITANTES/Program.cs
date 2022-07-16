using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERC_01_REGISTRO_PESQ_HABITANTES
{
    class Program
    {
      

                 public struct CAD_PESQ
               {


                   public float SALARIO;
                   public string SEXO;
                   public int IDADE;


               }
             
                 static void Main(string[] args)
               {
                   int I, IDADE_MAIOR = 0,IDADE_MENOR=9999 ;
                   float soma=0,media=0;
                   int H=0,M=0;
                   CAD_PESQ[] PESQ = new CAD_PESQ[4];
                   
                     for (I = 0; I <= 3; I++)
                   {

                       Console.Write("Informar Idade : ");
                       PESQ[I].IDADE = int.Parse(Console.ReadLine());

                       Console.Write("Informar SEXO F - M  : ");
                       PESQ[I].SEXO = Console.ReadLine();

                       Console.Write("Informar SALARIO : ");
                       PESQ[I].SALARIO = float.Parse(Console.ReadLine());

                       Console.WriteLine();

                       soma = soma + PESQ[I].SALARIO;
                      
                        if (PESQ[I].IDADE > IDADE_MAIOR)
                       {

                           IDADE_MAIOR = PESQ[I].IDADE;


                       }


                       if (PESQ[I].IDADE < IDADE_MENOR)
                       {

                           IDADE_MENOR = PESQ[I].IDADE;


                       }


                       if (PESQ[I].SEXO == "M")
                       {

                           H++;

                       }

                       if (PESQ[I].SEXO == "F" || PESQ[I].SALARIO <= 1000)
                       {

                           M++;

                       }
                     
                     
                                         
                     
                     }


                     media = soma / 4;


                     Console.WriteLine("MEDIA SALARIO :  "+media);
                     Console.WriteLine("MAIOR IDADE :  " + IDADE_MAIOR);
                     Console.WriteLine("MAIOR IDADE :  " + IDADE_MENOR);
                     Console.WriteLine("QT MULHERES - SALARIO MENOR QUE 1000 :  " + M);
                     Console.WriteLine("QT HOMENS :  " +H);
                     
                     Console.ReadKey();

               }
               
               
        
          
        
        }
    }

