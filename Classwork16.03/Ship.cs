using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork16._03
{
    internal class Ship : ITransport
    {
        public DateTime ShipTime { get; set; } 
        public float MaxWeight { get; set; } = 1000;
        public float MinWeight { get; set; } = 10;
        public string RestCountr { get; set ; }

        public Ship()
        {

        }
        public void WeightCheck(float weight)
        {
            if (weight > MaxWeight)
            {
                Console.WriteLine("We can't ship your product by ship, it's too heavy");
            }
            if (weight < MinWeight)
            {
                Console.WriteLine("We can't ship your product by ship, it's too light");
            }
            else
            {
                Console.WriteLine("We can ship your product by ship");
            }
        }
    }
    
}
