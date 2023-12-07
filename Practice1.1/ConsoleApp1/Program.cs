namespace ConsoleApp1;

public class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] num = new int[10];
        int minNumber = 0;
        
        for (int i = 0; i < 10; i++)
        {
            num[i] = random.Next(1, 100);
        }
        
        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] < num[minNumber])
            {
                minNumber = i;
            } 
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i + 1}) {num[i]}");
        }
        Console.WriteLine("номер:" + (minNumber + 1));
    }
}