// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Product product = new Product(new FileLogger());
product.logger.Log();


// Dependency Inversion
// Dependency Injection
// IoC => inversion of control
// IoC Container

class Product{
    public ILogger logger;

    public Product(ILogger logger)
    {
        this.logger = logger;
    }
}

interface ILogger
{
    void Log();
}

class FileLogger : ILogger
{
    public void Log()
    {
        throw new NotImplementedException();
    }
}