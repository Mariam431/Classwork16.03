using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork16._03
{
    internal interface ITransport
    {
        public static DateTime ShipTime { get; set; }
        public static float MaxWeight { get; set; }
        public static float MinWeight { get; set; }
        public static string RestCountr { get; set; }

    }
}
