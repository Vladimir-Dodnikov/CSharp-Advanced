using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> rabbits;
        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.rabbits = new List<Rabbit>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public List<Rabbit> Data => this.rabbits;

        public void Add(Rabbit rabbit)
        {
            if (this.Data.Count < this.Capacity)
            {
                this.Data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            var rabbit = this.Data.Find(x => x.Name == name);
            return this.Data.Remove(rabbit);
        }

        public void RemoveSpecies(string species)
        {
            foreach (var rabbit in this.Data.Where(s=>s.Species == species))
            {
                this.Data.Remove(rabbit);
            }
        }

        public Rabbit SellRabbit(string name)
        {
            var rabbit = this.Data.FirstOrDefault(x => x.Name == name);
            rabbit.Available = false;
            return rabbit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            List<Rabbit> soldbySpecies = new List<Rabbit>();

            foreach (var rabbit in this.Data.Where(r=>r.Species == species))
            {
                rabbit.Available = false;
                soldbySpecies.Add(rabbit);
            }
            return soldbySpecies.ToArray();
        }

        public int Count => this.Data.Count();

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {this.Name}:");

            foreach (var rabbit in this.Data.Where(x => x.Available == true))
            {
                sb.AppendLine(rabbit.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
