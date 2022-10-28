using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbr, i, cmpt = 0;
            
            Console.Write("Enter un nombre : ");
            nbr = int.Parse(Console.ReadLine());

            for (i = 1; i <= nbr; i++)
            {

                if (nbr % i == 0)
                {
                    cmpt++;
                }
            }
                if(cmpt > 2)
                {
                    Console.WriteLine(+nbr + " est n'a pas nombre Premier");
                }
                else
                {
                    Console.WriteLine(+nbr + " est un Nombre Premier");
                }
            Console.ReadLine();
        }
    }
}
