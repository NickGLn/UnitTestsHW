using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Figures
{
    public class Pyramid : Shape
    {
        public double H { get;  }
        public double BaseSide { get;  }
        public double BaseArea { get;  }
        public override double Volume { get;  }
        public override string Name { get; set; } = "Pyramid";
        public Pyramid(double height, double baseSideSize)
        {
            this.H = height;
            this.BaseSide = baseSideSize;
            BaseArea = GetBaseArea();
            Volume = GetVolume();
            
        }
        public override double GetVolume()
        {
            return (BaseArea*H)/3;
        }

        public double GetBaseArea()
        {
            return 4.0 * BaseSide;
        }
    }
}
