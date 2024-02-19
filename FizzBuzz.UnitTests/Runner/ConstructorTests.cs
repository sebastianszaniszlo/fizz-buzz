using FizzBuzz.Services;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;

namespace FizzBuzz.UnitTests.Runner
{
    public class ConstructorTests
    {
        [Fact]
        public void WhenConstructedWithNullLoggerThenShouldThrowArgumentNullException()
        {
            var translator = Mock.Of<IFizzBuzzTranslator>();

            Action act = () => new FizzBuzzRunner(logger: null, translator: translator);

            act.Should().Throw<ArgumentNullException>()
                .And.ParamName.Should().Be("logger");
        }

        [Fact]
        public void WhenConstructedWithNullTranslatorThenShouldThrowArgumentNullException()
        {
            var logger = Mock.Of<ILogger<FizzBuzzRunner>>();

            Action act = () => new FizzBuzzRunner(logger: logger, translator: null);

            act.Should().Throw<ArgumentNullException>()
                .And.ParamName.Should().Be("translator");
        }
    }
}
