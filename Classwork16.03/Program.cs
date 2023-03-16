namespace Classwork16._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();
            ship.WeightCheck(340);
            
            Truck.WeightCheck(360);
        }

            public void PrintVehicle(float weight)///300
        {
            switch (weight)
            {
                case > 50000:
                    Console.WriteLine();
                    Truck.WeightCheck(weight);
                    break;
                case <500:
                    Ship ship = new Ship();
                    ship.MaxWeight = weight;
                    break;
            }
        }
    }
}