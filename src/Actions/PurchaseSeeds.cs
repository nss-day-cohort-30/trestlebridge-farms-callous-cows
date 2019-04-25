using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
  public class PurchaseSeeds
  {
    public static void CollectInput(Farm farm)
    {
      Console.WriteLine("1. Sesame");
      Console.WriteLine("2. Sunflower to natural field");
      Console.WriteLine("3. Sunflower to plowable field");
      Console.WriteLine("4. Wildflower");

      Console.WriteLine();
      Console.WriteLine("What are you buying today?");

      Console.Write("> ");
      string choice = Console.ReadLine();

       Console.WriteLine("How many?");
            Console.Write("> ");
            int amount = Convert.ToInt32(Console.ReadLine());


      switch (choice)
      {
        case "1":

          ChoosePlowedField.CollectInput(farm, new Sesame(), amount);

          break;
        case "2":
          for (int i = 0; i < amount; i++)
                    {
         // ChooseNaturalField.CollectInput(farm, new Sunflower());
                    }
          break;
        case "3":
          for (int i = 0; i < amount; i++)
                    {
          //ChoosePlowedField.CollectInput(farm, new Sunflower());
                    }
          break;
        case "4":
          for (int i = 0; i < amount; i++)
                    {
          //ChooseNaturalField.CollectInput(farm, new Wildflower());
                    }
          break;
           default:
                    Console.WriteLine($"{choice} Is not a valid input");
                    break;
      }
    }
  }
}