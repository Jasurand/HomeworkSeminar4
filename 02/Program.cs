// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[5];
Random random = new Random();
int EvenQnty = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
    Console.Write(array[i] + " ");
    if (array[i] % 2 == 0) EvenQnty++;
}
Console.WriteLine($"\nВсего чётных чисел: {EvenQnty}");