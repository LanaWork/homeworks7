/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1,7 -> такого числа в массиве нет */
/*
int [,] GetArray(int rows, int columns)
{
    int [,] array = new int[rows, columns];
    Random arrayRandomValue = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = arrayRandomValue.Next(1, 10);
                }
            }
    return array;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write("{0,6}", array[i, j]);
        }
        Console.WriteLine();
    }
}

int [,] array = GetArray(4, 4);

void SearchArrayIndex (int userRow, int userColumn)
{
    if (userRow <= array.GetLength(0) - 1 && userColumn <= array.GetLength(1) - 1)
        Console.WriteLine($"Значение элемента в указанной позиции = [{userRow},{userColumn}] = {array[userRow,userColumn]}");
    else if (userRow > array.GetLength(0) - 1 || userColumn > array.GetLength(1) - 1)
        Console.WriteLine($"Такого элемента нет = [{userRow},{userColumn}]");
}

Console.WriteLine("Введите номер позиции элемента в двумерном массиве: ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер позиции элемента в двумерном массиве: ");
int userColumn = Convert.ToInt32(Console.ReadLine());
PrintArray(array);
SearchArrayIndex(userRow, userColumn);
*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int [,] GetArray(int rows, int columns)
{
    int [,] array = new int[rows, columns];
    Random arrayRandomValue = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = arrayRandomValue.Next(1, 10);
                }
            }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write("{0,6}", array[i, j]);
        }
        Console.WriteLine();
    }
}
void AverageArrayColumns(int[,] array)
{
    double result = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result = result + array[j, i];
        }
        Console.WriteLine($"Среднее арифметическое {i + 1} столбца {Math.Round(result / array.GetLength(0), 1)}");
        result = 0;
    }
}
Console.WriteLine("Введите колличество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
AverageArrayColumns(array);
