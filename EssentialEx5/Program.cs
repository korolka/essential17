//Завдання 5

//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Створіть клас Calculator, методи якого приймають аргументи та повертають значення типу dynamic.
namespace EssentialEx5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator calculator = new Calculator();
                Console.WriteLine(calculator.Plus(2, 3));
                Console.WriteLine(calculator.Minus(2, 3));
                Console.WriteLine(calculator.Multiply(2, 3));
                Console.WriteLine(calculator.Dimision(2, ""));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}