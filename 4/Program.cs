// Найти точку пересечения двух прямых заданных уравнением 
//y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.Write("Введите k1: ");
var k1 = double.Parse(Console.ReadLine()?? "0");
Console.Write("Введите b1: ");
var b1 = double.Parse(Console.ReadLine()?? "0");

Console.Write("Введите k2: ");
var k2 = double.Parse(Console.ReadLine()?? "0");
Console.Write("Введите b2: ");
var b2 = double.Parse(Console.ReadLine()?? "0");

if (k1 == k2)
if (b1 == b2)
{
    Console.WriteLine("Прямые одинаковы");
}
else
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
    var x = (b2 - b1) / (k1 - k2);
    var y = k1 * x + b1;

    Console.WriteLine($"Прямые пересекаются в точке ({x} и {y})");
}