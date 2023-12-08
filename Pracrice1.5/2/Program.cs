namespace _2;

public class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\gr622_sheeal\Desktop\numsTask2.txt");
        double[] numbers = lines[0].Split(';').Select(double.Parse).ToArray();
        string sNum = string.Join("; ", numbers);
        Array.Sort(numbers);
        File.WriteAllText(@"C:\Users\gr622_sheeal\Desktop\numsTask2.txt", sNum);

        Console.WriteLine("Числа были успешно отсортированы и записаны обратно в файл.");
    }
}