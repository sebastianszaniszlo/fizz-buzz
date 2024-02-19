using FizzBuzz.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz;
class Program
{
    static void Main(string[] args)
    {
        IServiceCollection services = new ServiceCollection();
        Startup startup = new Startup();
        startup.ConfigureServices(services);
        IServiceProvider serviceProvider = services.BuildServiceProvider();

        // Start FizzBuzz service
        var fizzBuzzService = serviceProvider.GetService<IRunner>();

        //TODO(Seb): Wrap in try catch?
        fizzBuzzService?.Run();
        Console.ReadLine();

    }
}