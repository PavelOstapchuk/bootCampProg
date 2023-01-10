using System.Diagnostics;
// 1 5 4 1 3 4 7 4 1 2
// m=3
// max -> 15
// найти макс сумму трех подряд идущих элементов в массиве
Console.Clear();
int size = 10;
int m = 2;
int[] array = Enumerable.Range(1, size)
                        .Select(item => Random.Shared.Next(10))
                        .ToArray();
Console.WriteLine($"[{string.Join(", ", array)}]");
Stopwatch sw = new();
sw.Start();
int max = 0;
for (int i = 0; i < m; i++)
{
    max += array[i];
}
int max1 = max;
for (int j = 0; j < array.Length - m; j++)
{
    max1 = max1 - array[j] + array[j + m];
    if (max1 > max) max = max1;
    Console.WriteLine(max1);
}
sw.Stop();
Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
Console.WriteLine(max);
