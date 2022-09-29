// ﻿Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



string[] array = { "-2", "Monday", "123", "Wednes day" };

void ArrayStr(string[] masstring)
{
   Console.Write("[");
   for (int i = 0; i < array.Length; i++)
      if (array[i].Length >= 3)
      {
         if (i != array.Length - 1) Console.Write($"{array[i]}, ");
         else Console.WriteLine($"{array[i]}]");
      }
}

ArrayStr(array);
