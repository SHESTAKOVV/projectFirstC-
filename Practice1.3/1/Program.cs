namespace _1;

public class Program
{
    static void Main(string[] args)
    {
        string[] nums = File.ReadAllLines(@"D:\Эдик\Programming\C# bomb1\Practika\Practice1.3\1\input.txt");

        int[] numCheck = Array.ConvertAll(nums[0].Split(' '), int.Parse);
        int n = int.Parse(nums[1]);

        string[] results = new string[n];

        for (int i = 2; i < n + 2; i++)
        {
            int[] ticket = Array.ConvertAll(nums[i].Split(' '), int.Parse);
            int count = 0;

            foreach (int number in ticket)
            {
                if (Array.IndexOf(numCheck, number) != -1)
                {
                    count++;
                }
            }

            if (count >= 3)
            {
                results[i - 2] = "Lucky";
            }
            else
            {
                results[i - 2] = "Unlucky";
            }

            Console.WriteLine();
        }

        File.WriteAllLines(@"D:\Эдик\Programming\C# bomb1\Practika\Practice1.3\1\output.txt", results);
    }
}