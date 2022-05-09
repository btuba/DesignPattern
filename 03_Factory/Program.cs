// See https://aka.ms/new-console-template for more information
using _03_Factory.Lib;


LoggerManager loggerManager = new LoggerManager(); // statik de olabilir
ILoggerFactory loggerFactory = loggerManager.CreateFactory(LogTypes.FileLogger);
ILogger logger = loggerFactory.Create();
Console.WriteLine(logger.Log("Hello world!"));


