using System;

namespace FilmesSeries
{
    class Program
    {
        static FilmeRepositorio repositorio = new FilmeRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarFilmes();
                        break;
                    case "2":
                        InserirFilme();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("MENU:");
            Console.WriteLine("1- Listar filmes");
            Console.WriteLine("2- Inserir novo filme");
            Console.WriteLine("3- Atualizar Filme");
            Console.WriteLine("4- Excluir filme");
            Console.WriteLine("5- Visualizar filme");
            Console.WriteLine("C- Limpar tela");                Console.WriteLine("X- Sair");

            Console.Write("Informe a opção desejada: ");
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static void ListarFilmes(){
            Console.WriteLine("Lista de Filmes");
            var lista = repositorio.Lista();
            
            if(lista.Count == 0){
                Console.WriteLine("Nenhum filme cadastrado.");
                return;
            }

            foreach(var filme in lista){
                if(!filme.retornaExcluido())
                    Console.WriteLine("{0}- {1}", filme.retornaId(), filme.retornaTitulo());
            }
        }

        private static void InserirFilme(){
            Console.WriteLine("Inserir novo filme");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1} ", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o título: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Informe a classificação: ");
            int entradaClassificacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o ano de lançamento: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a duração do filme: ");
            string entradaDuracao = Console.ReadLine();

            Filme novoFilme = new Filme(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        classificacao: entradaClassificacao,
                                        ano: entradaAno,
                                        duracao: entradaDuracao);
            repositorio.Insere(novoFilme);
        }
    }
}
