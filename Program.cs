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
            Console.SetCursorPosition(10, 1); // Permet de positionner la couleur (x,y)
            Console.ForegroundColor = ConsoleColor.Blue; // Permet de mettre une couleur Back
            Console.BackgroundColor = ConsoleColor.White; // Permet de mettre une couleur Fore
            Console.Clear(); //.Clear() permet de réinitialisez la phrase
            while (numb != r)
            {
                numb = int.Parse(Console.ReadLine());
                i++;
                if (numb == r)
                {
                    Console.WriteLine("Devinez un nombre entre 1 et 50");
                    Console.WriteLine("Gagné vous avez fait " + i + " tentative-s");
                }
                else if (numb <= r && numb>0)
                {
                    Console.Clear();
                    Console.WriteLine("Devinez un nombre entre 1 et 50");
                    Console.WriteLine("Plus grand");

                }
                else if (numb >=r && numb<50)
                {
                    Console.Clear();
                    Console.WriteLine("Devinez un nombre entre 1 et 50");
                    Console.WriteLine("Plus petit");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Devinez un nombre entre 1 et 50");
                    Console.WriteLine("Vous n'avez pas renseignez une valeur entre 1 et 50");
                }
            }

        }
    }
}
