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
    public static void CollectInput<T>(Farm farm, T seed, int amount)
    {
      while (amount > 0)
      {
        try
        {
          for (int i = 0; i < farm.PlowedFields.Count; i++)
          {
            var groupedSeeds = farm.PlowedFields[i].SeedsCount.GroupBy(
            currentSeed => currentSeed.Type
   );

            var seedString = "";
            foreach (var currentSeedGroup in groupedSeeds)
            {
              seedString += currentSeedGroup.Count() + " " + currentSeedGroup.Key + ",";
            };
            Console.WriteLine($"Plowed Field ({seedString})");
          }

          Console.WriteLine();
          Console.WriteLine($"Place the sesame/s where?");

          Console.Write("> ");
          int choice = Int32.Parse(Console.ReadLine());
          Console.WriteLine($"How many");

          int amountToAdd = Int32.Parse(Console.ReadLine());
          if (amountToAdd > amount)
          {
            Console.WriteLine($"Only have {amount} left to add");
          }
          else
          {
            for (int i = 0; i < amountToAdd; i++)
            {
              dynamic plowableSeed = Activator.CreateInstance(seed.GetType());
              farm.PlowedFields[choice - 1].AddResource(plowableSeed);
            }
            amount -= amountToAdd;
          }
        }
        catch (ArgumentOutOfRangeException)
        {

          Console.WriteLine("There is no field to plant this seed!");
          Console.ReadLine();
        }


        /*
            Couldn't get this to work. Can you?
            Stretch goal. Only if the app is fully functional.
         */
        // farm.PurchaseResource<IGrazing>(animal, choice);

      }
    }
  }
}