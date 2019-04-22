using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class PurchaseSeeds {
        public static void CollectInput (Farm seed) {
            Console.WriteLine ("1. Sesame");
            Console.WriteLine ("2. Sunflower");
            Console.WriteLine ("3. Wildflower");

            Console.WriteLine ();
            Console.WriteLine ("What are you buying today?");

            Console.Write ("> ");
            string choice = Console.ReadLine ();

            switch (Int32.Parse(choice))
            {
                case 1:
                    // ChooseGrazingField.CollectInput(seed, new Sesame());
                    break;
                case 2:
                    // ChooseGrazingField.CollectInput(seed, new Sunflower());
                    break;
                case 3:
                    // CreateFacility.CollectInput(seed, new Wildflower());
                    break;

            }
        }
    }
}