using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
  public class ChooseChickenHouse
  {
    public static void CollectInput(Farm farm, int amount)
    {
      Console.Clear();

      while (amount > 0)
      {
        try
        {
          for (int i = 0; i < farm.ChickenHouses.Count; i++)
          {
            Console.WriteLine($"{i + 1}. Chicken House has {farm.ChickenHouses[i].ChickensCount.Count()} chickens");
          }
          Console.WriteLine();
          Console.WriteLine($"Place the chicken/s where?");

          Console.Write("> ");
          int choice = Int32.Parse(Console.ReadLine());
          Console.WriteLine($"How many?");

          int amountToAdd = Int32.Parse(Console.ReadLine());
          if (amountToAdd > amount)
          {
            Console.WriteLine($"Only have {amount} left to add");
          }
          else
          {
            for (int i = 0; i < amountToAdd; i++)
            {
              farm.ChickenHouses[choice - 1].AddResource(new Chicken());
            }
            amount -= amountToAdd;
          }
        }
        catch (ArgumentOutOfRangeException)
        {

          Console.WriteLine("There is no facility to house this animal");
          Console.ReadLine();
        }
      }
    }
  }
}