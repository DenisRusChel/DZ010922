// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] PrintArray()
{
    double[] array = new double[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    System.Console.Write("[{0}]", string.Join(", ", array));
    return array;
}

double[] arr = PrintArray();

double maxValue = arr.Max<double>();
double minValue = arr.Min<double>();


System.Console.WriteLine($" → {maxValue - minValue}");







