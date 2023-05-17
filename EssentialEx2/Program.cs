//Завдання 2

//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//    Уявіть, що ви пишете програму для Автостанції і вам необхідно створити просту
//    колекцію автомобілів з такими даними: марка автомобіля, модель, рік випуску, колір.
//    А також другу колекцію з моделлю автомобіля, ім'ям покупця та його номером телефону.
//    Використовуючи найпростіший запит LINQ, виведіть на екран інформацію про покупця
//    одного з автомобілів і повну характеристику придбаної ним моделі. 
namespace Essential17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            List<Buyer> buyers = new List<Buyer>(); 
            vehicles.Add(new Vehicle("Volkswagen", "Tourag", "Black", 2021));
            vehicles.Add(new Vehicle("Audi", "RS6", "Dark blue", 2019));
            vehicles.Add(new Vehicle("Mercedes", "GLE","White", 2018));

            buyers.Add(new Buyer("Tourag", "Oleg", "380663567354"));
            buyers.Add(new Buyer("RS6", "Pablo", "3806343523"));
            buyers.Add(new Buyer("GLE", "Svitlana", "380672326423"));

            var query = from vehicle in vehicles
                        join buyer in buyers on vehicle.Model equals buyer.Model
                        where vehicle.YearOfManufacture > 2019
                        select new
                        {
                            Marka = vehicle.Marka,
                            Model = vehicle.Model,
                            Color = vehicle.Color,
                            Year = vehicle.YearOfManufacture,
                            PhoneNumber = buyer.PhoneNumber,
                            Name= buyer.BuyerName
                        };

            foreach(var vehicle in query)
            {
                Console.WriteLine($"Marka {vehicle.Marka}\n Model {vehicle.Model}\n Color {vehicle.Color}\n Year {vehicle.Year}\n Name {vehicle.Name}\n Phone {vehicle.PhoneNumber}");
            }
        }
    }
}