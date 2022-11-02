using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Determine_canBeDevidedBy3_getFoo()
        {
            int a = 33;
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            string actual = fooBarQixDeterminer.Determine(a);

            Assert.Equal("Foo", actual);
        }

        [Fact]
        public void Determine_canBeDevidedBy3and5_getFoo()
        {
            int a = 90;
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            string actual = fooBarQixDeterminer.Determine(a);

            Assert.Equal("FooBar", actual);
        }

        [Fact]
        public void Determine_canBeDevidedBy7_getFoo()
        {
            int a = 28;
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            string actual = fooBarQixDeterminer.Determine(a);

            Assert.Equal("Qix", actual);
        }

        [Fact]
        public void Determine_canBeDevidedBy2and5and7_getFoo()
        {
            int a = 105;
            FooBarQixDeterminer fooBarQixDeterminer = new FooBarQixDeterminer();

            string actual = fooBarQixDeterminer.Determine(a);

            Assert.Equal("FooBarQix", actual);
        }
    }
}