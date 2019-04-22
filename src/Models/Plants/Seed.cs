using System;
using Trestlebridge.Interfaces;
namespace Trestlebridge.Models.Plants
{
  public class Seed : IResource, ISeedProducing
  {
    private double _seedsProduced;
    private string _type;
    public string Type
    {
      get
      { return _type; }
      set {_type = value;}
    }
    public double SeedProduced
    {
      get
      { return _seedsProduced; }
      set { _seedsProduced = value; }
    }
    public double Harvest()
    {
      return _seedsProduced;
    }
    public override string ToString()
    {
      return $"Yum!";
    }
  }
}