using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
  public class Wildflower : Seed, IResource, ISeedProducing, INatural
  {
    public Wildflower()
    {
      SeedProduced = 40;
      Type = "Wildflower";
    }

    public override string ToString()
    {
      return $"Wildflower. Yum!";
    }
    public double Pick()
    {
      return SeedProduced;
    }
  }
}