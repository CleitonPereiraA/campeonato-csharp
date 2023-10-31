using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ap2_trabalho
{
    public class Equipe : Program
    {
        public string NomeEquipe = "nao definido";
        public List<Jogador> Jogadores;

        public string AddNome(int num)
        {
            if (num <= 5)
                Console.WriteLine($"jogador de numero: {num}, da equipe 1.");
            else
                Console.WriteLine($"jogador de numero: {num}, da equipe 2.");

            Console.Write("digite seu nome completo: ");
            return Console.ReadLine();
        }

        public string AddNick()
        {
            Console.Write("digite seu nickname: ");
            return Console.ReadLine();
        }

        public int PontosTotal(Equipe e1e2)
        {
            int totalPonto = 0;
            foreach (var jogador in e1e2.Jogadores)
            {
                int Ponto = jogador.Pontos;
                totalPonto = totalPonto + Ponto;
            }
            return totalPonto;
        }
    }
}