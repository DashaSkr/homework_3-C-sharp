// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int x1 = EnterData("Введите координату x1 для первой точки: ");
int y1 = EnterData("Введите координату y1 для первой точки: ");
int z1 = EnterData("Введите координату z1 для первой точки: ");
int x2 = EnterData("Введите координату x2 для второй точки: ");
int y2 = EnterData("Введите координату y2 для второй точки: ");
int z2 = EnterData("Введите координату z2 для второй точки: ");
double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"A ({x1},{y1}, {z1}); B ({x2},{y2},{z2}) -> {distance}");
