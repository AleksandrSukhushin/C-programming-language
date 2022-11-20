// Семинар 5

// Решение задачи. Определение простых чисел от 1 до N

// int n = 20;
// for (int number = 2; number <= n; number++)
// {
//     if(IsPrime(number));
//     {
//         Console.WriteLine(number + " ");
//     }
// }
// string res = string.Empty;
// bool IsPrime(int number)
// {
//     for (int i = 2; i <= (int)Math.Sqrt(number); i++)
//     {
//         if(number % i == 0)
//         {
//             return false;
//         }
//     }
//     return true;
// }


// Задача 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9;9].
// Найдите сумму отрицательных и положительных элементов массива.

// int length = 5;
// int[] massive = new int[length];
// FillArray(massive);
// PrintArray(massive);
// int sumPositive = SumOfSingNumbers(massive, true);
// int sumNegative = SumOfSingNumbers(massive, false);
// Console.WriteLine($"{sumPositive},{sumNegative}");
// int SumOfSingNumbers(int[] array, bool isPositive)
// {
//     int sum = 0;
//     foreach (var item in array)
//     {if(isPositive && item > 0) {sum += item;}
//     else if(!isPositive && item < 0){sum += item;}}
//     return sum;
// }
// void FillArray(int[] array, int minValue = -9, int maxValue = 9)
// {
//     var rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {array[i] = rnd.Next(minValue, maxValue + 1);}
// }
// int[] GetArray(int length, int minValue = -9, int maxValue = 9)
// {
//     int[] array = new int[length];
//     FillArray(array, minValue, maxValue);
//     return array;
// }
// void PrintArray(int[] array)
// {foreach (int element in array){Console.Write(element + " ");}Console.WriteLine();}

    // for (int i = 0; i < array.Length; i++)
    // {
    //     Console.WriteLine(array[i] + " ");
    // }


// Задача 35. Задайте одномерный массив из 123 случайных чисел. Найдите количество двухзначных элементов массива.
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123.






// Задача 37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.
