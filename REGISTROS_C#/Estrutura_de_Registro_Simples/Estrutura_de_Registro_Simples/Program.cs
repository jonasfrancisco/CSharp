using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_Registro_Simples
{
    class Program
    {
        
       
         
               public struct CAD_ALUNO
               {


                   public string NOME;
                   public int SALA;
                   public float MEDIA;


               }
               static void Main (string[]args)
               {



                   CAD_ALUNO[] ALUNO = new CAD_ALUNO[8];
                   CAD_ALUNO X;
                   int I, J, LIN;

                   //ROTINA PARA A ENTRADA DOS NOMES E NOTAS

                   for (I = 0; I <= 7; I++)
                   {
                       Console.Clear();
                       Console.WriteLine("Cadastro de Alunos ");
                       Console.WriteLine();
                       Console.Write("Entre o {0}º nome....:  ", I + 1);
                       ALUNO[I].NOME = Console.ReadLine();
                       Console.Write("Entre a sala.....:  ");
                       ALUNO[I].SALA = int.Parse(Console.ReadLine());
                       Console.Write("Entre a media.....:  ");
                       ALUNO[I].MEDIA = float.Parse(Console.ReadLine());
                       Console.WriteLine();



                   }

                   //CLASSIFICAÇÃO DOS DADOS 


                   for (I = 0; I <= 6; I++)
                   {
                       for(J=1+1;J<=7;J++)
                           if (ALUNO[I].NOME.CompareTo(ALUNO[J].NOME) > 0)
                           {
                               X = ALUNO[I];
                               ALUNO[I] = ALUNO[J];
                               ALUNO[J] = X;

                           }

                   }


                   Console.Clear();
                   Console.WriteLine("RELATORIO GERAL ");
                   Console.WriteLine();

                   Console.SetCursorPosition(0, 3);
                   Console.Write("ALUNO");
                   Console.SetCursorPosition(41,3);
                   Console.Write("SALA");
                   Console.SetCursorPosition(48, 3);
                   Console.WriteLine(" Media");



                   LIN = 6;
                   for (I = 0; I <= 7; I++)
                   {
                       Console.SetCursorPosition(0, LIN);
                       Console.Write(ALUNO[I].NOME.ToUpper());
                       Console.Write("{0,4}", ALUNO[I].SALA);
                       Console.SetCursorPosition(48, LIN);
                       Console.Write("{0,5:0.00}", ALUNO[I].MEDIA);
                       LIN++;

                   }


                   Console.SetCursorPosition(0, LIN);
                   Console.WriteLine();
                   Console.Write("Tecle algo para encerrar...");
                   Console.ReadKey();
               
               
               


              



          


        
        
        
        }
    }
}
