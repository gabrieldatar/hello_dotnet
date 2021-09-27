using System;

namespace _4_revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1- Inserir novo aluno.");
            Console.WriteLine("2- Listar alunos.");
            Console.WriteLine("3- Calcular média geral.");
            Console.WriteLine("X- Sair.");
            Console.Write("Opção: ");
            Console.WriteLine();

            string opcaoUsuario=Console.ReadLine();
            
            while(opcaoUsuario.ToUpper()!= "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        // -adicionar aluno
                        break;
                    case "2":
                        // listar aluno
                        break;
                    case "3":
                        // calcular a media geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1- Inserir novo aluno.");
                Console.WriteLine("2- Listar alunos.");
                Console.WriteLine("3- Calcular média geral.");
                Console.WriteLine("X- Sair.");
                Console.Write("Opção: ");
                Console.WriteLine();

                opcaoUsuario=Console.ReadLine();

            }
        }
    }
}
