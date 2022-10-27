namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Mercedes-Benz";
            myCar.Model = "GT63 S";
            myCar.Year = 2023;

            var BMW = new Car()
            {
                Make = "BMW",
                Model = "X3",
                Year = 2023
            };

            var Chevy = new Car("Chevy", "Impala", 2020);

            var carList = new List<Car>() { myCar, BMW, Chevy };

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }



        }
    }
}
