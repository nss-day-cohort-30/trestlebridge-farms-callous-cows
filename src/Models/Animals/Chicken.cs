using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{

    public class Chicken : IResource, IGrazing, IMeatProducing, IEggProducing, IFeatherProducing
    {


        private Guid _id = Guid.NewGuid();

        public string Type { get; } = "Chicken";

        public double GrassPerDay { get; set; } = 5.4;

        private double _meatProduced = 1.7;

        private int _eggsProduced = 7;

        private double _feathersProduced = 0.5;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public void Graze()
        {
             Console.WriteLine($"Chicken {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public double GatherEggs()
        {
            return _eggsProduced;
        }

        public double collectingFeathers()
        {
            return _feathersProduced;
        }


        public override string ToString () {
            return $"Chicken {this._shortId}. *chicken noise back back*!";
        }
    }
}