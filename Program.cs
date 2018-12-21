using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Devinez un nombre entre 1 et 50");
            int numb = 0;
            Random rand = new Random(); //Pour créer une variable aléatoire
            int r = rand.Next(50); //Créer une valeur aléatoire ou que l'on peut déteminer grace a la parenthese
            int i = 0;
            while (numb != r)
            {
                numb = int.Parse(Console.ReadLine());
                i++;
                if (numb == r)
                {
                    Console.WriteLine("Gagné vous avez fait " + i + " tentative-s");
                }
                else if (numb < 50)
                {
                    Console.WriteLine("Plus grand");
                }
                else if (numb > 0)
                {
                    Console.WriteLine("Plus petit");
                    break;
                }
                if (numb > 50)
                {
                    Console.WriteLine("Vous n'avez pas renseignez une valeur entre 1 et 50");
                }
            }

        }
    }
}
