// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.


int CreateArray()
{
    Console.Write($"Количество элементов в массиве = ");
    int numberElements = Convert.ToInt32(Console.ReadLine());
    return numberElements;
}

void InputArray(double[] array)
{
    Console.Write($"Минимальное значение массива = ");
    double min = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Максимальное значение массива = ");
    double max = Convert.ToDouble(Console.ReadLine());
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
}

void PrintArray(double[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}


//Первый вариант

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

// Console.Clear();
// double[] array = new double[CreateArray()];;
// InputArray(array);
// PrintArray(array);
// Console.WriteLine(Math.Round((FindMax(array) - FindMin(array)), 2));

//Второй вариант

double FindMaxMinDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    return Math.Round(max - min, 2);
}

Console.Clear();
double[] array = new double[CreateArray()];
InputArray(array);
PrintArray(array);
Console.WriteLine(FindMaxMinDiff(array));