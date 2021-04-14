using System;
using Xunit;
using Shapes.Figures;

namespace Shapes.Tests
{
    public class BallTests
    {
        [Fact]
        public void BallVolume_RadiusIs5_result524()
        {
            Ball ball = new Ball(5);

            double ballVolume = ball.GetVolume();

            Assert.Equal(524, ballVolume, 0);
        }

        [Fact]
        public void BallCreation_radiusIsZero_throwsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Ball(0));
        }

    }
}
