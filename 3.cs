using System;

public class CC3
{
    public static int[,] GetArray(int n)
    {
        int[,] Array2 = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    Array2[i, j] = 0;
                }
                if (i < j)
                {
                    Array2[i, j] = 1;
                }
                if (i > j)
                {
                    Array2[i, j] = -1;
                }

            }
        }
        return Array2;
    }
    public static void Main(string[] Args)
    {
        int n;
        Console.WriteLine("Enter the Number:");
        n = Convert.ToInt32(Console.ReadLine());
        int[,] Array = new int[n, n];
        Array = GetArray(n);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\n");
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}\t", Array[i, j]);

            }
            Console.WriteLine("\n\n");
        }
    }
}
