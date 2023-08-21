// Задача 40:
// Напишите программу, которая
// принимает на вход три числа
// и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника:
// каждая сторона треугольника меньше суммы двух других сторон.

bool IsExistTriangle(int a, int b, int c)
{
    return a < b + c && b < c + a && c < a + b;
}

Console.Write("Введите длину 1-й стороны треугольника: ");
int lengthSide1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину 2-й стороны треугольника: ");
int lengthSide2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину 3-й стороны треугольника: ");
int lengthSide3 = Convert.ToInt32(Console.ReadLine());

bool result = IsExistTriangle(lengthSide1, lengthSide2, lengthSide3);

Console.WriteLine(result ? "Может существовать треугольник со сторонами такой длины." : "Не может существовать треугольник со сторонами такой длины.");
