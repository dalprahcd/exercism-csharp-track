// This file was auto-generated based on version 1.1.0 of the canonical data.

using Xunit;

namespace Exercism.CSharp.Solutions.SpiralMatrixExercise.Tests
{
    public class SpiralMatrixTests
    {
        [Fact]
        public void Empty_spiral()
        {
            Assert.Empty(SpiralMatrix.GetMatrix(0));
        }

        [Fact]
        public void Trivial_spiral()
        {
            var expected = new[,]
            {
                { 1 }
            };
            Assert.Equal(expected, SpiralMatrix.GetMatrix(1));
        }

        [Fact]
        public void Spiral_of_size_2()
        {
            var expected = new[,]
            {
                { 1, 2 },
                { 4, 3 }
            };
            Assert.Equal(expected, SpiralMatrix.GetMatrix(2));
        }

        [Fact]
        public void Spiral_of_size_3()
        {
            var expected = new[,]
            {
                { 1, 2, 3 },
                { 8, 9, 4 },
                { 7, 6, 5 }
            };
            Assert.Equal(expected, SpiralMatrix.GetMatrix(3));
        }

        [Fact]
        public void Spiral_of_size_4()
        {
            var expected = new[,]
            {
                { 01, 02, 03, 04 },
                { 12, 13, 14, 05 },
                { 11, 16, 15, 06 },
                { 10, 09, 08, 07 }
            };
            Assert.Equal(expected, SpiralMatrix.GetMatrix(4));
        }

        [Fact]
        public void Spiral_of_size_5()
        {
            var expected = new[,]
            {
                { 01, 02, 03, 04, 05 },
                { 16, 17, 18, 19, 06 },
                { 15, 24, 25, 20, 07 },
                { 14, 23, 22, 21, 08 },
                { 13, 12, 11, 10, 09 }
            };
            Assert.Equal(expected, SpiralMatrix.GetMatrix(5));
        }

        [Fact]
        public void Spiral_of_size_6()
        {
            var expected = new[,]
            {
                { 01, 02, 03, 04, 05, 06 },
                { 20, 21, 22, 23, 24, 07 },
                { 19, 32, 33, 34, 25, 08 },
                { 18, 31, 36, 35, 26, 09 },
                { 17, 30, 29, 28, 27, 10 },
                { 16, 15, 14, 13, 12, 11 },
            };
            Assert.Equal(expected, SpiralMatrix.GetMatrix(6));
        }

        [Fact]
        public void Spiral_of_size_7()
        {
            var expected = new[,]
            {
                { 01, 02, 03, 04, 05, 06, 07 },
                { 24, 25, 26, 27, 28, 29, 08 },
                { 23, 40, 41, 42, 43, 30, 09 },
                { 22, 39, 48, 49, 44, 31, 10 },
                { 21, 38, 47, 46, 45, 32, 11 },
                { 20, 37, 36, 35, 34, 33, 12 },
                { 19, 18, 17, 16, 15, 14, 13 },
            };
            Assert.Equal(expected, SpiralMatrix.GetMatrix(7));
        }

        [Fact]
        public void Spiral_of_size_8()
        {
            var expected = new[,]
            {
                { 01, 02, 03, 04, 05, 06, 07, 08 },
                { 28, 29, 30, 31, 32, 33, 34, 09 },
                { 27, 48, 49, 50, 51, 52, 35, 10 },
                { 26, 47, 60, 61, 62, 53, 36, 11 },
                { 25, 46, 59, 64, 63, 54, 37, 12 },
                { 24, 45, 58, 57, 56, 55, 38, 13 },
                { 23, 44, 43, 42, 41, 40, 39, 14 },
                { 22, 21, 20, 19, 18, 17, 16, 15 },
            };
            Assert.Equal(expected, SpiralMatrix.GetMatrix(8));
        }

        [Fact]
        public void Spiral_of_size_9()
        {
            var expected = new[,]
            {
                { 01, 02, 03, 04, 05, 06, 07, 08, 09 },
                { 32, 33, 34, 35, 36, 37, 38, 39, 10 },
                { 31, 56, 57, 58, 59, 60, 61, 40, 11 },
                { 30, 55, 72, 73, 74, 75, 62, 41, 12 },
                { 29, 54, 71, 80, 81, 76, 63, 42, 13 },
                { 28, 53, 70, 79, 78, 77, 64, 43, 14 },
                { 27, 52, 69, 68, 67, 66, 65, 44, 15 },
                { 26, 51, 50, 49, 48, 47, 46, 45, 16 },
                { 25, 24, 23, 22, 21, 20, 19, 18, 17 },
            };
            Assert.Equal(expected, SpiralMatrix.GetMatrix(9));
        }
    }
}