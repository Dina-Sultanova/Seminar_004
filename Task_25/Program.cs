// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги. Решаем строго через цикл

Console.WriteLine ("Введите число A: ");a
int B = Convert.ToInt32(Console.ReadLine());
int res = 1;

if (B >= 0)
{
for (int i = 1; i <= B; i++)
{
    res = res * A;
}
Console.WriteLine ($"Число А, возведенное в степень В, равно {res}");
}
else
{
    Console.WriteLine ("Введено некорректное число B");
}


