// See https://aka.ms/new-console-template for more information

using _01_Singleton;

Singleton singleton1 = Singleton.GetInstance();
Singleton singleton2 = Singleton.GetInstance();

if (singleton1.Equals(singleton2))
    Console.WriteLine("Equal");
else
    Console.WriteLine("Not Equal");
