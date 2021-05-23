using System;

namespace Practic_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполнение массива ввиде шахмотной доски
            int[,] array1 = new int[8, 8];
            Console.WriteLine("Массив заполеный ввиде шахмотной доски");
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] = (i + j) % 2;
                    Console.Write(array1[i, j]);
                }
                Console.WriteLine();
            }

            //Запослнение массива случаными числами
            int[,] array2 = new int[10, 10];
            Random random = new Random();
            Console.WriteLine("\nМассив заполеный случаными числами");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = random.Next(1, 10);
                    Console.Write(array2[i, j]);
                }
                Console.WriteLine();
            }

            //Нахождение суммы каждой строки в массиве "array2"
            int[] sumRow = new int[10];
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    sumRow[i] += array2[i, j];
                }
            }

            //Вывод суммы строк
            Console.WriteLine("\nСумма строк массива");
            for (int i = 0; i < sumRow.Length; i++)
            {
                Console.Write($"Строка {i + 1}: {sumRow[i]}\n");
            }

            //Вывод простых чисел из массива "array2"
            bool simple = false;
            Console.WriteLine("\nВывод простых чисел: ");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    for (int k = 2; k < array2[i, j]; k++)
                    {
                        if (array2[i, j] % k == 0)
                        {
                            simple = true;
                            break;
                        }
                    }
                    if (simple == false)
                    {
                        Console.Write(array2[i, j] + " ");
                    }
                    else
                    {
                        simple = false;
                    }
                }
            }
        }
    }
}
