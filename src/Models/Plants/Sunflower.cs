using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing
    {
        private int _seedsProduced = 40;
        public string Type { get; } = "Sunflower";


        //TODO   fix seed get
        public double SeedProduced { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sunflower. Yum!";
        }
    }
}