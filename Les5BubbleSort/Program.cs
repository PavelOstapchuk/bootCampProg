/*
сорт пызурьком
начальный массив [3, 1, 5, 0, 7, 9, 8]
1[1, 3, 5, 0, 7, 9, 8]
2[1, 3, 0, 5, 7, 9, 8]
3[1, 0, 3, 5, 7, 9, 8]
4[0, 1, 3, 5, 7, 9, 8]
5[0, 1, 3, 5, 7, 8, 9]

 */

// Console.WriteLine("Количество элментов массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// Console.WriteLine("Введите значения массива:");

// for (int i = 0; i < n; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
// Console.WriteLine();
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n - 1; j++)
//     {
//     if (array[j + 1] < array[j])
//     {
//         int temp = array[j];
//         array[j] = array[j + 1];
//         array[j + 1] = temp;
//     }
//     }
//     Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
// }
// Console.WriteLine("Отсортированный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine("Количество элментов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Введите значения массива:");

for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
    if (array[j + 1] < array[j])
    {
        int temp = array[j];
        array[j] = array[j + 1];
        array[j + 1] = temp;
    }
    }
    Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}
Console.WriteLine("Отсортированный массив: [" + string.Join(", ", array) + "]");
