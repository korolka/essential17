//Завдання 3

//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Використовуючи динамічні та анонімні типи даних, створіть Англо-Український словник на 10 слів та виведіть на екран його зміст. 
using System.Text;

namespace EssentialEx3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var dictinary = new
            {
                Dict = new dynamic[]
                {
                  new  { En = "Book",Uk= "Книга"},
                   new    {En = "Pen",Uk ="Ручка" },
                    new {En = "Car",Uk = "Автомобіль"},
                   new  {En = "Cat",Uk = "Кіт"},
                   new  {En = "Door",Uk = "Двері"},
                   new  {En = "Snake",Uk = "Змія"},
                   new  {En = "Dog",Uk ="Пес"},
                   new  {En = "Lake",Uk="Озеро"},
                   new  {En = "Lion",Uk="Лев"},
                    new {En = "Wolf",Uk="Вовк"}
                }

            };



            foreach (var dict in dictinary.Dict)
            {
                Console.WriteLine($"{dict.En} - {dict.Uk}" );
            }
        }
    }
}