// Задача 39:
// Напишите программу, которая
// перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый – на последнем и т.д.).
// [1 2 3 4 5] –> [5 4 3 2 1]
// [6 7 3 6]   –> [6 3 7 6]

int[] CreateArrayRandomInt(int size, int min, int max)
{
    int[] arr = new int[size];
    var random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(min, max + 1);
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

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i]; // temporary
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

// int[] array = { 1, 2, 3, 4, 5 }; // –> [5 4 3 2 1]
// int[] array = { 6, 7, 3, 6 }; // –> [6 3 7 6]
int[] array = CreateArrayRandomInt(5, 1, 9);
OutputArray(array);
Console.WriteLine();

// Array.Reverse(array); // Встроенный метод переворота массива.
ReverseArray(array);
OutputArray(array);
Console.WriteLine();
