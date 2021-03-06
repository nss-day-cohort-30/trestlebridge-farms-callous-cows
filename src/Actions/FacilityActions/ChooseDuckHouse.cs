using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
  public class ChooseDuckHouse
  {
    public static void CollectInput(Farm farm, int amount)
    {
      Console.Clear();

      while (amount > 0)
      {
        try
        {
          for (int i = 0; i < farm.DuckHouses.Count; i++)
          {
            Console.WriteLine($"{i + 1}. Duck House has ({farm.DuckHouses[i].DucksCount.Count()} ducks)");
          }

          Console.WriteLine();
          Console.WriteLine($"Place the animal where?");

          Console.Write("> ");
          int choice = Int32.Parse(Console.ReadLine());
          Console.WriteLine($"How many?");

          int amountToAdd = Int32.Parse(Console.ReadLine());
          if (amountToAdd > amount)
          {
            Console.WriteLine($"Only have {amount} left to add!");
          }
          else
          {
            for (int i = 0; i < amountToAdd; i++)
            {
              farm.DuckHouses[choice - 1].AddResource(new Duck());
            }
            amount -= amountToAdd;
          }
        }
        catch (ArgumentOutOfRangeException)
        {
          Console.WriteLine("There is no facility to house this animal");
          Console.ReadLine();
          break;
        }
         catch (FormatException)
        {
          Console.WriteLine("Invalid Input!");
           Console.ReadLine();
          break;
        }

      }
    }
  }
}