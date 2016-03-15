using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_M2C1_6
{
    class Program
    {
        public static void adicionarFilme(ref System.Collections.Generic.List<Filme> filme)
        {
            Console.WriteLine("Digite o código do Filme");
            string cod = Console.ReadLine();

            Console.WriteLine("Digite o título do Filme");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite a categoria do Filme");
            string categoria = Console.ReadLine();

            Console.WriteLine("Digite o tamanho físico do Filme");
            decimal tamanho = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o diretor do Filme");
            string diretor = Console.ReadLine();

            Console.WriteLine("Digite o ator principal do Filme");
            string ator = Console.ReadLine();

            Console.WriteLine("Digite a atriz principal do Filme");
            string atriz = Console.ReadLine();

            filme.Add(new Filme(cod, titulo, categoria, tamanho, diretor, ator, atriz));
        }

        public static void adicionarMusica(ref System.Collections.Generic.List<Musica> musica)
        {
            Console.WriteLine("Digite o código da Música");
            string cod = Console.ReadLine();
            
            Console.WriteLine("Digite o título da Música");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite a categoria da Música");
            string categoria = Console.ReadLine();

            Console.WriteLine("Digite o tamanho físico da Música");
            decimal tamanho = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o artista da Música");
            string artista = Console.ReadLine();

            Console.WriteLine("Digite os segundos da Música");
            int segundos = int.Parse(Console.ReadLine());

            musica.Add(new Musica(cod, titulo, categoria, tamanho, artista, segundos));
        }

        public static void listarFilmes(System.Collections.Generic.List<Filme> filme)
        {
            for (int i = 0; i < filme.Count; i++)
            {
                Console.WriteLine("\n{0} - {1} | Categ. {2} | Tam. Físico {3} | Diretor {4} | Ator {5} | Atriz {6} |", filme[i].codigo, filme[i].nome, filme[i].categoria, 
                                                                                                                     filme[i].tamanho, filme[i].nomeDiretor, filme[i].atorPrincipal, filme[i].atrizPrincipal);
            }
        }

        public static void listarMusicas(System.Collections.Generic.List<Musica> musica)
        {
            for (int i = 0; i < musica.Count; i++)
            {
                Console.WriteLine("\n{0} - {1} | Categ. {2} | Tam. Físico {3} | Artista {4} | Minutos {5} |", musica[i].codigo, musica[i].nome, musica[i].categoria,
                                                                                                                     musica[i].tamanho, musica[i].artista, musica[i].segundos);
            }
        }

        static void Main(string[] args)
        {

            System.Collections.Generic.List<Filme> filme = new System.Collections.Generic.List<Filme>();
            System.Collections.Generic.List<Musica> musica = new System.Collections.Generic.List<Musica>();
   
            string menu = "";

            menu += "1 - Adicionar Filme\n";
            menu += "2 - Musica Filme\n";
            menu += "3 - Listar Filmes\n";
            menu += "4 - Listar Musicas\n";
            menu += "5 - Sair";

            int opc = 0;
            while (opc < 5)
            {
                Console.WriteLine(menu);
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                            adicionarFilme(ref filme);
                            break;  
                    case 2:
                            adicionarMusica(ref musica);
                            break;
                    case 3:
                            listarFilmes(filme);
                            break;
                    case 4:
                            listarMusicas(musica);
                            break;
                }                
            }
    }

}
}
