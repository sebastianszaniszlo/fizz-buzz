using FizzBuzz.Services;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;

namespace FizzBuzz.UnitTests
{
    public class FizzBuzzRunnerTests
    {
        [Fact]
        public void WhenCalledShouldNotThrowException()
        {
            var logger = new Mock<ILogger<FizzBuzzRunner>>();

            var runner = new FizzBuzzRunner(logger: logger.Object);

            Action act = () => runner.Run();

            act.Should().NotThrow();            
        }
    }
}