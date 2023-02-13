using OOP_program_of_different_car_using_constructors;

class Program
{
    static void Main(string[] args)
    {

        // call parameterized constructor
        Car car1 = new Car("Bugatti", 50000);

        Console.WriteLine("Brand: " + car1.brand);
        Console.WriteLine("Price: " + car1.price);
        Console.ReadLine();

    }
}