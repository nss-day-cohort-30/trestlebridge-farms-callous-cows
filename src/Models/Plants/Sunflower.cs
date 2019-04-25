using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
  public class Sunflower : Seed, IResource, ISeedProducing, IPlowable, INatural
  {
    public Sunflower()
    {
      SeedProduced = 40;
      Type = "Sunflower";
    }

    public override string ToString()
    {
      return $"Sunflower. Yum!";
    }

    public double Plow()
    {
      return SeedProduced;
    }
    public double Pick()
    {
      return SeedProduced;
    }
  }
}