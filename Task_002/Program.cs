// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int SumOddIndexElements(int[] array) 
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++) 
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine($"[{string.Join(", ",array)}]");
} 

var array = FillArray(5, -100, 100);
PrintArray(array);
System.Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях, равна {SumOddIndexElements(array)}.");