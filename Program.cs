// Задача №2
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// int count = 0;
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     count++;
// }
// Console.WriteLine($"количество чётных чисел в массиве -> {count} ");
// void FillArrayRandomNumbers(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Задача №3
// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];  
// for(int i = 0; i < numbers.Length; i++)
// {
//   numbers[i] = new Random().Next(100,1000);
//   Console.Write($"{numbers[i]} ");
// } 
// Console.WriteLine();      
// int n = numbers.Length; 
// int k = n / 2;          
// int temp;               
// for(int i=0; i < k; i++)
// {
//     temp = numbers[i];
//     numbers[i] = numbers[n - i - 1];
//     numbers[n - i - 1] = temp;
// }
// foreach(int i in numbers)
// {
//     Console.Write($"{i} ");
// }