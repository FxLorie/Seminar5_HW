// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных числе в массиве.

int CreateArray()
{
    Console.Write($"Количество элементов в массиве = ");
    int numberElements = Convert.ToInt32(Console.ReadLine());
    return numberElements;
}

void InputArray(int[] array)
{
    int min = 100;
    int max = 999;
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

void CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count += 1;
    }
    Console.WriteLine(count);
}

Console.Clear();
int[] array = new int[CreateArray()];
InputArray(array);
PrintArray(array);
CountEven(array);