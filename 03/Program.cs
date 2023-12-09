// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] array = { 20, 11, 84, 100, 1 }; // Исходный массив
// Вывод исходного массива
Console.Write("Правильный массив: ");
foreach (int element in array) Console.Write(element + " ");
// Реверсирование массива
int a;
for (int i = 0; i < array.Length / 2; i++)
{
    // Меняем местами элементы
    a = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = a;
}
// Вывод измененного массива
Console.Write("\nМассив наоборот: ");
foreach (int el in array) Console.Write(el + " ");