using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{

    public class Duck : IResource, IEggProducing, IFeatherProducing
    {


        private Guid _id = Guid.NewGuid();

        public string Type { get; } = "Duck";

        public int _eggsProduced = 6;

        public double _feathersProduced = 0.75;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
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
            return $"Duck {this._shortId}. Quack!";
        }
    }
}