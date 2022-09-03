﻿// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] PrintArray()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}

int Sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] arr = PrintArray();
System.Console.WriteLine("[{0}]", string.Join(", ", arr));
System.Console.WriteLine(Sum(arr));




