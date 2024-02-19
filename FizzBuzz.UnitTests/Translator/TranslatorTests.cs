using FizzBuzz.Services;
using FluentAssertions;

namespace FizzBuzz.UnitTests.Translator
{
    public class TranslatorTests
    {
        [Fact]
        public void WhenInvokedWithNumberDivisibleByThreeShouldReturnFizz()
        {
            var translator = new FizzBuzzTranslator();

            string result = "";
            Action act = () => result = translator.Translate(9);

            act.Should().NotThrow();
            result.Should().Be("Fizz");
            
        }

        [Fact]
        public void WhenInvokedWithNumberDivisibleByFiveShouldReturnBuzz()
        {
            var translator = new FizzBuzzTranslator();

            string result = "";
            Action act = () => result = translator.Translate(25);

            act.Should().NotThrow();
            result.Should().Be("Buzz");

        }

        [Fact]
        public void WhenInvokedWithNumberDivisibleByThreeAndFiveShouldReturnFizzBuzz()
        {
            var translator = new FizzBuzzTranslator();

            string result = "";
            Action act = () => result = translator.Translate(15);

            act.Should().NotThrow();
            result.Should().Be("Fizzbuzz");

        }
    }
}
