//Быстрая сортировка

int[] QuickSort(int[] arr)
{
    if (arr.Length <= 1) return arr;
    else
    {
        int pivot = arr[0];
        int countLeft = 0;
        int countRight = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < pivot)
            {
                countLeft++;
            }
            else countRight++;
        }
        int[] left = new int[countLeft];
        int[] right = new int[countRight];

        int numLeft = 0;
        int numRight = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < pivot)
            {
                left[numLeft] = arr[i];
                numLeft++;
            }
            else
            {
                right[numRight] = arr[i];
                numRight++;
            }
        }

        // int [] left = arr.Skip(1).Where(x => x < pivot).ToArr();
        // int [] right = arr.Skip(1).Where(x => x >= pivot).ToArr();
        return QuickSort(left).Concat(new int[] {pivot}).Concat(QuickSort(right)).ToArray();
    }
}
int[] arr = {3, 4, 1, 6, 1, 2, 4, 6, 7};
int[] arr_result = QuickSort(arr);

foreach (var item in arr_result)
{
    System.Console.Write($"{item}");
}