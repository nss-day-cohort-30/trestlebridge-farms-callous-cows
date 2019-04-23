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


        public static void CollectInput(Farm farm, Chicken chicken)
        {
            Console.Clear();

            Console.WriteLine("How many?");
            Console.Write("> ");
            int option = Convert.ToInt32(Console.ReadLine());

            List<Chicken> chickens = new List<Chicken>();
            if (option > 1)
            {
                for (int i = 0; i < option; i++)
                {
                    chickens.Add(new Chicken());
                }
            }

            try
            {

                for (int i = 0; i < farm.ChickenHouses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Chicken House has {farm.ChickenHouses[i].ChickensCount.Count()} chickens");
                }

                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the animal where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());



                if (chickens.Count == 0)
                {
                    farm.ChickenHouses[choice - 1].AddResource(chicken);
                }
                else
                {
                    farm.ChickenHouses[choice - 1].AddResource(chickens);
                }

            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("There is no facility to house this animal");
            }

            // /*
            //     Couldn't get this to work. Can you?
            //     Stretch goal. Only if the app is fully functional.
            //  */
            // // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}