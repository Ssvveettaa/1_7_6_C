// Задача 44:
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 –> 0 1 1 2 3
// Если N = 3 –> 0 1 1
// Если N = 7 –> 0 1 1 2 3 5 8

int[] CreateArrayFibonacciSeries(int size)
{
    int[] arr = new int[size];
    // arr[0] = 0; // По умолчанию массив заполнен нулями.
    if (arr.Length > 1) arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        checked { arr[i] = arr[i - 1] + arr[i - 2]; } // При переполнении типа выдаст ошибку вместо не верного результата.
    }
    return arr;
}

void OutputArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

Console.Write("Введите количество чисел для ряда Фибоначчи (натуральное число до 47): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int[] array = CreateArrayFibonacciSeries(number);

    Console.WriteLine($"Ряд Фибоначчи из {number} чисел:");
    OutputArray(array);
    Console.WriteLine();
}
else Console.WriteLine($"Число {number} не натуральное.");
