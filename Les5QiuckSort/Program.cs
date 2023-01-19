/*
1. arr = {1, 0, -6, 2, 5, 3, 2}
2. выбор опороного элемента (pivot). 
обычно первый или последний
arr[6] это pivot
3. вызвать шаги 1 и 2 для массивов слева 
от pivot и справа от pivot
*/
int[] arr = { 0, -5, 2, 3, 5, 9, 3, -1, 7, 7 };
int[] res = QuickSort(arr, 0, arr.Length - 1);
Console.WriteLine($"Отсортированный массив:[{string.Join(", ", res)}]");
int[] QuickSort(int[] inputArray, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return inputArray;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot - 1);
    QuickSort(inputArray, pivot + 1, maxIndex);
    return inputArray;
}
int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = maxIndex;
    for (int i = maxIndex - 1; i > minIndex - 1; i--)
    {
        if (inputArray[i] > inputArray[maxIndex])
        {
            Swap(inputArray, i, pivotIndex);
        }
    }
    return pivotIndex;
}
void Swap(int[] inputArray, int leftValue, int rightValue)
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}
