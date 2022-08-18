using System;
using System.Collections.Generic;
using Curso_POO_Abstract.Entities;
using Curso_POO_Abstract.Entities.Enums;
using System.Globalization;
namespace Curso_POO_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> formas = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int nshapes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nshapes; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char resChar = char.Parse(Console.ReadLine());
                Console.Write("Color (black/blue/red): ");
                Color resColor =(Color)Enum.Parse(typeof(Color),Console.ReadLine());
                if(resChar == 'r')
                {
                    Console.Write("Width: ");
                    double resWidth = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double resHeight = double.Parse(Console.ReadLine());
                    formas.Add(new Rectangule(resWidth, resHeight, resColor));
                }
                else
                {
                    Console.Write("Radius: ");
                    double resRadius = double.Parse(Console.ReadLine());
                    formas.Add(new Circle(resRadius, resColor));
                }
                

            }


            Console.WriteLine("SHAPE AREAS:");
            foreach(var n in formas)
            {
                Console.WriteLine(n.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
