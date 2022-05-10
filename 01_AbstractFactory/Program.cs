using _01_AbstractFactory;

FactoryManager factoryManager = new FactoryManager();
IFactory factory = factoryManager.CreateFactory(FactoryTypes.ComputerFactory1);
Processor processor = factory.CreateProcessor();
_01_AbstractFactory.Monitor Monitor = factory.CreateMonitor();

