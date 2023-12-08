namespace _1;

public class Program
{
    static public void Main()
    {
        string[] word = File.ReadAllLines(@"C:\Users\gr622_sheeal\Desktop\numsTask1.txt");

        foreach (string line in word)
        {
            string[] words = line.Split(' ');
            foreach (string fortniteWORDcup in words)
            {
                if (fortniteWORDcup.Length % 2 != 0)
                {
                    Console.Write($"{fortniteWORDcup};");
                }
            }
        } 
    }
}