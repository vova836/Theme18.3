using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr3
{
    /// <summary>
    /// Абстрактный класс фигуры
    /// </summary>
    abstract class Figure
    {
        /// <summary>
        /// Поле названия фигуры
        /// </summary>
        string name;
        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="name">название фигуры</param>
        public Figure(string name) { this.name = name; }
        /// <summary>
        /// Свойства поля name
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// Абстрактный метод площади
        /// </summary>
        /// <returns></returns>
        public abstract double Area();
        /// <summary>
        /// Абстрактный метод периметра
        /// </summary>
        /// <returns></returns>
        public abstract double Perimeter();
        /// <summary>
        /// Виртуальный метод вывода информации о фигуре
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine($"Название фигуры - {name}");
        }
    }
}
