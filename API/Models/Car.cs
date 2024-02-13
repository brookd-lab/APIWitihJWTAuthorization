namespace API.Models
{
    public class Car
    {
        public static List<Car> cars = new List<Car>()
        {
            new Car() { Id = 1, Make = "Ford", Model = "Escort" },
            new Car() { Id = 2, Make = "Honda", Model = "Accord" }
        };

        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public static List<Car> GetCars()
        {
            return cars;
        }

        public static Car GetCarById(int id)
        {
            var car = cars.Find(x => x.Id == id)!;
            return car;
        }

        public static void CreateCar(Car car)
        {
            cars.Add(car);
        }
    }
}
