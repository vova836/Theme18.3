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
    class Rectangle : Figure
    {
        /// <summary>
        /// Поле стороны1 фигуры
        /// </summary>
        int side1;
        /// <summary>
        /// Поле стороны2 фигуры
        /// </summary>
        int side2;
        /// <summary>
        /// Конструктор с 3 параметрами
        /// </summary>
        /// <param name="name">название фигуры</param>
        /// <param name="side1">значение стороны1 фигуры</param>
        /// <param name="side2">значение стороны2 фигуры</param>
        public Rectangle(string name, int side1, int side2) : base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        /// <summary>
        /// Свойства полей side1, side2
        /// </summary>
        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }
        /// <summary>
        /// Переопределённый метод нахождения площади из класса Figure
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return side1 * side2;
        }
        /// <summary>
        /// Переопределённый метод нахождения периметра из класса Figure
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return 2 * (side1 + side2);
        }
        /// <summary>
        /// Переопределённый метод вывода информации о фигуре из класса Figure
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Площадь прямоугольника - {Area()}\nПериметр прямоугольника - {Perimeter()}");
        }
    }
}
