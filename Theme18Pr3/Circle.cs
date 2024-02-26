using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr3
{
    /// <summary>
    /// Класс-потомок абстрактного класса Figure
    /// </summary>
    class Circle : Figure
    {
        /// <summary>
        /// Поле радиуса окружности
        /// </summary>
        int radius;
        /// <summary>
        /// Конструктор с 2 параметрами
        /// </summary>
        /// <param name="name">название фигуры</param>
        /// <param name="radius">значение радиуса окружности</param>
        public Circle(string name, int radius) : base(name)
        {
                this.radius = radius;
        }
        /// <summary>
        /// Свойства поля radius
        /// </summary>
        public int Radius { get => radius; set => radius = value; }
        /// <summary>
        /// Переопределённый метод нахождения площади из класса Figure
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        /// <summary>
        /// Переопределённый метод нахождения периметра из класса Figure
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return 2 * radius * Math.PI;
        }
        /// <summary>
        /// Переопределённый метод вывода информации о фигуре из класса Figure
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Площадь окружности - {Area():F2}\nПериметр окружности - {Perimeter():F2}");
        }
    }
}
