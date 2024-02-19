namespace FizzBuzz.Services
{
    public class FizzBuzzTranslator : IFizzBuzzTranslator
    {
        public string Translate(int input)
        {
            if (input % 3 == 0)
            {
                return "Fizz";
            }
            else if (input % 5 == 0)
            {
                return "Buzz";
            }
            else if (input % 15 == 0)
            {
                return "Fizzbuzz";
            }

            return input.ToString();
        }
    }
}
