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
            Random rnd = new Random();
            int distributionNumber = rnd.Next(0, 4);

            int gryffindor = (int)distribution.Gryffindor;
            int hufflepuff = (int)distribution.Hufflepuff;
            int ravenclaw = (int)distribution.Ravenclaw;
            int slytherin = (int)distribution.Slytherin;

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
            else
            {
                Console.WriteLine("Du er en muggle");
            }
        }
    }
}
