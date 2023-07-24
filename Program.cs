// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int InputNum (string message)
// {
// Console.Write(message);
// return Convert.ToInt32(Console.ReadLine()!);
// }

// string PrintNumbers(int end)
// {
// if (end == 1) return end.ToString();
// return (end + " " + PrintNumbers(end - 1));
// }

// int num = InputNum("Введите целое число: ");
// Console.WriteLine(PrintNumbers(num));






// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int InputNum (string message)
// {
// Console.Write(message);
// return Convert.ToInt32(Console.ReadLine()!);
// }

// int SumNumbers(int start, int end)
// {
// if (start == end) return start;
// return (start + SumNumbers(start + 1, end));
// }

// int start = InputNum("Введите целое число М: ");
// int num = InputNum("Введите целое число N: ");
// System.Console.WriteLine(SumNumbers(start, num));





// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Функция Аккермана a + ba + ba^b+ ...
// В 1935 году Рожа Петер предложила более простое построение, в котором 
// функция имеет только два параметра, а вспомогательная функция не используется

int InputNum (string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine()!);
}
int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}
int n = InputNum("Введите целое число N: ");
int m = InputNum("Введите целое число M: ");
System.Console.WriteLine(Akkerman(n, m));