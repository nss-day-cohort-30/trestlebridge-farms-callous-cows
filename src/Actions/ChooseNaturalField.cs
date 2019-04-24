using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, INatural seed)
        {
            Console.WriteLine("we got here");
            Console.Clear();
            try
            {
                for (int i = 0; i < farm.NaturalFields.Count; i++)
                {

                    var groupedSeeds = farm.NaturalFields[i].SeedsCount.GroupBy(
           currentSeed => currentSeed.Type
             );
                    Console.WriteLine(groupedSeeds.Count());
                    var seedString = "";
                    foreach (var currentSeedGroup in groupedSeeds)
                    {
                        seedString += currentSeedGroup.Count() + " " + currentSeedGroup.Key + ",";
                        Console.WriteLine(currentSeedGroup.Count());
                    };
                    Console.WriteLine($"Natural Field ({seedString})");
                }

                Console.WriteLine();

                Console.WriteLine($"Place the seeds where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());

                farm.NaturalFields[choice - 1].AddResource(seed);
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("There is no field to plant this seed");
            }


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }

        internal static void CollectInput(Farm seed, Sesame sesame)
        {
            throw new NotImplementedException();
        }
    }
}