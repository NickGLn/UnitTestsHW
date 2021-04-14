using Shapes.Figures;
using Shapes.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Shapes.Tests
{
    public class ShapeLoaderTests
    {
        [Fact]
        public static void PutIntoContainer_ShapeAdded_ContainerEmptyVolumeChanged()
        {
            Box container = new Box(10);
            Pyramid pyramid = new Pyramid(5, 5);

            double initialEmptyVolume = container.emptyVolume;
            ShapeLoader.PutIntoContainer(container, pyramid);
            double newEmptyVolume = container.emptyVolume;

            Assert.False(initialEmptyVolume == newEmptyVolume);
        }
    }
}
