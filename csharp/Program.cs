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