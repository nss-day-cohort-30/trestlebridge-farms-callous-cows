using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{

  public class Sheep : IResource, IGrazing, IMeatProducing
  {
    private Guid _id = Guid.NewGuid();
    public string Type { get; } = "Sheep";
    public double GrassPerDay { get; set; } = 5.4;
    private double _meatProduced = 5.0;
    private string _shortId
    {
      get
      {
        return this._id.ToString().Substring(this._id.ToString().Length - 6);
      }
    }
    public void Graze()
    {
      Console.WriteLine($"Sheep {this._shortId} just ate {this.GrassPerDay}kg of grass");
    }

    public double Butcher()
    {
      return _meatProduced;
    }

    public override string ToString()
    {
      return $"";
    }
  }
}