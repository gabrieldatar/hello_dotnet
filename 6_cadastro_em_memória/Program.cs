using System;

namespace _6_cadastro_em_memória
{
    class Program
    {
        static SerieRepositorio repositorio=new SerieRepositorio();

        private static string ObterOpcaoUsuario()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Lista com sua melhores séries!");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir noca série");
            Console.WriteLine("3- Atualizar nova serie");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("X- Sair");
            Console.WriteLine("----------------------------------");
            Console.Write("Opção");

            string opcao=Console.ReadLine().ToUpper();
            Console.WriteLine();
            
            return opcao;
        }

        private static void ListarSerie()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Listar séries");

            var lista=repositorio.Lista();

            if(lista.Count==0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine($"#ID {serie.getId()}: - {serie.getTitulo()}");
            }
        }

        private static void InserirSerie()
        {
            

        }

        private static void AlualizarSerie()
        {

        }

        private static void ExcluirSerie()
        {

        }

        private static void VisualizarSerie()
        {

        }

        static void Main(string[] args)
        {
            string opcaoUsuario=ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper()!="X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarSerie();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AlualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Opção invalida.");
                        break;
                }
                opcaoUsuario=ObterOpcaoUsuario();
            }

            Console.Clear();
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }
    }
}
