using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_05_Cadastros
{
    class Program
    {
        struct CADASTRO
        {
            public string nome;
            public string telefone;
            public string data;
            public string cidade;
            public string estado;

        }

        struct FILME
        {
            public string titulo;
            public string duracao;
            public string data;
            public string Hora_i;
            public string Hora_f;

        }


        struct MEDICO
        {
            public string matricula;
            public string Nome;
            public string Hora_inicial;
            public string Hora_final;
            public string esp;
        }







        static void Main(string[] args)
        {
            int I,J,X,Y;

            CADASTRO[] DADOS = new CADASTRO[5];


            for (I = 0; I <= 0; I++)
            {
                Console.Write("DADOS PESSOAIS ");
                Console.WriteLine();
                Console.Write("Nome :   ");
                DADOS[I].nome = Console.ReadLine();

                Console.Write("Telefone :   ");
                DADOS[I].telefone = Console.ReadLine();

                Console.Write("Aniversario :   ");
                DADOS[I].data = Console.ReadLine();

                Console.Write("Cidade :   ");
                DADOS[I].cidade = Console.ReadLine();

                Console.Write("Estado :   ");
                DADOS[I].estado = Console.ReadLine();

            }

            //FILME EM CARTAZ

           FILME[] FILM = new FILME [5];


            for (J = 0; J <= 0; J++)
            {
                Console.WriteLine();
                Console.Write("FILME EM CARTAZ ");
                Console.WriteLine();
                Console.Write("Titulo  :   ");
                FILM[J].titulo= Console.ReadLine();

                Console.Write("Duracao :   ");
                FILM[J].duracao = Console.ReadLine();

                Console.Write("Secoes  :   ");
                Console.WriteLine();

                Console.Write("Horario Inicio :  ");
                FILM[J].Hora_i=Console.ReadLine();

                Console.Write("Horario Fim :  ");
                FILM[J].Hora_f = Console.ReadLine();

            }

            //MEDICO PLANTAO 

            MEDICO[] MEDIC = new MEDICO[3];


            for (X = 0; X <=2 ; X++)
            {

               
                Console.WriteLine();
                Console.Write("MEDICOS DE PLANTAO ");
                Console.WriteLine();
                Console.Write("Matricula :   ");
                MEDIC[X].matricula= Console.ReadLine();

                Console.Write("Nome :   ");
                MEDIC[X].Nome = Console.ReadLine();

                Console.Write("Horario Inicial :  ");
                MEDIC[X].Hora_inicial= Console.ReadLine();

                Console.Write("Horario Final:  ");
                MEDIC[X].Hora_final = Console.ReadLine();

                Console.Write("Especialidade :  ");
                MEDIC[X].esp = Console.ReadLine();



            }




            Console.ReadKey();

        }
    }
}
