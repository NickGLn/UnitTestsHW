using Shapes.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Shapes.Tests
{
    public class BoxTests
    {
        [Fact]
        public void AddAvailable_EmptyVolumeLessThanShapeVolume_returnsFalse()
        {
            Box container = new Box(5);
            Box shape = new Box(10);

            bool addIsAvailable = container.AddAvailable(shape);

            Assert.False(addIsAvailable);
        }

        [Fact]
        public void Container_ShapeAdded_ContainsShape()
        {
            Box container = new Box(10);
            Box box = new Box(5);

            container.AddShape(box);

            Assert.Contains<Shape>(box, container.Shapes);
        }
    }
}
