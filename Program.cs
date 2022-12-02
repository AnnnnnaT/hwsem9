//  Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
 /*
 int Out (int n)
{
    if (n==0) return n;

    Console.Write(n+" ");
    n--;
    return Out(n);
}



Console.WriteLine("Input positive integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
Out(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int Sum (int m, int n)
{  
 if (m <n+1) return m + Sum(m + 1, n);
 else return 0;
}

Console.WriteLine("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = Sum(a,b);
Console.WriteLine();
Console.WriteLine(res);
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*

int Akker (int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akker (m - 1, 1);
    if (m > 0 && n > 0) return Akker (m - 1, Akker (m,n - 1));
    return Akker (m,n); 
}                  

Console.Write("Input number a > 0: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number b > 0: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"For {a} and  {b}: A(a,b) = {Akker(a,b)}");      

*/
