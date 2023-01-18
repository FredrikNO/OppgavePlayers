using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppgavePlayers
{
    internal class Player
    {
        public string Name { get; private set; }
        public int Poeng { get; private set; }
        public Player(string name, int poeng)
        {
            Name= name;
            Poeng= poeng;
        }

        public void Play(Player player2)
        {
            var random = new Random();
            var winner = random.Next(1,3);
            if(winner == 1)
            {
                player2.Poeng--;
                Poeng++;
            }
            else
            {
                player2.Poeng ++;
                Poeng--;
            }
        }

        public void ShowNameAndPoints()
        {
            Console.WriteLine($"{Name} har {Poeng}");
        }
    }
}
