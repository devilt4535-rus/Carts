using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carts
{
    internal class Players
    {
        public void NumberOfPlayers()
        {
            Console.WriteLine("Введите количество игроков");
            string number = Console.ReadLine();
            bool numbe = int.TryParse(number, out var num);
            int card = 36 / num;
            Console.WriteLine(card);
        }
    }
}