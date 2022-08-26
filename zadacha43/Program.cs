/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Введите значение b1: ");
decimal b1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
decimal k1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
decimal b2 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
decimal k2 = decimal.Parse(Console.ReadLine());

decimal Seachx(decimal a, decimal c, decimal d, decimal e)
{
    decimal x = 0;
    x = (d - a) / (c - e);
    return x;
}

decimal Seachy(decimal a, decimal c, decimal d, decimal e)
{
    decimal x = Seachx(b1, k1, b2, k2);
    decimal y = c * x + a;
    decimal y1 = e * x + d;
    if (y != y1)
    {
        Console.WriteLine("Внимание где-то ошибка");
    }

    return y;
}

Console.WriteLine($"Точка пересечения( {Seachx(b1, k1, b2, k2)} ;{Seachy(b1, k1, b2, k2)})");



