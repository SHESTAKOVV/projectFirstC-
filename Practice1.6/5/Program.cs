namespace _5;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк (n):");
        int n = int.Parse(Console.ReadLine());                   

        Console.WriteLine("Введите количество столбцов (m):");
        int m = int.Parse(Console.ReadLine());                 

        int[,] matrix = new int[n, m];
        Console.WriteLine("Введите элементы матрицы (0 или 1):");
        for (int i = 0; i < n; i++)                              
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int[,] newMatrix = new int[n, m + 1];
        for (int i = 0; i < n; i++)
        {
            int countOnes = 0;
            for (int j = 0; j < m; j++)
            {
                newMatrix[i, j] = matrix[i, j];
                if (matrix[i, j] == 1)
                    countOnes++;
            }
            newMatrix[i, m] = countOnes % 2 == 0 ? 0 : 1;
        }
        Console.WriteLine("Ваша новая матрица с дополнительным столбом:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write(newMatrix[i, j] + " ");
            }
        }
    }
}