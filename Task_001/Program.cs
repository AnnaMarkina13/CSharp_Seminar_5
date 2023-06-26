// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] FillArray(int length, int leftRange, int rightRange) 
{
    var array = new int[length]; 
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange);
    }
    return array;
}

int CountEvenNumbers(int[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine($"[{string.Join(", ",array)}]");
} 

var array = FillArray(4, 100, 1000);
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел в массиве - {CountEvenNumbers(array)}.");
