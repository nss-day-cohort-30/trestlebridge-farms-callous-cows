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
    public static void CollectInput<T>(Farm farm, T animal, int amount)
    {
      Console.Clear();
      while (amount > 0)
      {
        try
        {
          for (int i = 0; i < farm.GrazingFields.Count; i++)
          {
            var groupedAnimals = farm.GrazingFields[i].AnimalsCount.GroupBy(
             currentAnimal => currentAnimal.Type);


            var animalsString = "";
            foreach (var currentAnimalGroup in groupedAnimals)
            {
              animalsString += currentAnimalGroup.Key + currentAnimalGroup.Count() + ",";

            };
            Console.WriteLine($"{i + 1}. Grazing Field has ({animalsString}) animals.");
          }

          Console.WriteLine($"Place the animal where?");

          Console.Write("> ");
          int choice = Int32.Parse(Console.ReadLine());
          Console.WriteLine($"How many?");

          int amountToAdd = Int32.Parse(Console.ReadLine());
          if (amountToAdd > amount)
          {
            Console.WriteLine($"Only have {amount} left to add.");
          }
          else
          {
            dynamic animalChoice = Activator.CreateInstance(animal.GetType());
            // IGrazing animalChoice = (IGrazing)Activator.CreateInstance(typeof(T), new object[] { });


            for (int i = 0; i < amountToAdd; i++)
            {
              farm.GrazingFields[choice - 1].AddResource(animalChoice);
              amount -= amountToAdd;
            }

          }
        }
        catch (ArgumentOutOfRangeException)
        {

          Console.WriteLine("There is no facility to house this animal");
        }
      }
    }

  }
}