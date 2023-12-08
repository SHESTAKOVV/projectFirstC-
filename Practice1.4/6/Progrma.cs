namespace _6;

public class Program
{
    static void Main()
    {
        double a = 1.5; // Вещественное число a
        double b = -2.5; // Вещественное число b

        bool isInArea = CheckIfPointInArea(a, b);

        if (isInArea)
        {
            Console.WriteLine("Точка принадлежит заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не принадлежит заштрихованной области");
        }

        Console.ReadLine();
    }

    static bool CheckIfPointInArea(double x, double y)
    {
        // находится ли точка внутри области
        if (x >= -2 && x <= 2 && y >= -3 && y <= 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}