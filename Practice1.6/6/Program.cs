namespace _6;

public class Program
{
    static void Main()
    {
        double[] arr = {6.66, 7.77, -6.66, -8.99, -4.44 };
        
        List<double> plusNumbers = new List<double>();
        List<double> minusNums = new List<double>();
        
        foreach (double number in arr)
        {
            if (number > 0)
            {
                plusNumbers.Add(number);
            }
            else if (number < 0)
            {
                minusNums.Add(number);
            }
        }
        
        double[] plusArr = plusNumbers.ToArray(); 
        double[] minusArr = minusNums.ToArray();
        
        Console.WriteLine("Массив положительных чисел:");
        foreach (double number in plusArr)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Массив отрицательных чисел:");
        foreach (double number in minusArr)
        {
            Console.WriteLine(number);
        }
    }
}