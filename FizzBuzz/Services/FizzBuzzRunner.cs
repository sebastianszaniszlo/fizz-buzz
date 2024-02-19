using Microsoft.Extensions.Logging;

namespace FizzBuzz.Services
{
    public class FizzBuzzRunner : IFizzBuzzRunner
    {
        private readonly ILogger<FizzBuzzRunner> _logger;
        public FizzBuzzRunner(ILogger<FizzBuzzRunner> logger)
        {
            if (logger is null)
                throw new ArgumentNullException(nameof(logger));

            _logger = logger;
        }

        public void Run()
        {
            for (var i = 1; i <= 100; i++) {
                if (i % 3 == 0)
                {
                    _logger.LogInformation("Fizz");
                }
                else if (i % 5 == 0)
                {
                    _logger.LogInformation("Buzz");
                }
                else if (i % 15 == 0)
                {
                    _logger.LogInformation("Fizzbuzz");
                }
                else
                {
                    _logger.LogInformation(i.ToString());
                }
            }
        }
    }
}
