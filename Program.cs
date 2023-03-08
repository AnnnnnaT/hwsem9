// /Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
 // Задайте значение N.

// int Out (int n)
// {
//     if (n==0) return n;

//     Console.Write(n+" ");
//     n--;
//     return Out(n);
// }

// Console.WriteLine("Input positive integer number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Out(n);


// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.

// int SumElements(int firstNum, int lastNum)
// {
//     if (firstNum > lastNum) return firstNum + SumElements(firstNum-1, lastNum);
//     if (firstNum < lastNum) return firstNum + SumElements(firstNum + 1, lastNum);
//     else return firstNum;
// }

// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int result = SumElements(m,n);
// Console.WriteLine("Сумма промежутке от m до n: " + result);


// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.

// int Akker (int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (m > 0 && n == 0) return Akker (m - 1, 1);
//     if (m > 0 && n > 0) return Akker (m - 1, Akker (m,n - 1));
//     return Akker (m,n); 
// }                  

// Console.Write("Input number a > 0: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number b > 0: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"For {a} and  {b}: A(a,b) = {Akker(a,b)}");      



