// int n = 5;
// int [] array = new int [n];
// for (int i = 0; i < 5; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// System.Console.WriteLine(array[3]);
// Сложность алгоритма О(1)
// [4, 5, 3, 1, 2]
// O(n)
// [1, 2, 3, 4, 5] - O(n * log n)
// ((5 + 1) / 2) * 5 - O(1)

// Таблица умножения
// O(n^2)
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n,n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        // System.Console.Write(i*j);
        // System.Console.Write("\t");
        if (i + j <= n)
        {
            matrix[i,j] = (i + 1) * (j + 1);
            matrix[j,i] = (i + 1) * (j + 1);
        }
    }
    System.Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        System.Console.Write(matrix[i,j]);
        System.Console.Write(" ");
    }
    System.Console.WriteLine();
}