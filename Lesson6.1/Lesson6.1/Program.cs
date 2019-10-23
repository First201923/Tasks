using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            team[0] = new Player { Name = "Ronaldo", Number = 9 };
            team[1] = new Player { Name = "R. Baggio", Number = 10 };
            team[12] = new Player { Name = "Simeone", Number = 8 };
            Console.WriteLine($"{team[12].Name} {team[12].Number}");
            Console.ReadKey();
        }
    }
    class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }
    class Team
    {
        Player[] players = new Player[11];
        public Player this[int id]
        {
            get
            {
                if (id >= 0 && id < players.Length)
                    return players[id];
                else
                    return null ;
            }
            set
            {
                if (id >= 0 && id < players.Length)
                    players[id] = value;
            }
        }
    }
}
