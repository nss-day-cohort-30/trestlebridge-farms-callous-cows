using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
  public class Sunflower : Seed, IResource, ISeedProducing
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
  }
}