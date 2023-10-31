using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ap2_trabalho
{
    public class Menu
    {
        public string MenuCampeonato()
        {
            Console.WriteLine("opcao 1: adicionar os participantes");
            Console.WriteLine("opcao 2: nome do campeonato e ja iniciar");
            Console.WriteLine("opcao 3: ver classificacao");
            Console.WriteLine("opcao 4: fechar programa");

            Console.Write("opcao: ");
            return Console.ReadLine();
        }
        public void Carregando()
        {
            Console.Clear();
            Thread.Sleep(500);
            Console.WriteLine("Carregando:  0% (               )");
            Thread.Sleep(700);
            Console.Clear();

            Console.WriteLine("Carregando:  15% (..             )");
            Thread.Sleep(800);
            Console.Clear();

            Console.WriteLine("Carregando:  40% (......         )");
            Thread.Sleep(700);
            Console.Clear();

            Console.WriteLine("verificando: 75% (..........     )");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("verificando: 95% (.............  )");
            Thread.Sleep(600);
            Console.Clear();

            Console.WriteLine("Concluindo:  100%(...............)");
            Thread.Sleep(200);
            Console.Clear();
        }
    }

}