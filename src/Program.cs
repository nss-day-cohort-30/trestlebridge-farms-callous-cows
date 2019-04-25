using System;
using System.Linq;
using Trestlebridge.Actions;
using Trestlebridge.Models;

namespace Trestlebridge
{
  class Program
  {
    static void DisplayBanner()
    {
      // Console.Clear();
      Console.WriteLine();
      Console.WriteLine(@"
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
        |T||r||e||s||t||l||e||b||r||i||d||g||e|
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
                    |F||a||r||m||s|
                    +-++-++-++-++-+");
      Console.WriteLine();
    }

    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.White;
      Console.BackgroundColor = ConsoleColor.DarkMagenta;

      Farm Trestlebridge = new Farm();

      bool flag = true;
      while (flag)
      {
        DisplayBanner();
        Console.WriteLine("1. Create Facility");
        Console.WriteLine("2. Purchase Animals");
        Console.WriteLine("3. Purchase Seeds");
        Console.WriteLine("4. Processing");
        Console.WriteLine("5. Display Farm Status");
        Console.WriteLine("6. Exit");
        Console.WriteLine();

        Console.WriteLine("Choose a FARMS option");
        Console.Write("> ");
        string option = Console.ReadLine();

        switch (option)
        {
          case "1":
            DisplayBanner();
            CreateFacility.CollectInput(Trestlebridge);
            break;
          case "2":
            DisplayBanner();
            PurchaseStock.CollectInput(Trestlebridge);
            break;
          case "3":
            DisplayBanner();
            PurchaseSeeds.CollectInput(Trestlebridge);
            break;
          case "4":
            DisplayBanner();
            // ProcessingOptions.CollectInput(Trestlebridge);
            break;
          case "5":
            // DisplayBanner();
            Console.WriteLine(Trestlebridge);
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Press return key to go back to main menu.");
            Console.ReadLine();
            break;
          case "6":
            Console.WriteLine("Today is a great day for farming");
            flag = false;
            break;
          default:
            Console.WriteLine($"{option} Is not a valid input");
            break;
        }
      }
    }
  }
}
