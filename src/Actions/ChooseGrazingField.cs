using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Console.Clear();
            try
            {
                for (int i = 0; i < farm.GrazingFields.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Grazing Field  ");
                }

                // Console.WriteLine ();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the animal where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());

                farm.GrazingFields[choice - 1].AddResource(animal);

            }
            catch (ArgumentOutOfRangeException )
            {

                Console.WriteLine("There is no facility to house this animal");
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }

    }
}