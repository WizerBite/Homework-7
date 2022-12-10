/*
Задача 53:  Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.

Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/

int new_value()
{
    return int.Parse(Console.ReadLine());
}

void f_arr(int[] arr, int min, int max) // запись массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min,max);
    }
}

void write_arr(int[] arr) // вывод массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void f_2_arr(int[,] arr, int min, int max) // запись двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
}   

void write_2_arr(int[,] arr) // вывод двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}\t");
        }               
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] default_2_arr()
{
    Console.WriteLine("Введите количество строк массива");
    int SIZE1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива");
    int SIZE2 = int.Parse(Console.ReadLine());
    int[,] arr = new int[SIZE1, SIZE2];
    f_2_arr(arr, 0, 10);
    write_2_arr(arr);
    return arr;
}

void task1()
{
    Console.WriteLine("Введите количество строк массива");
    int SIZE1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива");
    int SIZE2 = int.Parse(Console.ReadLine());
    double[,] arr = new double[SIZE1, SIZE2];
    for (int i = 0; i < SIZE1; i++)
    {
        for (int j = 0; j < SIZE2; j++)
        {
            int a = new Random().Next(0, 100);
            int b = new Random().Next(0, 100);
            double double_b = b;
            int xCount = 1;
            
            while (double_b > 1)
            {
                double_b *= 0.1;
                xCount++;
            }
            arr[i,j] = a + double_b;
            Console.Write($"{Math.Round(arr[i, j], xCount)}\t");
        }
        Console.WriteLine();
    }
}

void task2()
{
    int[,] arr = default_2_arr();
    Console.WriteLine("Введите строку элемента (начиная с 0)");
    int SIZE1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите столбец элемента (начиная с 0)");
    int SIZE2 = int.Parse(Console.ReadLine());

    if (arr.GetLength(0) - 1 <= SIZE1 || arr.GetLength(1) - 1 <= SIZE2)
    {
        Console.WriteLine($"Эллемент под индексом [{SIZE1},{SIZE2}] = {arr[SIZE1, SIZE2]}");
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
    }
}

void task3()
{
    int[,] arr = default_2_arr();
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double avg = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            avg += arr[j, i];
        }
        Console.Write($"{Math.Round(avg/arr.GetLength(0), 2)} ");
    }
}


while (true)
{ 
    Console.Write("Введите номер задачи: ");
    int num = int.Parse(Console.ReadLine());
    switch(num)
    {
        case 1:
            {
                task1();
                break;
            }
        case 2:
            {
                task2();
                break;
            }
        case 3:
            {
                task3();
                break;
            }
    }    
}
