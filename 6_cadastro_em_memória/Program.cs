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
            Console.Write("Opção: ");

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
                Console.ReadLine();
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine($"#ID {serie.getId()}: - {serie.getTitulo()}",serie.getExcluido()?"Excluido":"");
            }

            Console.ReadLine();

        }

        private static void InserirSerie()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Inserir nova série");

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}: - {1}", i, Enum.GetName(typeof(Genero),i));
            }

            Console.WriteLine();

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero=int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da série: ");
            string entradaTitulo=Console.ReadLine();

            Console.Write("Digite o ano de início da série: ");
            int entradaAno=int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da série: ");
            string entradaDescricao=Console.ReadLine();

            Serie novaSerie=new Serie(id:repositorio.ProximoId(),
                                      genero:(Genero)entradaGenero,
                                      titulo:entradaTitulo,
                                      ano:entradaAno,
                                      descricao:entradaDescricao);

            repositorio.Inserir(novaSerie);

            Console.WriteLine("Série inserida.");
        }

        private static void AlualizarSerie()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Atualizar a série");
            Console.Write("Digite o ID da série: ");
            int indiceSerie=int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}: - {1}", i, Enum.GetName(typeof(Genero),i));
            }

            Console.WriteLine();

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero=int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da série: ");
            string entradaTitulo=Console.ReadLine();

            Console.Write("Digite o ano de início da série: ");
            int entradaAno=int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da série: ");
            string entradaDescricao=Console.ReadLine();

            Serie atualizaSerie=new Serie(id:indiceSerie,
                                      genero:(Genero)entradaGenero,
                                      titulo:entradaTitulo,
                                      ano:entradaAno,
                                      descricao:entradaDescricao);

            repositorio.Atualizar(indiceSerie,atualizaSerie);

            Console.WriteLine("Série atualizada.");
        }

        private static void ExcluirSerie()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Excluir a série");
            Console.Write("Digite o ID da série: ");
            int indiceSerie=int.Parse(Console.ReadLine());

            repositorio.Excluir(indiceSerie);

            Console.WriteLine("Série excluida.");
        }

        private static void VisualizarSerie()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Visualizar a série");
            Console.Write("Digite o ID da série: ");
            int indiceSerie=int.Parse(Console.ReadLine());

            var serie=repositorio.getId(indiceSerie);

            Console.WriteLine(serie);

            Console.ReadLine();
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
