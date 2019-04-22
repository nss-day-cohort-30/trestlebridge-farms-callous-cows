using System;
using Trestlebridge.Interfaces;
namespace Trestlebridge.Models.Plants
{
    public class Seed : IResource, ISeedProducing
    {
        private int _seedsProduced;
        public string Type { get; }
        //TODO   fix seed get
        public double SeedProduced { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Harvest () {
            return _seedsProduced;
        }
        public override string ToString () {
            return $"Yum!";
        }
    }
}