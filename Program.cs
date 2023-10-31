using System.Security.Cryptography.X509Certificates;
using ap2_trabalho;

public class Program
{
    public static void Main(string[] args)
    {
        string opcao;
        var menu = new Menu();
        var campeonato = new Campeonato();
        var equipe1 = new Equipe();
        var equipe2 = new Equipe();
        var j1 = new Jogador();
        var j2 = new Jogador();
        var j3 = new Jogador();
        var j4 = new Jogador();
        var j5 = new Jogador();
        var j6 = new Jogador();
        var j7 = new Jogador();
        var j8 = new Jogador();
        var j9 = new Jogador();
        var j10 = new Jogador();

        equipe1.Jogadores = new List<Jogador> { j1, j2, j3, j4, j5 };

        equipe2.Jogadores = new List<Jogador> { j6, j7, j8, j9, j10 };

        menu.Carregando();
        while (true)
        {
            Console.Clear();
            opcao = menu.MenuCampeonato();
            if (opcao == "1")
            {
                Console.Clear();
                Console.Write("qual e o nome da equipe 1: ");
                equipe1.NomeEquipe = Console.ReadLine();
                Console.WriteLine(" ");
                j1.Nome = equipe1.AddNome(1);
                j1.Nickname = equipe1.AddNick();
                j1.Pontos = 0;
                Console.WriteLine(" ");

                j2.Nome = equipe1.AddNome(2);
                j2.Nickname = equipe1.AddNick();
                j2.Pontos = 0;
                Console.WriteLine(" ");

                j3.Nome = equipe1.AddNome(3);
                j3.Nickname = equipe1.AddNick();
                j3.Pontos = 0;
                Console.WriteLine(" ");

                j4.Nome = equipe1.AddNome(4);
                j4.Nickname = equipe1.AddNick();
                j4.Pontos = 0;
                Console.WriteLine(" ");

                j5.Nome = equipe1.AddNome(5);
                j5.Nickname = equipe1.AddNick();
                j5.Pontos = 0;
                Console.Clear();

                Console.Write("qual e o nome da equipe 2: ");
                equipe2.NomeEquipe = Console.ReadLine();
                Console.WriteLine(" ");

                j6.Nome = equipe1.AddNome(6);
                j6.Nickname = equipe1.AddNick();
                j6.Pontos = 0;
                Console.WriteLine(" ");

                j7.Nome = equipe1.AddNome(7);
                j7.Nickname = equipe1.AddNick();
                j7.Pontos = 0;
                Console.WriteLine(" ");

                j8.Nome = equipe1.AddNome(8);
                j8.Nickname = equipe1.AddNick();
                j8.Pontos = 0;
                Console.WriteLine(" ");

                j9.Nome = equipe1.AddNome(9);
                j9.Nickname = equipe1.AddNick();
                j9.Pontos = 0;
                Console.WriteLine(" ");

                j10.Nome = equipe1.AddNome(10);
                j10.Nickname = equipe1.AddNick();
                j10.Pontos = 0;
                Console.WriteLine(" ");

                Console.Clear();
                Console.WriteLine("Carregando...");
                Thread.Sleep(800);

                Console.Clear();
                Console.WriteLine("Comcluido...");
                Thread.Sleep(400);
            }
            else if (opcao == "2")
            {
                campeonato.ZerarPontos(equipe1);
                campeonato.ZerarPontos(equipe2);
                Console.Clear();
                Console.Write("digite o nome do campeonato: ");
                campeonato.NomeCampeonato = Console.ReadLine();
                Console.Clear();
                campeonato.IniciarPartida(equipe1, equipe2);
            }
            else if (opcao == "3")
            {
                Console.Clear();
                campeonato.Classificacao(equipe1, equipe2);
            }
            else if (opcao == "4")
            {
                Console.Clear();
                Console.WriteLine("finalizando...");
                Thread.Sleep(600);
                Console.Clear();
                break;
            }
            else
            {

                Console.WriteLine("opcao invalida...");
                Thread.Sleep(750);
            }
        }
        Console.Clear();
        Console.WriteLine("finalizou com sucesso...");
        Thread.Sleep(700);
    }
}

