namespace _2;

public class Program
{
    static void Main()
    {
        double sum = 0;
        bool stop = false;

        using (StreamReader nums = new StreamReader(@"D:\Эдик\Programming\C# bomb1\Practika\Practice1.4\2\numsTask2.txt"))
        {
            string line;
            while ((line = nums.ReadLine()) != null && !stop)
            {
                string[] numbers = line.Split(';');

                foreach (string number in numbers)
                {
                    double parsedNumber;
                    if (double.TryParse(number, out parsedNumber))
                    {
                        if (parsedNumber > 0)
                        {
                            sum += parsedNumber;
                        }
                        else if (parsedNumber == 0)
                        {
                            stop = true;
                            break;
                        }
                    }
                }
            }
        }
        Console.WriteLine("Сумма положительных элементов последовательности: " + sum);
    }
}
