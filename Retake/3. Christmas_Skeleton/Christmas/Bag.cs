using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        private List<Present> bag;
        public Bag(string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            bag = new List<Present>();
        }

        public string Color { get; set; }
        public int Capacity { get; set; }

        public void Add(Present present)
        {
            if (this.bag.Count < this.Capacity)
            {
                this.bag.Add(present);
            }
            Capacity--;
        }
        public bool Remove(string name)
        {
            var present = this.bag.Find(p => p.Name == name);
            Capacity++;
            return this.bag.Remove(present);
        }
        public Present GetHeaviestPresent()
        {
            var maxWeight = double.MinValue;
            var heaviestPresent = new Present("One", 0, "one");
            foreach (var present in this.bag)
            {
                if (present.Weight > maxWeight)
                {
                    maxWeight = present.Weight;
                    heaviestPresent = present;
                }
            }
            Capacity--;
            return heaviestPresent;
        }

        public Present GetPresent(string name)
        {
            var present = this.bag.FirstOrDefault(p => p.Name == name);
            if (present.Name == name)
            {
                Capacity--;
            }
            return present;
        }

        public int Count => this.bag.Count;

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Color} bag contains:");
            sb.AppendLine($"{string.Join(Environment.NewLine, this.bag)}");

            return sb.ToString().TrimEnd();
        }
    }
}
