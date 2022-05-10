// See https://aka.ms/new-console-template for more information
using _02_AbstractFactory;
using _02_AbstractFactory.Factories;

DbClient dbClient = new DbClient(new OracleFactory(),"Server=.; database = Db; UserId = admin; password = 1234");
dbClient.DoJob("SELECT * FROM PRODUCT");
