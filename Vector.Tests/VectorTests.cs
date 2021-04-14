using System;
using Vectors;
using Xunit;

namespace Vectors.Tests
{
    public class VectorTests
    {
        [Theory]
        [InlineData(0, 5, 2, 5.39)]
        [InlineData(7, 4, 3, 8.60)]
        [InlineData(0, 0, 0, 0)]
        public void LengthOfVector(int x, int y, int z, double expected)
        {
            Vector vector = new Vector(x, y, z);

            double length = vector.Length();

            Assert.Equal(expected, length, 2);
        }

        [Theory]
        [InlineData(7, 4, 3, 0, 0, 0, 0)]
        public void Cosine_OneVectorIsZeroVector_return0(int x1, int y1, int z1, int x2, int y2, int z2, double expected)
        {
            Vector vector1 = new Vector(x1, y1, z1);
            Vector vector2 = new Vector(x2, y2, z2);

            double cosine = vector1.Cosine(vector2);

            Assert.Equal(expected, cosine);
        }
    }
}
