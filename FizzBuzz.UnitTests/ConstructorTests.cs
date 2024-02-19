using FizzBuzz.Services;
using FluentAssertions;

namespace FizzBuzz.UnitTests
{
    public class ConstructorTests
    {
        [Fact]
        public void WhenConstructedWithNullLoggerThenShouldThrowArgumentNullException()
        {
            Action act = () => new FizzBuzzRunner(logger: null);

            act.Should().Throw<ArgumentNullException>()
                .And.ParamName.Should().Be("logger");
        }
    }
}
