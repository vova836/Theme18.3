using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme18Pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write($"Выберите фигуру(Прямоугольник,квадрат,треугольник, окружность) ");
                string figure = Console.ReadLine();
                switch (figure.ToLower())
                {
                    case "прямоугольник":
                        List<Figure> fig1 = new List<Figure>();
                        fig1.Add(new Rectangle($"{figure}",5,5));
                        foreach (var elem in fig1)
                        {
                            elem.Print();

                        }
                        break;
                    case "квадрат":
                        List<Figure> fig2 = new List<Figure>();
                        fig2.Add(new Square($"{figure}", 6));
                        foreach (var elem in fig2)
                        {
                            elem.Print();

                        }
                        break;
                    case "треугольник":
                        List<Figure> fig3 = new List<Figure>();
                        fig3.Add(new Triangle($"{figure}", 5,4,2));
                        foreach (var elem in fig3)
                        {
                            elem.Print();

                        }
                        break;
                    case "окружность":
                        List<Figure> fig4 = new List<Figure>();
                        fig4.Add(new Circle($"{figure}", 4));     ;
                        foreach (var elem in fig4)
                        {
                            elem.Print();

                        }
                        break;

                    case "q":
                        return;
                    default:
                        Console.WriteLine("Я не знаю такой фигуры :/");
                        break;



                }
                Console.ReadKey();
            }
        }
    }
}
