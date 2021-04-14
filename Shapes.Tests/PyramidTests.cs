using Shapes.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Shapes.Tests
{
    public class PyramidTests
    {
        [Fact]
        public void GetBaseArea_BaseSideIs1_returns4()
        {
            Pyramid pyramid = new Pyramid(2, 1);

            Assert.Equal(4.0, pyramid.BaseArea);
        }
    }
}
