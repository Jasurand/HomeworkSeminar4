// Задача 1: Напишите программу, которая бесконечно запрашивает 
// целые числа с консоли. Программа завершается при вводе 
// символа ‘q’ или при вводе числа, сумма цифр которого чётная.


// В этом коде я сделал, только не учёл ввод q. 
// Вобщемто при вводе любой буквы, выходит ошика и программа завершается

// bool isEven(int n)
// {
//     int result = 0;
//     while (n > 0)
//     {
//         int x = n % 10;
//         result = result + x;
//         n /= 10;
//     }
//     if (result % 2 == 0) return true; 
//     return false;
// }

// Console.Clear();
// Console.Write("Введите любое число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (isEven(n) == false)
// {
//     Console.Write("Введите любое число: ");
//     n = int.Parse(Console.ReadLine()!);
// }


// А теперь сделаю как надо ))

while (true)
{
    Console.Write("Введите число: ");
    string line = Console.ReadLine()!;
    if (line == "q") break;
    int N;
    if (int.TryParse(line, out N)) 
    {
        int result = 0;
        while (N > 0) 
        {
            result = result + (N % 10); 
            N /= 10; 
        }
        if (result % 2 == 0) break;
    }
}