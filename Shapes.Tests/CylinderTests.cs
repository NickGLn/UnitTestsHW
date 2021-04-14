using Shapes.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Shapes.Tests
{
    public class CylinderTests
    {
        [Fact]
        public void Cylinder_DefaultName_isCylinder()
        {
            Cylinder cylinder = new Cylinder(5, 3);

            Assert.Equal("Cylinder", cylinder.Name);
        }
    }
}
