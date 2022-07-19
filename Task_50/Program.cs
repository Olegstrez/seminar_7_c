/* Задача 50. Напишите программу, которая на вход принимает
 позиции элемента в двумерном массиве, и возвращает значение
  этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */

int n = 3, m = 4, max = 100;

int[,] GetArray(int n, int m, int max)
{
    int[,] Array = new int[n, m];
    var rnd = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = rnd.Next(0, max);
        }
    }
    return Array;
}
void PrintArray(int[,] Array)
{
    
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"|");
            Console.Write($"{Array[i, j],3}");
        }
        Console.WriteLine();
    }
}


string CheckArray(int[,] Array, int n, int m)
{
    if (n < Array.GetLength(0) && n < Array.GetLength(1)) return Convert.ToString(Array[n, m]);
    return "такого числа в массиве нет ";

}

int[,] result = GetArray(n, m, max);
PrintArray(result);
Console.WriteLine(CheckArray(result, 2, 3));

