using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            //Завдання 1
            //double[] A = new double[5];
            //double[,] B = new double[3, 4];

            //Console.WriteLine("Введіть значення для масиву A (5 елементів):");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"Елемент {i + 1}: ");
            //    A[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //Random rand = new Random();
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        B[i, j] = rand.NextDouble() * 100;
            //    }
            //}

            //Console.WriteLine("\nМасив A:");
            //foreach (double item in A)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("\n\nМасив B:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(B[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //double maxA = A[0];
            //double minA = A[0];
            //double maxB = B[0, 0];
            //double minB = B[0, 0];

            //foreach (double item in A)
            //{
            //    if (item > maxA)
            //        maxA = item;
            //    if (item < minA)
            //        minA = item;
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (B[i, j] > maxB)
            //            maxB = B[i, j];
            //        if (B[i, j] < minB)
            //            minB = B[i, j];
            //    }
            //}

            //double sumA = 0;
            //double sumB = 0;
            //double productA = 1;
            //double productB = 1;

            //foreach (double item in A)
            //{
            //    sumA += item;
            //    productA *= item;
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        sumB += B[i, j];
            //        productB *= B[i, j];
            //    }
            //}

            //double evenSumA = 0;
            //foreach (double item in A)
            //{
            //    if (item % 2 == 0)
            //        evenSumA += item;
            //}

            //double oddColumnSumB = 0;
            //for (int j = 0; j < 4; j++)
            //{
            //    if (j % 2 != 0)
            //    {
            //        for (int i = 0; i < 3; i++)
            //        {
            //            oddColumnSumB += B[i, j];
            //        }
            //    }
            //}

            //Console.WriteLine("\nМаксимальний елемент у масиві A:" + maxA);
            //Console.WriteLine("Мінімальний елемент у масиві A:" +minA);
            //Console.WriteLine("Максимальний елемент у масиві B:" + maxB);
            //Console.WriteLine("Мінімальний елемент у масиві B:" +minB);
            //Console.WriteLine("Загальна сума елементів у масиві A:" + sumA);
            //Console.WriteLine("Загальна сума елементів у масиві B:" + sumB);
            //Console.WriteLine("Загальний добуток елементів у масиві A:" + productA);
            //Console.WriteLine("Загальний добуток елементів у масиві B:" + productB);
            //Console.WriteLine("Сума парних елементів масиву A:" + evenSumA);
            //Console.WriteLine("Сума непарних стовпців масиву B:" + oddColumnSumB);

            //Console.ReadLine();








            //Завдання 2

            //int[,] array = new int[5, 5];
            //Random random = new Random();

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        array[i, j] = random.Next(-100, 101);
            //    }
            //}

            //int min = int.MaxValue, max = int.MinValue;
            //int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (array[i, j] < min)
            //        {
            //            min = array[i, j];
            //            minRow = i;
            //            minCol = j;
            //        }
            //        if (array[i, j] > max)
            //        {
            //            max = array[i, j];
            //            maxRow = i;
            //            maxCol = j;
            //        }
            //    }
            //}

            //int sum = 0;
            //for (int i = minRow; i <= maxRow; i++)
            //{
            //    for (int j = minCol; j <= maxCol; j++)
            //    {
            //       if (i == minRow && j == minCol)
            //       {
            //           continue;    //я так зрозуміла що continue виконує ту саму функцію в с# як і в с++
            //       }
            //        if (i == maxRow && j == maxCol) break;
            //        sum += array[i, j];
            //    }
            //}

            //Console.WriteLine("Сума елементів між мінімальним і максимальним елементами дорівнює: " + sum);







            //Завдання 3
            //Console.WriteLine("Введіть текст:");
            //string text = Console.ReadLine().ToLower();

            //Console.WriteLine("Введіть ключ (зсув):");
            //int key = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Введіть 'encode' для шифрування або 'decode' для розшифрування:");
            //string action = Console.ReadLine();

            //string result = "";

            //foreach (char symbol in text)
            //{
            //    if (symbol >= 'a' && symbol <= 'z')
            //    {
            //        int newSymbolCode = (symbol - 'a' + (action == "encode" ? key : -key)) % 26;
            //        result += (char)('a' + newSymbolCode);
            //    }
            //    else
            //    {
            //        result += symbol;
            //    }
            //}

            //Console.WriteLine("Результат: " + result);
            }
        }
 }