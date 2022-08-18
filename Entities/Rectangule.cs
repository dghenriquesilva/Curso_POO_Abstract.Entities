using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso_POO_Abstract.Entities;
using Curso_POO_Abstract.Entities.Enums;
namespace Curso_POO_Abstract.Entities
{
    public class Rectangule : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangule()
        {

        }
        public Rectangule(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
