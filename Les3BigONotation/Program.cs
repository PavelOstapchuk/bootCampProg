// int n = 5;
// int [] array = new int[n];
// for (int i = 0; i < n; i++)
// {
//     array[i]= Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine(array[3]);
// // время работы программы 
// // сложность алгоритма - О Нотация (O Notation) 
// // данный алгоритм работает O(1) - количестов действий, что бы узнать конечный резльтат - 1 действие.

// int sum = 0;
// for (int i = 0; i < n; i++)
// {
//     sum+=array[i];
// }
// Console.WriteLine(sum);
// // в данном алгоритем: 0(n) или О(5) - при n = 5.

int m = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{(j + 1) * (i + 1)}\t");// \t - Для вывода ронвыми колонками церез табуляцию
    }
    Console.WriteLine();
}
// O(n^2)

int[,] matrix = new int[m, m];
for (int i = 0; i < m; i++)
{
    for (int j = i; j < m; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        //matrix[j, i] = (i + 1) * (j + 1);
        matrix[j, i] = matrix[i, j];
    }
}
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{matrix[i, j]}\t");// \t - Для вывода ронвыми колонками церез табуляцию
    }
    Console.WriteLine();
}
// O(n^2/2)