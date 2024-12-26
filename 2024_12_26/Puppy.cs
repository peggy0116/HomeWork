using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_26
{
    internal class Puppy
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }


        private string _Variety;
        public string Variety
        {
            get { return this._Variety; }
            set { this._Variety = value; }
        }

        public Puppy() { }
        public Puppy(string name, string owner, string description, double price, string variety)
        {
            Name = name;
            Owner = owner;
            Description = description;
            Price = price;
            Variety = variety;
        }

        public void PrintAllAttrib()
        {
            Console.WriteLine("Name is:" + this.Name.ToString());
            Console.WriteLine("Owener is :" + this.Owner.ToString());
            Console.WriteLine("Description is :" + this.Description.ToString());
            Console.WriteLine("Price is :" + this.Price.ToString());
            Console.WriteLine("Brand is :" + this.Variety.ToString());
        }
    }
}
