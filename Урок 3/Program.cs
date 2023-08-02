int [] array = new int [5];
for (int i = 0; i < 5; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
System.Console.WriteLine(array[3]);
// Сложность алгоритма О(1)
