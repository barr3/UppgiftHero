using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftHero
{
    class Program
    {
        static void Main(string[] args)
        {

            Hero hero = new Hero("Harald Grande", 100, 100, 200, 100);
            Enemy enemy = new Enemy("Vilgefortz", 50, 120, 250, 100);

            hero.Attack(enemy);

            Console.ReadLine();
        }
    }
}
