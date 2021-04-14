using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Figures
{
    public class Box : Shape
    {
        public double H { get; set; }
        public double emptyVolume { get; set; }

        public List<Shape> Shapes { get; set; } = new List<Shape>();
        public override double Volume { get;  }
        public override string Name { get; set; } = "Box";

        public Box(double height)
        {
            this.H = height;
            Volume = GetVolume();
            emptyVolume = GetVolume();
        }

        public override double GetVolume()
        {
            return Math.Pow(this.H,3);
        }

        public bool AddAvailable(Shape shape)
        {
            if (shape.Volume <= this.emptyVolume)
            {
                return true;
            }

            return false;
        }

        public void AddShape(Shape shape)
        {
            if (shape.Volume <= this.emptyVolume)
            {
                this.Shapes.Add(shape);
            };
        }
    }
}
