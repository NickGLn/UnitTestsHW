using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Figures
{
    public class Cylinder : Shape
    {
        public double H { get; set; }
        public double R { get; set; }
        public override double Volume { get;  }
        public override string Name { get; set; } = "Cylinder";

        public Cylinder(double height, double radius)
        {
            this.H = height;
            this.R = radius;
            Volume = GetVolume();
        }

        public override double GetVolume()
        {
            return Math.PI*Math.Pow(this.R,2)*H;
        }
    }
}
