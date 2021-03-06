using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
  public class Cow : IResource, IGrazing, IMeatProducing
  {
    private Guid _id = Guid.NewGuid();
    private double _meatProduced = 18.25;
    private string _shortId
    {
      get
      {
        return this.Id.ToString().Substring(this.Id.ToString().Length - 6);
      }
    }
    public double GrassPerDay { get; set; } = 5.4;
    public string Type { get; } = "Cow";
    public double MeatProduced => throw new NotImplementedException();
    public Guid Id { get => _id; set => _id = value; }
    // Methods
    public void Graze()
    {
      Console.WriteLine($"Cow {this._shortId} just ate {this.GrassPerDay}kg of grass");
    }
    public double Butcher()
    {
      return _meatProduced;
    }
  }
}
