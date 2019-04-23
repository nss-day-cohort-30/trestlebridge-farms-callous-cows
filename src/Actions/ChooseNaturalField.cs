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
            Console.Clear();
            try
            {
                for (int i = 0; i < farm.NaturalFields.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Natural Field has {farm.NaturalFields[i].SeedsCount.Count()} rows of plants");
                }
                if (seed.GetType().Name != "sesame")
                {
                    Console.WriteLine(seed.GetType().Name);
                }
                Console.WriteLine();

                Console.WriteLine($"Place the seeds where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());

                farm.NaturalFields[choice - 1].AddResource(seed);
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

        internal static void CollectInput(Farm seed, Sesame sesame)
        {
            throw new NotImplementedException();
        }
    }
}