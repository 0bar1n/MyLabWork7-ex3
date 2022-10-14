using System;

namespace MyLabWork7_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double r,h,d; //переменные вещественного типа
            r = 6350; //задние переменной радиуса из условия
            Console.WriteLine("Высота над Землей h="); //просим пользователя ввести высоту над Землей
            h = Convert.ToDouble(Console.ReadLine()); //задание переменной вещественного типа
            d = Math.Sqrt(h*(2*r+h)); // задание переменной по формуле, нахождение расстояния до линии горизонта
            Console.WriteLine($"Расстояние до линии горизонта равно d = {d}км" ); //вывод на экран 
        }
    }
}
