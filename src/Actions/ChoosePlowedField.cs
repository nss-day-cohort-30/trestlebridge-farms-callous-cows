using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        public static void CollectInput(Farm farm, IPlowable seed)
        {
            Console.Clear();
            try
            {
                for (int i = 0; i < farm.PlowedFields.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Plowed Fields has {farm.PlowedFields[i].SeedsCount.Count()} rows of plants");
                }

                Console.WriteLine();

                // How can I output the type of seed chosen here?
                Console.WriteLine($"Place the seed where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());

                farm.PlowedFields[choice - 1].AddResource(seed);

            }
            catch (ArgumentOutOfRangeException )
            {

                Console.WriteLine("There is no field to plant this seed");
            }
            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}