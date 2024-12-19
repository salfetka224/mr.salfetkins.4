using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1: Формирование нового массива из двух
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] resultArray1 = new int[10];

            Console.WriteLine("Введите 10 элементов для первого массива:");
            for (int i = 0; i < 10; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите 10 элементов для второго массива:");
            for (int i = 0; i < 10; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    resultArray1[i] = array1[i + 1]; 
                }
                else
                {
                    resultArray1[i] = array2[i - 1]; 
                }
            }

            Console.WriteLine("Результирующий массив:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(resultArray1[i] + " ");
            }
            Console.WriteLine();

            // Задача 2: Работа с массивом из 8 элементов
            int[] array8 = new int[8];
            int[] digitsArray = new int[24]; 
            int k = 0;

            Console.WriteLine("Введите 8 двузначных чисел для массива:");
            for (int i = 0; i < 8; i++)
            {
                array8[i] = int.Parse(Console.ReadLine());
                int number = array8[i];

                
                while (number > 0)
                {
                    digitsArray[k] = number % 10;
                    number /= 10;
                    k++;
                }
            }

            Console.WriteLine("Массив цифр:");
            for (int i = 0; i < k; i++)
            {
                Console.Write(digitsArray[i] + " ");
            }
            Console.WriteLine();

            // Задача 3: Сумма цифр массива из 17 элементов
            int[] array17 = new int[17];
            int sumDigits = 0;

            Console.WriteLine("Введите 17 двузначных чисел для массива:");
            for (int i = 0; i < 17; i++)
            {
                array17[i] = int.Parse(Console.ReadLine());
                int number = array17[i];

                
                while (number > 0)
                {
                    sumDigits += number % 10;
                    number /= 10;
                }
            }

            Console.WriteLine("Сумма всех цифр массива: " + sumDigits);

            // Задача 4: Сортировка двух массивов
            double[] arrayA = new double[9];
            double[] arrayB = new double[7];
            double[] mergedArray = new double[16];

            Console.WriteLine("Введите 9 элементов для первого массива:");
            for (int i = 0; i < 9; i++)
            {
                arrayA[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите 7 элементов для второго массива:");
            for (int i = 0; i < 7; i++)
            {
                arrayB[i] = double.Parse(Console.ReadLine());
            }

            
            for (int i = 0; i < 9; i++)
            {
                mergedArray[i] = arrayA[i];
            }
            for (int i = 0; i < 7; i++)
            {
                mergedArray[9 + i] = arrayB[i];
            }

            
            Array.Sort(mergedArray);

            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < 16; i++)
            {
                Console.Write(mergedArray[i] + " ");
            }
            Console.WriteLine();
            // Задача 5: Совпадающие элементы массивов
            int[] arrayX = new int[10];
            int[] arrayY = new int[10];
            int[] commonElements = new int[10];
            int commonCount = 0;

            Console.WriteLine("Введите 10 элементов для массива X:");
            for (int i = 0; i < 10; i++)
            {
                arrayX[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите 10 элементов для массива Y:");
            for (int i = 0; i < 10; i++)
            {
                arrayY[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (arrayX[i] == arrayY[j])
                    {
                        commonElements[commonCount] = arrayX[i];
                        commonCount++;
                        break;
                    }
                }
            }

            Console.WriteLine("Общие элементы массивов:");
            for (int i = 0; i < commonCount; i++)
            {
                Console.Write(commonElements[i] + " ");
            }
            Console.WriteLine();

            // Задача 6: Расчет значений по формуле и сортировка
            double[] arrayYValues = new double[12];
            Console.WriteLine("Рассчитываем значения массива Y по формуле y = i^2 - 2*i + 19.3*cos(i):");
            for (int i = 0; i < 12; i++)
            {
                arrayYValues[i] = i * i - 2 * i + 19.3 * Math.Cos(i);
                Console.WriteLine($"Y[{i}] = {arrayYValues[i]}");
            }

            double averageY = 0;
            for (int i = 0; i < 12; i++)
            {
                averageY += arrayYValues[i];
            }
            averageY /= 12;

            Console.WriteLine($"Среднее значение: {averageY}");
            Console.WriteLine("Сортируем массив: сначала элементы меньше среднего, затем остальные:");
            for (int i = 0; i < 12; i++)
            {
                if (arrayYValues[i] < averageY)
                {
                    Console.Write(arrayYValues[i] + " ");
                }
            }
            for (int i = 0; i < 12; i++)
            {
                if (arrayYValues[i] >= averageY)
                {
                    Console.Write(arrayYValues[i] + " ");
                }
            }
            Console.WriteLine();

            // Задача 7: Разность сумм четных и кратных 3
            double[] arrayZ = new double[16];
            double sumEvenIndex = 0;
            double sumMultipleOfThree = 0;

            Console.WriteLine("Введите 16 элементов массива Z:");
            for (int i = 0; i < 16; i++)
            {
                arrayZ[i] = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEvenIndex += arrayZ[i];
                }
                if (i % 3 == 0)
                {
                    sumMultipleOfThree += arrayZ[i];
                }
            }

            Console.WriteLine($"Разность между суммой четных индексов и кратных 3: {sumEvenIndex - sumMultipleOfThree}");

            // Задача 8: Индекс максимального нечетного положительного элемента
            int[] arrayR = new int[9];
            int maxOddPositive = int.MinValue;
            int maxOddPositiveIndex = -1;

            Console.WriteLine("Введите 9 элементов массива R:");
            for (int i = 0; i < 9; i++)
            {
                arrayR[i] = int.Parse(Console.ReadLine());
                if (arrayR[i] > 0 && arrayR[i] % 2 != 0 && arrayR[i] > maxOddPositive)
                {
                    maxOddPositive = arrayR[i];
                    maxOddPositiveIndex = i;
                }
            }
            if (maxOddPositiveIndex != -1)
            {
                Console.WriteLine($"Индекс максимального нечетного положительного числа: {maxOddPositiveIndex}");
            }
            else
            {
                Console.WriteLine("В массиве нет нечетных положительных чисел.");
            }

            // Задача 9: Расчет значений и сортировка по убыванию
            int[] arrayX15 = new int[15];
            double[] arrayYCalc = new double[15];

            Console.WriteLine("Введите 15 элементов массива X:");
            for (int i = 0; i < 15; i++)
            {
                arrayX15[i] = int.Parse(Console.ReadLine());
                arrayYCalc[i] = Math.Cos(arrayX15[i]) + 2.971 * Math.Log(12);
            }

            Array.Sort(arrayYCalc);
            Array.Reverse(arrayYCalc);

            Console.WriteLine("Отсортированный массив по убыванию:");
            for (int i = 0; i < 15; i++)
            {
                Console.Write(arrayYCalc[i] + " ");
            }
            Console.WriteLine();
        }
    }
}