using Microsoft.Extensions.Logging;

namespace FizzBuzz.Services
{
    public class FizzBuzzRunner : IFizzBuzzRunner
    {
        private readonly ILogger<FizzBuzzRunner> _logger;
        private readonly IFizzBuzzTranslator _translator;
        public FizzBuzzRunner(ILogger<FizzBuzzRunner> logger,
                              IFizzBuzzTranslator translator)
        {
            if (logger is null)
                throw new ArgumentNullException(nameof(logger));
            if (translator is null)
                throw new ArgumentNullException(nameof(translator));

            _logger = logger;
            _translator = translator;
        }

        public void Run()
        {
            for (var i = 1; i <= 100; i++)
            {
                var output = _translator.Translate(i);

                _logger.LogInformation(output);
            }
        }
    }
}
