/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/


Console.WriteLine("Сколько чисел будите вводить?: ");
int N = int.Parse(Console.ReadLine());


int Podschot(int M)
{
    int count = 0;
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"Введите число {i} / {N}: ");
        int number = int.Parse(Console.ReadLine());
        if (number >= 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"Вы ввели: {Podschot(N)} положительных числа");



