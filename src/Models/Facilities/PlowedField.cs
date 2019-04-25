using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Plants;
using System.Linq;

namespace Trestlebridge.Models.Facilities
{
  public class PlowedField : IFacility<IPlowable>
  {
    private int _capacity = 13;
    private Guid _id = Guid.NewGuid();
    private List<IPlowable> _seeds = new List<IPlowable>();
    public double Capacity
    {
      get
      {
        return _capacity;
      }
    }

    public List<IPlowable> SeedsCount { get => _seeds; set => _seeds = value; }
    public void AddResource(IPlowable seed)
    {
      if (_seeds.Count < _capacity)
      {
        _seeds.Add(seed);
      }
      else
      {
        Console.WriteLine("Plowed field is at capacity");
      }
    }

    public void AddResource(List<IPlowable> seeds)  // TODO: Take out this method for boilerplate
    {
      if (_seeds.Count + seeds.Count <= _capacity)
      {
        _seeds.AddRange(seeds);
      }
      else
      {
        Console.WriteLine("Plowed field is at capacity");
      }
    }

    public override string ToString()
    {
      StringBuilder output = new StringBuilder();
      string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

      var groupedSeeds = _seeds.GroupBy(
        currentSeed => currentSeed.Type
          );

      var seedString = "";
      foreach (var currentSeedGroup in groupedSeeds)
      {
        seedString += currentSeedGroup.Count() + " " + currentSeedGroup.Key + ",";

      };
      Console.WriteLine($"Grazing Field ({seedString})");
      return output.ToString();
    }
  }
}