﻿Console.Clear();
Console.Write("Введите первое число ");
int input_number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int input_number_2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число ");
int input_number_3 = int.Parse(Console.ReadLine());
int max = input_number_1;
if(max<input_number_2) max = input_number_2;
if(max<input_number_3) max = input_number_3;
Console.Write($"Максимальное число: {max}");