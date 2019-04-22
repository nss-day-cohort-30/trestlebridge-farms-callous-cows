using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Models.Facilities {
    public class NaturalField : IFacility<Seed>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<Seed> _seeds = new List<Seed>();

    public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (Seed seed)
        {
            if (_seeds.Count < _capacity) {
                _seeds.Add(seed);
            }
        }

        public void AddResource (List<Seed> seed)  // TODO: Take out this method for boilerplate
        {
            if (seed.Count + seed.Count <= _capacity) {
                seed.AddRange(seed);
            }
        }


    public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._seeds.Count} seed\n");
            this._seeds.ForEach(a => output.Append($" Seeds {a}\n"));

            return output.ToString();
        }
    }
}