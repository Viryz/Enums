using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    enum Posts
    {
        Post1 = 100,
        Post2 = 300,
        Post3 = 500
    }

    static class Accauntant
    {
        static public bool AskForBonus(Posts worker, int hours)
        {
            if (hours > (int)worker)
                return true;
            else return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Posts worker = Posts.Post2;
            if (Accauntant.AskForBonus(worker, 303))
                Console.WriteLine("Give me money!!!");
            else Console.WriteLine("Okkkeeeeey");

            Console.ReadLine();
        }
    }
}
