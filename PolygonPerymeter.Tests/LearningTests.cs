using System;
using System.Collections.Generic;
using Xunit;
using Moq;

namespace PolygonPerymeter.Tests
{
    public interface ITestOne
    {
        public int Add(int a, int b) => a + b;
        public void Out(string msg);
               
    }

    public class MathOne
    {
        private readonly ITestOne testOne;
        public MathOne(ITestOne testOne)
        {
            this.testOne = testOne;
        }

        public int Add(int a, int b) => testOne.Add(a, b);

        public void Out(string msg) => testOne.Out(msg);
    }


    public class MathOneTests
    {
        [Fact]
        public void MathOneAddsTwoNumbers()
        {
            //определяем поведение интерфейса ITestOne 
            var testOneMock = new Mock<ITestOne>();
            testOneMock.Setup(x => x.Add(1, 1)).Returns(2);

            var mathOne = new MathOne(testOneMock.Object);
            Assert.Equal(2, mathOne.Add(1, 1));
        }

        //[Fact]
        //public void Verify_TestOne_Out_FunctionCall()
        //{
        //    var testOneMock = new Mock<ITestOne>();
        //    var mathOne = new MathOne(testOneMock.Object);
        //    mathOne.Out();

        //    testOneMock.Verify(x => x.Out(), Times.Exactly(1));
        //}

        [Fact]
        public void Verify_TestOne_Out_FunctionCallWithOutput()
        {
            var testOneMock = new Mock<ITestOne>();
            var mathOne = new MathOne(testOneMock.Object);
            var msg = "Some Text";
            mathOne.Out(msg);

            testOneMock.Verify(x => x.Out(msg), Times.Exactly(1));
        }
    }

    public class TestOne : ITestOne
    {
        public int Add(int a, int b) => a + b;

        public void Out(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    public class TestOneTests
    {
        [Fact]
        public void Add_AddsTwoNumbersTogether()
        {
            var testOne = new TestOne();
            var result = testOne.Add(1, 1);
            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(0, 3, 3)]
        [InlineData(0, 1, 1)]
        public void Add_AddsTwoNumbersTogether_Theory(int a, int b, int expected)
        {
            var testOne = new TestOne();
            var result = testOne.Add(a, b);
            Assert.Equal(expected, result);
        }

        public void TestListContainsValue()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            Assert.Contains(3, list);
        }
    }
}
