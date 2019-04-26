using System;
using System.Collections;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Equipment
{
    public class ChooseMeatProcessor
    {
        public static void CollectInput(Farm farm)
        {
            List<IList> list = farm.CreateFacilitiesList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i][0].GetType().Name != "GrazingField" && list[i][0].GetType().Name != "ChickenHouse")
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine("Select facility type for processing");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}  {list[i][0].GetType().Name}");

            }
            int choice = Convert.ToInt32(Console.ReadLine());

            List<GrazingField> grazingAnimalsWithMeat = new List<GrazingField>();

            foreach (var item in list[choice - 1])
            {
                if (item.GetType().Name == "GrazingField")
                {
                    GrazingField grazingFieldToCheck = (GrazingField)(item);
                    foreach (var animal in grazingFieldToCheck.AnimalsCount)
                    {
                        if (animal is IMeatProducing)
                        {
                            grazingAnimalsWithMeat.Add(grazingFieldToCheck);
                            break;
                        }
                    }
                }
                else if (item.GetType().Name == "ChickenHouse")
                {
                    ChickenHouse datThing = (ChickenHouse)(item);
                }
            }
            Console.WriteLine("Select which facility for processing");
            for (int i = 0; i < grazingAnimalsWithMeat.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {grazingAnimalsWithMeat[i]}");
            }
            int facilityChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How Many?");
            int amountToProcess = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < grazingAnimalsWithMeat[facilityChoice].AnimalsCount.Count; i++)
            {
//               if(AnimalsCount[i] is Cow){
// //store all the animals in a hashset . display all the animals for our choices. match the hashset key for the type we decide to
// //to delete.
//               }
            }



        }
    }
}