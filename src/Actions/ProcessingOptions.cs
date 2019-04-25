// using System;
// using System.Collections.Generic;
// using Trestlebridge.Interfaces;
// using Trestlebridge.Models;
// using Trestlebridge.Models.Animals;
// using Trestlebridge.Models.Facilities;

// namespace Trestlebridge.Actions
// {
//   public class ProcessingOptions
//   {
//     public static void CollectInput(Farm farm)
//     {
//       Console.WriteLine("1. Seed Harvester");
//       Console.WriteLine("2. Meat Processor");
//       Console.WriteLine("3. Egg Gatherer");
//       Console.WriteLine("4. Composter");
//       Console.WriteLine("5. Feather Harvester");

//       Console.WriteLine();
//       Console.WriteLine("Choose equipment to use.");

//       Console.Write("> ");
//       string choice = Console.ReadLine();
//       switch (choice)
//       {
//         case "1":
//           ChooseChickenHouse.CollectInput(farm, amount);
//           break;
//         case "2":

//           ChooseGrazingField.CollectInput(farm, new Cow(), amount);

//           break;
//         case "3":

//           ChooseDuckHouse.CollectInput(farm, amount);

//           break;
//         case "4":

//           ChooseGrazingField.CollectInput(farm, new Goat(), amount);

//           break;
//         case "5":


//           ChooseGrazingField.CollectInput(farm, new Ostrich(), amount);

//           break;
//         case "6":


//           ChooseGrazingField.CollectInput(farm, new Pig(), amount);

//           break;
//         case "7":


//           ChooseGrazingField.CollectInput(farm, new Sheep(), amount);

//           break;
//         default:
//           Console.WriteLine($"{choice} Is not a valid input!");

//           break;
//       }










//     }
//   }

// }