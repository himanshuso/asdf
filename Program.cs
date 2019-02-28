using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CountrySide
    {
        static void Main()

        {

        }

        public void Run()
        {
            Alst = new Village("Alst", false);
            Scarton = new Village("scarton", false);
            Wessig = new Village("Wessig", true);

            Alst.distanceToEastVillage = 14;
            Alst.distanceToEastVillage = 19;
            Alst.west = Scarton;
            Alst.east = Wessig;

            Scarton.west = null;
            Scarton.west = null;

        }


        // Create the LinkedList to reflect the Map in the PowerPoint Instructions

        Village toronto;

        Village Hamilton;

        Village Alst;

        Village Wessig;

        Village winnipeg;

        Village United;

        Village Scarton;

        void CountrySide.TorontoVillage(Village CurrentVillage)

        {
            try
            {
                if (CurrentVillage.isAstrildgeHere)
                {
                    Console.WriteLine("I saw a Lion in {0}", CurrentVillage.VillageName);
                    Console.WriteLine("*******eaten by Lion!******");
                    return;
                }
            }
    }


        class Village

        {

            public Village(string _villageName, bool _isAHere)
            {

                isAstrildgeHere = _isAHere;

                VillageName = _villageName;

            }



            public Village west;

            public Village east;

            public string VillageName;

            public int distanceToNextVillage;

            public int distanceToPreviousVillage;

            public bool isAstrildgeHere;

            public int distanceToEastVillage { get; internal set; }
        }
    }
}
