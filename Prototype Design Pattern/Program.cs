using Prototype_Design_Pattern;

ServerConfiguration config = new ServerConfiguration();
config.OperationSystem = "Windown 10";
config.FileStorageUrl = "https://google.com/drive";

Console.WriteLine("-------------------------------------------------");

var configClone = (ServerConfiguration) config.Clone();
Console.WriteLine(configClone.GetDetail());

Console.WriteLine("-------------------------------------------------");


Car car = new Car();
car.Name = "Vinfast";
car.Model = "3";
car.Color = "Blue";

var carClone = (Car) car.Clone();
Console.WriteLine(carClone.GetDetail());