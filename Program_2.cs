
Console.Clear();
int getNumber (string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число, введите число!";

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result)) 
        {
            break;
        }
        else 
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

int x1 = getNumber("Введите координату X первой точки: ");
int y1 = getNumber("Введите координату Y первой точки: ");
int z1 = getNumber("Введите координату Z первой точки: ");

Console.WriteLine("");

int x2 = getNumber("Введите координату X второй точки: ");
int y2 = getNumber("Введите координату Y второй точки: ");
int z2 = getNumber("Введите координату Z второй точки: ");

Console.WriteLine("Координаты первой точки: " + x1 + ", " + y1 + ", " + z1);
Console.WriteLine("Координаты второй точки: " + x2 + ", " + y2 + ", " + z2);

double result = Math.Round(Math.Sqrt(((x1 - x2)*(x1 - x2)) + ((y1 - y2)*(y1 - y2)) + ((z1 - z2)*(z1 - z2))), 2);

Console.WriteLine("Расстояние между точками: " + result);