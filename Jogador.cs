using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ap2_trabalho
{
    public class Jogador
    {
        public string Nome = "bot";
        public string Nickname = "bot";
        public int Pontos = 0;

        public void Jogar()
        {
            Random random = new Random();
            Pontos += random.Next(1, 101);
        }
    }

}