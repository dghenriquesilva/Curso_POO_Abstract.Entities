using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso_POO_Abstract.Entities.Enums;

namespace Curso_POO_Abstract.Entities
{
    class Circle:Shape
    {
        public double Radius { get; set; }
        public Circle(double radius, Color color): base(color)
        {
            Radius = radius;
        }

        public Circle()
        {

        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
