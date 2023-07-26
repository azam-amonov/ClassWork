namespace Dars_12.Car;

public class CarService
{


    public void Create()
    {
        List<CarModel> cars = new List<CarModel>();
        cars.Add(new CarModel { Name = "Accord", Brand = "Honda" });
        cars.Add(new CarModel { Name = "Camry", Brand = "Toyota" });
        cars.Add(new CarModel { Name = "Civic", Brand = "Honda"});
        cars.Add(new CarModel { Name = "Accord", Brand = "Honda" }); 
        cars.Add(new CarModel { Name = "Camry", Brand = "Toyota" });
        cars.Add(new CarModel { Name = "Elantra", Brand = "Hyundai" });
        cars.Add(new CarModel { Name = "Accord", Brand = "Honda" });
        cars.Add(new CarModel { Name = "Accord", Brand = "Honda" });
        cars.Add(new CarModel { Name = "Camry", Brand = "Toyota" });
        cars.Add(new CarModel { Name = "Civic", Brand = "Honda"});
        cars.Add(new CarModel { Name = "Accord", Brand = "Honda" }); 
        cars.Add(new CarModel { Name = "Camry", Brand = "Toyota" });
        cars.Add(new CarModel { Name = "Elantra", Brand = "Hyundai" });
        cars.Add(new CarModel { Name = "Accord", Brand = "Honda" });

            Dictionary<string, int> dct = new Dictionary<string, int>();
        foreach (var car in cars)
        {
            if (dct.ContainsKey(car.Name + " " + car.Brand))
                dct[car.Name + " " + car.Brand]++;
            else
                dct[car.Name + " " + car.Brand] = 1;

        }

        foreach (var car in dct)
        {
            Console.WriteLine($"{car.Key}  {car.Value}");
        }
    }
}