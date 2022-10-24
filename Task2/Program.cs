double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distanc = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));

    return distanc;
}
Console.WriteLine("Введите координаты первой точки");
bool isParsedXA = int.TryParse(Console.ReadLine(), out int xA);
bool isParsedYA = int.TryParse(Console.ReadLine(), out int yA);
bool isParsedZA = int.TryParse(Console.ReadLine(), out int zA);
Console.WriteLine("Введите координаты второй точки");
bool isParsedXB = int.TryParse(Console.ReadLine(), out int xB);
bool isParsedYB = int.TryParse(Console.ReadLine(), out int yB);
bool isParsedZB = int.TryParse(Console.ReadLine(), out int zB);

if (!isParsedXA || !isParsedYA || !isParsedXB || !isParsedYB || !isParsedZA || !isParsedZB)
{
    Console.WriteLine("Ошибка! Не правильо введены координаты");
    return;
}
double distanceDot = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками {distanceDot}");