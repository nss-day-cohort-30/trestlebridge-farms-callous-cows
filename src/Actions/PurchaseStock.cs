using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseStock
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Chicken");
            Console.WriteLine("2. Cow");
            Console.WriteLine("3. Duck");
            Console.WriteLine("4. Goat");
            Console.WriteLine("5. Ostrich");
            Console.WriteLine("6. Pig");
            Console.WriteLine("7. Sheep");

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
                        ChooseChickenHouse.CollectInput(farm, amount);
                    break;
                case "2":

                        ChooseGrazingField.CollectInput(farm, new Cow(), amount);

                    break;
                case "3":

                        ChooseDuckHouse.CollectInput(farm, new Duck(), amount);

                    break;
                case "4":

                        ChooseGrazingField.CollectInput(farm, new Goat(), amount);

                    break;
                case "5":


                        ChooseGrazingField.CollectInput(farm, new Ostrich(), amount);

                    break;
                case "6":


                        ChooseGrazingField.CollectInput(farm, new Pig(), amount);

                    break;
                case "7":


                        ChooseGrazingField.CollectInput(farm, new Sheep(), amount);

                    break;
                default:
                    Console.WriteLine($"{choice} Is not a valid input");

                    break;
            }
        }
    }
}