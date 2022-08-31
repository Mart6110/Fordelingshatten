using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordelingshatten
{
    class DistributionHat
    {
        enum distribution
        {
            Gryffindor,
            Hufflepuff,
            Ravenclaw,
            Slytherin
        }

        public DistributionHat()
        {
            // The random number that determents what house you are sorted into.
            Random rnd = new Random();
            int distributionNumber = rnd.Next(0, 4);

            int gryffindor = (int)distribution.Gryffindor;
            int hufflepuff = (int)distribution.Hufflepuff;
            int ravenclaw = (int)distribution.Ravenclaw;
            int slytherin = (int)distribution.Slytherin;

            // I make an if statement to see what house im sorted into.
            if (gryffindor == distributionNumber)
            {
                Console.WriteLine((distribution)0 + " - for de modige og stærke");
            }
            else if (hufflepuff == distributionNumber)
            {
                Console.WriteLine((distribution)1 + " - for de loyale og tapre");
            }
            else if (ravenclaw == distributionNumber)
            {
                Console.WriteLine((distribution)2 + " - for de vidbegærlige og intelligente");
            }
            else if (slytherin == distributionNumber)
            {
                Console.WriteLine((distribution)3 + " - for de snedige, viljefaste og som ikke skyr noget for at nå deres mål");
            }
            // We should never see this msg, but just to make sure if something went wrong, and you are not a wizard.
            else
            {
                Console.WriteLine("Du er en muggle");
            }
        }
    }
}
