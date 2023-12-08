namespace _5;

public class Program
{
    static void Main()
    {
        double a = 2.5; 
        double b = 1.5; 

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
        if (x >= -1 && x <= 3 && y >= -2 && y <= 4)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}