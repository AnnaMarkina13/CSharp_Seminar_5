// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] FillArray(int length) 
{
    var array = new double[length]; 
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * 100, 2);
    }
    return array;
}

void MaxMinDifference(double[] array, out double min, out double max, out double dif)
{
    min = array[0];
    max = array[0];
    dif = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) 
        {
            max = array[i];
        } 
        else if (array[i] < min) 
        {
            min = array[i];
        }
    }

    dif = Math.Round(max - min, 2);
}

void PrintArray(double[] array)
{
    System.Console.WriteLine($"[{string.Join(", ",array)}]");
} 

var array = FillArray(5);
PrintArray(array);
MaxMinDifference(array, out double minNumber, out double maxNumber, out double difference);
System.Console.WriteLine($"Разница между максимальным ({maxNumber}) и минимальным ({minNumber}) значениями массива равна {difference}. ");