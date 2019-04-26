using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;


namespace Trestlebridge.Models.Equipment
{
  public class ChooseMeatProcessor
  {

    public static void CollectInput(Farm farm)
    {
      var list = farm.CreateFacilitiesList();
      for (int i = 0; i < list.Count; i++)
      {
        if (list[i][0].GetType().Name != "GrazingField" && list[i][0].GetType().Name != "ChickenHouse")
        {
          list.RemoveAt(i);
          i--;
        }
      }

      for (int i = 0; i < list.Count; i++)
      {
        Console.WriteLine($"{i}  {list[i][0].GetType().Name}");

      }
      Console.ReadLine();
    }
  }
}