// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

int CreateArray()
{
    Console.Write($"Количество элементов в массиве = ");
    int numberElements = Convert.ToInt32(Console.ReadLine());
    return numberElements;
}

void InputArray(int[] array)
{
    Console.Write($"Минимальное значение массива = ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Максимальное значение массива = ");
    int max = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

void SumOddIndexElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
        sum += array[i];
    Console.WriteLine(sum);
}

Console.Clear();
int[] array = new int[CreateArray()];
InputArray(array);
PrintArray(array);
SumOddIndexElements(array);