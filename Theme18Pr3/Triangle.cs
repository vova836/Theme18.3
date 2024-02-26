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
    class Triangle : Figure
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
        /// Поле стороны3 фигуры
        /// </summary>
        int side3;
        /// <summary>
        /// Конструктор с 4 параметрами
        /// </summary>
        /// <param name="name">название фигуры</param>
        /// <param name="side1">значение стороны1 фигуры</param>
        /// <param name="side2">значение стороны2 фигуры</param>
        /// <param name="side3">значение стороны3 фигуры</param>
        public Triangle(string name, int side1, int side2,int side3) : base(name)
        {
            if (side1<side2+side3&& side2<side1+side3&&side3<side1+side2 )
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }

            
            
        }
        /// <summary>
        /// Свойства полей side1,side2,side3
        /// </summary>
        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }
        public int Side3 { get => side3; set => side3 = value; }
        /// <summary>
        /// Переопределённый метод нахождения площади из класса Figure
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
        }
        /// <summary>
        /// Переопределённый метод нахождения периметра из класса Figure
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return side1 + side2 + side3 ;
        }
        /// <summary>
        /// Переопределённый метод вывода информации о фигуре из класса Figure
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Площадь треугольника - {Area():F2}\nПериметр треугольника - {Perimeter()}");
        }
    }
}
