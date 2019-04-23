using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<INatural>
    {
        private int _capacity = 10;
        private Guid _id = Guid.NewGuid();

        private List<INatural> _seeds = new List<INatural>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public List<INatural> SeedsCount { get => _seeds; set => _seeds = value; }

        public void AddResource(INatural seed)
        {
            if (_seeds.Count < _capacity)
            {
                _seeds.Add(seed);
            }
             else{
                 Console.WriteLine("Natural field is at capacity");
            }
        }

        public void AddResource(List<INatural> seed)  // TODO: Take out this method for boilerplate
        {
            if (seed.Count + seed.Count <= _capacity)
            {
                seed.AddRange(seed);
            }
             else{
                 Console.WriteLine("Natural field is at capacity");
            }
        }


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this._seeds.Count} seed\n");
            this._seeds.ForEach(a => output.Append($" Seeds {a}\n"));

            return output.ToString();
        }
    }
}