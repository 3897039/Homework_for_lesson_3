// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27        5 -> 1, 8, 27, 64, 125

int InputInt(string message)
{
    Console.Write($"{message} ");
    int value;
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int number = InputInt("Введите число N, для которого выдадим таблицу кубов чисел от 1 до N ");

for(int i = 1; i <= number; i++)
{
    int cube = i * i * i;
    Console.WriteLine($"{cube}");
}
