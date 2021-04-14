using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Figures
{
    public abstract class Shape
    {
        public abstract double Volume { get;  }
        public abstract string Name { get; set; }
        public abstract double GetVolume();
    }
}
