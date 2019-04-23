using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public List<IGrazing> AnimalsCount { get => _animals; set => _animals = value; }

        public void AddResource (IGrazing animal)
        {
            if (_animals.Count < _capacity) {
                _animals.Add(animal);
            }
            else{
                 Console.WriteLine("Grazing field is at capacity");
            }
        }

        public void AddResource (List<IGrazing> animals)  // TODO: Take out this method for boilerplate
        {
            if (_animals.Count + animals.Count <= _capacity) {
                _animals.AddRange(animals);
            }
             else{
                 Console.WriteLine("Grazing field is at capacity");
            }
        }

    internal void AddResource(ISeedProducing seed)
    {
      throw new NotImplementedException();
    }

    public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}