using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork16._03
{
    internal class Airplane:ITransport
    {
        public DateTime ShipTime { get; set; }
        public float MaxWeight { get; set; } = 10000;
        public float MinWeight { get; set; } = 500;
        public string RestCountr { get; set; }



        public void WeightCheck(float MaxWeight, float MinWeight)
        {
            Console.WriteLine("Enter your item's weight");
            int weight = int.Parse(Console.ReadLine());
            if (weight > MaxWeight)
            {
                Console.WriteLine("We can't ship your product by plane, it's too heavy");
            }
            if (weight < MinWeight)
            {
                Console.WriteLine("We can't ship your product by plane, it's too light");
            }
            else
            {
                Console.WriteLine("We can ship your product by plane");
            }
        }
    }
}
