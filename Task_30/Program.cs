﻿// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int number;
int i;
for (i = 1; i <= 8; i++)
{
    number = new Random().Next(0, 2);
    Console.Write ($"{number} ");
}

