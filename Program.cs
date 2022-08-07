
using FacadeDesignPattern;

Console.WriteLine("Facade Design Pattern");
Console.WriteLine("Facade is a structural design pattern that provides a simplified (but limited) interface to a complex system of classes, library or framework.");
Console.WriteLine();

var subSystemAlpha = new SubSystemAlpha();
var subSystemBeta = new SubSystemBeta();
var facade = new Facade(subSystemAlpha, subSystemBeta);

Client.ClientCode(facade);
