namespace _2;

public class Program
{
    static public void Main()
    {
        string[] word = File.ReadAllLines(@"C:\Users\gr622_sheeal\Desktop\numsTask2.txt");
        foreach (string line in word)
        {
            string[] words = line.Split(' ');
            foreach (string fortniteWORDcup in words)
            { 
                Console.Write($"{fortniteWORDcup} ");
            }
        }
    }
}