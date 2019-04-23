using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
  public class Sesame : Seed, IResource, ISeedProducing, IPlowable
  {
    public Sesame()
    {
      SeedProduced = 40;
      Type = "Sesame";
    }
    //TODO   fix seed get

    public override string ToString()
    {
      return $"Sesame. Yum!";
    }

    public double Plow()
    {
      return SeedProduced;
    }
  }
}