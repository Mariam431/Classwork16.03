using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork16._03
{
    internal class Truck : ITransport
    {
        public static DateTime ShipTime { get; set; }
        public static float MaxWeight { get; set; } = 500;
        public static float MinWeight { get; set; } = 1;
        public static string RestCountr { get; set; }



        public static void WeightCheck(float weight)
        {            
            if (weight > MaxWeight)
            {
                Console.WriteLine("We can't ship your product by truck, it's too heavy");
            }
            if (weight < MinWeight)
            {
                Console.WriteLine("We can't ship your product by truck, it's too light");
            }
            else
            {
                Console.WriteLine("We can ship your product by truck");
            }
        }
    }
}
