// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

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

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int DeltaX = x2 - x1;
    int DeltaY = y2 - y1;
    int DeltaZ = z2 - z1;
    return Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY + DeltaZ * DeltaZ);
}

int x1 = InputInt("Введите координату х точки А: ");
int y1 = InputInt("Введите координату y точки А: ");
int z1 = InputInt("Введите координату z точки А: ");
int x2 = InputInt("Введите координату х точки B: ");
int y2 = InputInt("Введите координату y точки B: ");
int z2 = InputInt("Введите координату z точки B: ");

double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точкой А{x1},{y1},{z1} и точкой В{x2},{y2},{z2} равно {distance}");
