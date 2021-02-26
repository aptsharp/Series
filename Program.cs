using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Series - POO");

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                       //ListarSeries();
                        break;
                    case "2":
                       // InserirSerie();
                        break;
                    case "3":
                       //AtualizarSerie();
                        break;
                    case "4":
                        //ExcluirSerie();
                        break;
                    case "5":
                       // VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = ObterOpcaoUsuario();

            }

            Console.WriteLine("FIM!");
        }

        /*

        private static void VisualizarSerie()
        {
            throw new NotImplementedException();
        }

        private static void ExcluirSerie()
        {
            throw new NotImplementedException();
        }

        private static void AtualizarSerie()
        {
            throw new NotImplementedException();
        }

        private static void InserirSerie()
        {
            throw new NotImplementedException();
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar series");

            var lista = repositorio.List();

            if (lista.count == 0)
            {
                Console.WriteLine("vazio!");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0}: {1}", serie.RetornaPorId(), serie.retornaTitulo());
            }
        }

        */

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();

            Console.WriteLine("Menu: ");

            Console.WriteLine("1 - Listar series");
            Console.WriteLine("2 - Inserir nova serie");
            Console.WriteLine("3 - Atualizar serie");
            Console.WriteLine("4 - Excluir serie");
            Console.WriteLine("5 - Visualizar todas as Series");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
