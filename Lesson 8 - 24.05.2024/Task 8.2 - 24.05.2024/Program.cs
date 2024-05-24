namespace Task_8._2___24._05._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Truck truck = new Truck();


            Console.Write("Masinin gedeceyi mesafeni qeyd edin: ");
            int distance = Convert.ToInt32(Console.ReadLine());
            car.Drive(distance);


            Console.Write("Masina nece litr benzin daxil edeceyinizi qeyd edin: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            car.Refuel(amount);
            Console.WriteLine(car.FuelQuantity); 




            Console.Write("Truckin gedeceyi mesafeni qeyd edin: ");
            distance = Convert.ToInt32(Console.ReadLine());
            truck.Drive(distance);


            Console.Write("Trucka nece litr benzin daxil edeceyinizi qeyd edin: ");
            distance = Convert.ToInt32(Console.ReadLine());
            truck.Refuel(amount);
            Console.WriteLine(truck.FuelQuantity);

        }
    }
}