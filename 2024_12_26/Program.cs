using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_26
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Puppy DennisPuppy = new Puppy();
            DennisPuppy.Name = "Happy";
            DennisPuppy.Owner = "Dennis";
            DennisPuppy.Description = "black";
            DennisPuppy.Price = 1000;
            DennisPuppy.Variety = "Shiba Inu";
            DennisPuppy.PrintAllAttrib();

            Puppy MarysCar = new Puppy("Happy", "Dennis", "black", 1000, "Shiba Inu");
            MarysCar.PrintAllAttrib();
        }
    }
}
