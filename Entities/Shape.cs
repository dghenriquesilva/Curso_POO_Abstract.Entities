using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso_POO_Abstract.Entities.Enums;

namespace Curso_POO_Abstract.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }
        public Shape()
        {

        }
        public Shape(Color color)
        {
            Color = color;
        }
       public virtual double Area()
        {
            return 0;
        }
    }
}
