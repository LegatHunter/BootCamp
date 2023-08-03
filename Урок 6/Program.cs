// using System.Diagnostics;
// bool show = true;
// int n = 20;
// int max = 100;
// int[] array = new int[n];
// bool Check(int [] array)
// {
//     int size = array.Length;
//     for (int i = 0; i < size -1; i++)
//     {
//         if(array[i] > array[i + 1]) return false;
//     }
//     return true;
// }
// for (int i = 0; i < n; i++)
// {
//     array[i] = Random.Shared.Next(max);
// }
// if (show) System.Console.WriteLine($"[{String.Join(", ", array)}]");
// int [] arr1 = new int [n];
// int [] arr2 = new int [n];
// Array.Copy(array, arr1, n);
// Array.Copy(array, arr2, n);
// System.Console.WriteLine(Check(array));

// Stopwatch sw = new Stopwatch();
// sw.Start();

// for (int k = 0; k < n - 1; k++)
// {
//     for (int i = 0; i < n - 1 - k; i++)
//     {
//         if (arr1[i] > arr1[i + 1])
//         {
//             int temp = arr1[i];
//             arr1[i] = arr1[i + 1];
//             arr1[i + 1] = temp;
//         }
//     }
// }
// sw.Stop();
// System.Console.WriteLine($"arr1 - {Check(arr1)} {sw.ElapsedMilliseconds}ms");
// System.Console.WriteLine(Check(arr2));
// if (show) System.Console.WriteLine($"[{String.Join(", ", array)}]");

/*
Cортировка пузырьком
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
*/
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}