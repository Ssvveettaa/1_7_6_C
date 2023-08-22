// Задача 45:
// Напишите программу, которая
// будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyingArray(int[] originArr)
{
    int[] copyArr = new int[originArr.Length];
    for (int i = 0; i < copyArr.Length; i++)
        copyArr[i] = originArr[i];
    return copyArr;
}

void ZeroingArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = 0;
}

int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.Write("Исходный массив:            ");
Console.WriteLine("{0}", string.Join(", ", originalArray));

int[] copiedArray = CopyingArray(originalArray);
Console.Write("Скопированный массив:       ");
Console.WriteLine("{0}", string.Join(", ", copiedArray));

ZeroingArray(originalArray);
Console.Write("Обнуленный исходный массив: ");
Console.WriteLine("{0}", string.Join(", ", originalArray));

Console.Write("Опять скопированный массив: ");
Console.WriteLine("{0}", string.Join(", ", copiedArray));
