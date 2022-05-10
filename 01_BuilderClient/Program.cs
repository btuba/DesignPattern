using _01_Builder.Lib.v1;
using _01_Builder.Lib.v2;
using _01_Builder.Lib.v3;
using _01_Builder.Lib.v4;

#region v1

//Agency agency = new Agency();
//Policy policy = agency.Construct("Buse", "Tuba");
//Console.WriteLine(policy.Print());

IPolicyBuilder _builder = new PolicyBuilder();
Policy policy = _builder.BuildPolicy("Buse", "Tuba");
Console.WriteLine(policy.Print());

//Policy policy1 = new Policy(); // ctor'ları kapatarak engelleyebilirsin
// v3 de çözümü 
#endregion

#region v2

IPolicyBuilder2 policyBuilder2 = new PolicyBuilder2();
Policy policy2 = policyBuilder2.BuildPolicy("Setu", "Marty", 500);
Console.WriteLine(policy2.Print());

#endregion

#region v3

Car car = Car.GetCarBuilder().BuildCar("BMW", "I3");

#endregion

#region v4 (fluent yaklasım)

IComputerBuilder builder = new ComputerBuilder();

//Computer computer = builder.BuildGPU("AMD")
//    .BuildCPU("Intel");

Computer computer = builder.BuildGPU("AMD")
    .BuildCPU("Intel").Build();

#endregion

