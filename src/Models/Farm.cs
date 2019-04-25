using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Models
{
  public class Farm
  {


        //go through all facility arrays ex grazingfields and check which are not empty.

        //return all non empty field types

        //check those arrays to see if any index contains a meat animal.

        //return that field at the index that has the meat and store it in a new array.

        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();
        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();

        public List<IList> CreateFacilitiesList()
        {
            List<IList> facilities = new List<IList>();
            if (GrazingFields.Count > 0)
            {
                facilities.Add(GrazingFields);
            }
            if (NaturalFields.Count > 0)
            {
                facilities.Add(NaturalFields);
            }
            if (ChickenHouses.Count > 0)
            {
                facilities.Add(ChickenHouses);
            }
            if (DuckHouses.Count > 0)
            {
                facilities.Add(DuckHouses);
            }
            if (PlowedFields.Count > 0)
            {
                facilities.Add(PlowedFields);
            }
            return facilities;
        }



        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
    public void PurchaseResource<T>(IResource resource, int index)
    {
      Console.WriteLine(typeof(T).ToString());
      switch (typeof(T).ToString())
      {
        case "Cow":
          GrazingFields[index].AddResource((IGrazing)resource);
          break;
        default:
          break;
      }
    }

    public void AddGrazingField(GrazingField field)
    {
      GrazingFields.Add(field);
    }
    public void AddNaturalField(NaturalField field)
    {
      NaturalFields.Add(field);
    }

    public void AddPlowedField(PlowedField field)
    {
      PlowedFields.Add(field);
    }
    public void AddChickenHouse(ChickenHouse house)
    {
      ChickenHouses.Add(house);
    }
    public void AddDuckHouse(DuckHouse house)
    {
      DuckHouses.Add(house);
    }

    public override string ToString()
    {
      StringBuilder report = new StringBuilder();

      GrazingFields.ForEach(gf => report.Append(gf));
      NaturalFields.ForEach(gf => report.Append(gf));
      PlowedFields.ForEach(gf => report.Append(gf));
      DuckHouses.ForEach(gf => report.Append(gf));
      ChickenHouses.ForEach(gf => report.Append(gf));

      return report.ToString();
    }
  }
}