using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ap2_trabalho
{
    public class Campeonato
    {
        public string? NomeCampeonato;

        public void IniciarPartida(Equipe e1, Equipe e2)
        {
            Console.Clear();
            Console.Write($"click a tecla (ENTER) para iniciar a equipe 1: {e1.NomeEquipe}");
            Console.WriteLine(" ");
            Console.ReadLine();
            int num = 1;
            foreach (var jogador in e1.Jogadores)
            {
                jogador.Jogar();
                Console.WriteLine($"jogador {num}, nickname: {jogador.Nickname}, fez {jogador.Pontos} pontos.");
                Thread.Sleep(1000);
                num++;
            }
            Console.WriteLine(" ");

            Console.WriteLine($"click a tecla (ENTER) para iniciar a equipe 2: {e2.NomeEquipe}");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"iniciou a equipe 2: {e2.NomeEquipe}");
            num = 6;
            foreach (var jogador in e2.Jogadores)
            {

                jogador.Jogar();
                Console.WriteLine($"jogador {num}, nickname: {jogador.Nickname}, fez {jogador.Pontos} pontos.");
                Thread.Sleep(1000);
                num++;
            }
            Console.WriteLine(" ");
            Console.WriteLine("click a tecla (ENTER) para voltar ao menu");
            Console.ReadKey();
        }
        public void Classificacao(Equipe e1, Equipe e2)
        {

            int pontosEquipe1 = e1.PontosTotal(e1);
            int pontosEquipe2 = e2.PontosTotal(e2);

            if (pontosEquipe1 > pontosEquipe2)
            {
                Console.WriteLine($"_____Nome do Campeonato {NomeCampeonato}_____");
                Console.WriteLine($"Equipe: {e1.NomeEquipe}, Pontos: {pontosEquipe1}");
                Console.WriteLine($"Nickname 1: {e1.Jogadores[0].Nickname}, Postos {e1.Jogadores[0].Pontos}.");
                Console.WriteLine($"Nickname 2: {e1.Jogadores[1].Nickname}, Postos {e1.Jogadores[1].Pontos}.");
                Console.WriteLine($"Nickname 3: {e1.Jogadores[2].Nickname}, Postos {e1.Jogadores[2].Pontos}.");
                Console.WriteLine($"Nickname 4: {e1.Jogadores[3].Nickname}, Postos {e1.Jogadores[3].Pontos}.");
                Console.WriteLine($"Nickname 5: {e1.Jogadores[4].Nickname}, Postos {e1.Jogadores[4].Pontos}.");
            }
            else
            {
                Console.WriteLine($"_________Nome do Campeonato {NomeCampeonato}_______");
                Console.WriteLine(" ");
                Console.WriteLine($"Nome da Equipe: {e2.NomeEquipe}, Pontos: {pontosEquipe2}");
                Console.WriteLine("_________________________________________");
                Console.WriteLine($"Nickname 6: {e2.Jogadores[0].Nickname}, Postos {e2.Jogadores[0].Pontos}.");
                Console.WriteLine($"Nickname 7: {e2.Jogadores[1].Nickname}, Postos {e2.Jogadores[1].Pontos}.");
                Console.WriteLine($"Nickname 8: {e2.Jogadores[2].Nickname}, Postos {e2.Jogadores[2].Pontos}.");
                Console.WriteLine($"Nickname 9: {e2.Jogadores[3].Nickname}, Postos {e2.Jogadores[3].Pontos}.");
                Console.WriteLine($"Nickname 10: {e2.Jogadores[4].Nickname}, Postos {e2.Jogadores[4].Pontos}.");
            }
            Console.WriteLine(" ");
            Console.WriteLine("click a tecla (ENTER) para voltar ao menu");
            Console.ReadKey();
        }
        public void ZerarPontos(Equipe equipe)
        {
            int zerar = 0;
            foreach (var jogador in equipe.Jogadores)
            {
                jogador.Pontos = zerar;
            }
        }
    }
}