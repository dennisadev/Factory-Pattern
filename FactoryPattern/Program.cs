namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does your vehicle have?");
            var numWheels = int.Parse(Console.ReadLine());

            var vehicle1 = VehicleFactory.GetVehicle(numWheels);

            vehicle1.Drive();

        }
    }
}
