using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities {
    public class DuckHouse : IFacility<Duck>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();

        private List<Duck> _ducks = new List<Duck>();


        public double Capacity {
            get {
                return _capacity;
            }
        }

        public List<Duck> DucksCount { get => _ducks; set => _ducks = value; }

        public void AddResource (Duck duck)
        {
            if (_ducks.Count < _capacity) {
                _ducks.Add(duck);
            }
        }

        public void AddResource (List<Duck> ducks)  // TODO: Take out this method for boilerplate
        {
            if (_ducks.Count + ducks.Count <= _capacity) {
                _ducks.AddRange(ducks);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck house {shortId} has {this._ducks.Count} ducks\n");
            this._ducks.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}