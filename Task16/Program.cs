using Core.Models;
namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car= new Car();
            car.Marka = "BMW";
            car.Model = "F10";
            car.Year = 2014;
            car.PassengerCapacity = 5;

            Car car1 = new Car();
            car1.Marka = "BMW";
            car1.Model = "E60";
            car1.Year = 2008;
            car1.PassengerCapacity = 5;

            Car car2 = new Car();
            car2.Marka = "Mercedes-Benz";
            car2.Model = "W210";
            car2.Year = 2001;
            car2.PassengerCapacity = 5;


            Truck truck = new Truck();
            truck.Marka = "Volvo";
            truck.Model = "s90";
            truck.Year = 2021;
            truck.CarryingCapacity = 80;

            Truck truck1 = new Truck();
            truck1.Marka = "Mercedes-Benz";
            truck1.Model = "Actross";
            truck1.Year = 2020;
            truck1.CarryingCapacity = 120;

            Truck truck2 = new Truck();
            truck2.Marka = "Scania";
            truck2.Model = "xc40";
            truck2.Year = 2022;
            truck2.CarryingCapacity = 90;  

            RentCar rentCar = new RentCar();
            rentCar.CarLimit = 3;
            rentCar.TruckLimit = 2;

            rentCar.AddVehicle(car);
            rentCar.AddVehicle(car1);
            rentCar.AddVehicle(car2);

            rentCar.AddVehicle(truck);
            rentCar.AddVehicle(truck1);
            rentCar.AddVehicle(truck2);

            Console.WriteLine(" ");

            rentCar.ShowAllVehicle();
            









        }
    }
}
