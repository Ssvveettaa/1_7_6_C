// Задача 42:
// Напишите программу, которая
// будет преобразовывать десятичное число в двоичное.
// 46 –> 101110
// 13 –> 1101
// 2  –> 10

int ConvertNumberDecimalToBinary(int num)
{
    int convertNum = 0;
    int i = 1;
    while (num > 0)
    {
        convertNum += num % 2 * i;
        num /= 2;
        i *= 10;
    }
    return convertNum;
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = ConvertNumberDecimalToBinary(number);

Console.WriteLine($"Десятичное число {number} в двоичном формате будет: {result}");
