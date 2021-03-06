using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput<T>(Farm farm, T seed, int amount)
        {
            while (amount > 0)
            {
                try
                {
                    for (int i = 0; i < farm.NaturalFields.Count; i++)
                    {
                        var groupedSeeds = farm.NaturalFields[i].SeedsCount.GroupBy(
                        currentSeed => currentSeed.Type
               );

                        var seedString = "";

                        foreach (var currentSeedGroup in groupedSeeds)
                        {
                            seedString += currentSeedGroup.Count() + " " + currentSeedGroup.Key + ",";

                        };
                        Console.WriteLine($" {i + 1}: Natural Field ({seedString})");

                    }

                    Console.WriteLine();
                    Console.WriteLine($"Place the seed/s where?");

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
                            dynamic naturalSeed = Activator.CreateInstance(seed.GetType());
                            farm.NaturalFields[choice - 1].AddResource(naturalSeed);
                            amount -= amountToAdd;
                        }
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("There is no field to plant this seed!");
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