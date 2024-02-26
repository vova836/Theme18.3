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
    class Square : Figure
    {
        /// <summary>
        /// Поле стороны1 фигуры
        /// </summary>
        int side1;
        /// <summary>
        /// Конструктор с 2 параметрами
        /// </summary>
        /// <param name="name">название фигуры</param>
        /// <param name="side1">значение стороны1 фигуры</param>
        public Square(string name, int side1) : base(name)
        {
            this.side1 = side1;
        }
        /// <summary>
        /// Свойства поля side1
        /// </summary>
        public int Side1 { get => side1; set => side1 = value; }
        /// <summary>
        /// Переопределённый метод нахождения площади из класса Figure
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return side1 * side1;
        }
        /// <summary>
        /// Переопределённый метод нахождения периметра из класса Figure
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return side1*4;
        }
        /// <summary>
        /// Переопределённый метод вывода информации о фигуре из класса Figure
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Площадь квадрата - {Area()}\nПериметр квадрата - {Perimeter()}");
        }
    }
}
