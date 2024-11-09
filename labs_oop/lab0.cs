using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    using System;

    class KV // объявление класса KV
    {
        private double a; // объявление приватного поля стороны "a"

        public KV() // конструктор класса KV
        {
            Console.Write("Введите сторону квадрата: "); // вызов пользовательского ввода
            a = double.Parse(Console.ReadLine()); // считывание введенной пользователем стороны квадрата и присваивание ее значению стороны "a"
        }

        public double SideByFour() // метод класса KV для вычисления периметра квадрата
        {
            return 4 * a; // возвращение значения периметра
        }

        public double SideBySide() // метод класса KV для вычисления площади квадрата
        {
            return a * a; // возвращение значения площади
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            KV kvadrat = new KV(); // создание экземпляра класса KV и вызов конструктора
            Console.WriteLine("Периметр == " + kvadrat.SideByFour()); // вывод конечного значения периметра квадрата, просчтанного с помощью метода методом SideByFour()
            Console.WriteLine("Площадь == " + kvadrat.SideBySide()); // вывод конечного значения площади квадрата, просчитанного с помощью SideBySide()

        }
 }

}