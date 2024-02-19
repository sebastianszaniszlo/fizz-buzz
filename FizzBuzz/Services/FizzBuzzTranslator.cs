namespace FizzBuzz.Services
{
    public class FizzBuzzTranslator : IFizzBuzzTranslator
    {
        public string Translate(int input)
        {
            if (input % 15 == 0)
            {
                return "Fizzbuzz";
            }
            else if (input % 3 == 0)
            {
                return "Fizz";
            }
            else if (input % 5 == 0)
            {
                return "Buzz";
            }
            

            return input.ToString();
        }
    }
}
