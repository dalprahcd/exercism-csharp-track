// This file was auto-generated based on version 1.1.0 of the canonical data.

using Xunit;

namespace Exercism.CSharp.Solutions.HelloWorldExercise.Tests
{
    public class HelloWorldTests
    {
        [Fact]
        public void Say_hi_()
        {
            Assert.Equal("Hello, World!", HelloWorld.Hello());
        }
    }
}