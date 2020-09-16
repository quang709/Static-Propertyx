using System;

namespace Static_Property
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car("Mazda 3", "Skyactiv 3");
            Console.WriteLine( Car.numberOfCars);
            Car car2 = new Car("Mazda 6", "Skyactiv 6");
            Console.WriteLine(Car.numberOfCars); // numberOfCars goi tu class
            Console.WriteLine(car1.getEngine());
            Console.WriteLine(car1.getName());
            Console.WriteLine(car2.getEngine());
            Console.WriteLine(car2.getName());
            Console.ReadLine();

        }
    }
}
