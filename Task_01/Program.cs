// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Проверка без применения строк
// 14212 -> нет   12821 -> да   23432 -> да

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

bool Validate(int number)
{
    if(number >= 10000 && number < 100000)
    {
        return true;
    }
    Console.WriteLine("Это число не пятизначное");
    return false;
}
int number = InputInt("Введите пятизначное число ");
int rev  = 0;
int dubl = number;
 while(number > 0)
 {
    int del = number % 10;
    rev = rev * 10 + del;
    number = number / 10;
 }

if(dubl == rev)
    {
        Console.WriteLine("-> да");
    }
    else
    {
        Console.WriteLine("-> нет");
    }    







