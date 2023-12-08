namespace _3;

public class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\gr622_sheeal\Desktop\numsTask3.txt");
        string[] numbers = lines[0].Split(',');
        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (string number in numbers)
        {
            int num = int.Parse(number);
            if (num == 0)
            {
                break;
            }
            if (num < min)
            {
                min = num;
            }
            if (num > max)
            {
                max = num;
            }
        }
        double result = (double)min / max;
        Console.WriteLine($"Отношение минимального и максимального элементов: {result}");
    }
}