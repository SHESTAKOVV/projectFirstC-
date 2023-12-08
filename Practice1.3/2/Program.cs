namespace _2;

public class Program
{
    static void Main()
    {
        string file = @"C:\Users\gr622_sheeal\Desktop\nums.txt";
        string[] numCheck = File.ReadAllLines(file);
        Console.WriteLine("Исходные числа:");
        PrintNumbers(numCheck);
        
        for (int i = 0; i < numCheck.Length; i++)
        {
            string[] numbers = numCheck[i].Split(' ');
            string numAdd = "";

            foreach (string number in numbers)
            {
                int num = int.Parse(number);
                if (num % 2 != 0)
                {
                    numAdd += number + " ";
                }
            }
            numCheck[i] = numAdd.Trim();
        }

        Console.WriteLine("Результат:");
        PrintNumbers(numCheck);
        
        File.WriteAllLines(file, numCheck);

        Console.ReadLine();
    }
    static void PrintNumbers(string[] lines)
    {
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
