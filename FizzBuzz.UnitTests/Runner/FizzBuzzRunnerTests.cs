using FizzBuzz.Services;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;

namespace FizzBuzz.UnitTests.Runner
{
    public class FizzBuzzRunnerTests
    {
        [Fact]
        public void WhenCalledShouldNotThrowException()
        {
            var logger = new Mock<ILogger<FizzBuzzRunner>>();
            var translator = Mock.Of<IFizzBuzzTranslator>();

            var runner = new FizzBuzzRunner(logger: logger.Object, translator: translator);

            Action act = () => runner.Run();

            act.Should().NotThrow();
        }
    }
}