﻿/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
Console.WriteLine("Воспользуемся формулой возведения в степень: A^B");
int numA = ReadInt("Введите число A: ");
int numB = ReadInt("Введите число B: ");
ToDegree(numA, numB);


void ToDegree(int a, int b) //Возведение в степень
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}


int ReadInt(string message) // Функция ввода
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}