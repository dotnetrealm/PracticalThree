using Abstraction;

Console.WriteLine("Task-3: Abstraction");
Console.WriteLine("===================");

Laptop laptop = new();

laptop.Model = "Ideapad S340";
laptop.Brand = "Lenovo";

laptop.LaptopDetails();

// [ERR]: Inaccessible due to it's protection level
// laptop.MotherBoardInfo();

Console.ReadLine();