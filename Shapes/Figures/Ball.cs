using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Figures
{
    public class Ball : Shape
    {
        public double R { get; set; }
        public override double Volume { get;  }
        public override string Name { get; set; } = "Ball";

        public Ball(double radius)
        {
            if(radius > 0)
            {
                this.R = radius;
                Volume = GetVolume();
            }
            else
            {
                throw new ArgumentException("Ball radius cannot be 0 or negative");
            }
        }

        public override double GetVolume()
        {
            return (4.0/3.0)*Math.PI*Math.Pow(this.R, 3);
        }
    }
}
