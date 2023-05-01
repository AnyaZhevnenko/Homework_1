// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Input a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input b");
// int b = Convert.ToInt32(Console.ReadLine());
// int max=a;
// if (a>max) max=a;
// if (b>max) max=b;
// {
//     Console.WriteLine ($"{"max"}={max}");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Input number1");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number2");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number3");
// int number3 = Convert.ToInt32(Console.ReadLine());
// int max=number1;
// if (number1>max) max=number1;
// if (number2>max) max=number2;
// if (number3>max) max=number3;
// {
//     Console.WriteLine ($"{max}");
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Input number");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
// {
//    Console.WriteLine("да"); 
// }
// else
// {
//     Console.WriteLine("нет");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=n; i++)
{
if (i % 2 == 0)
    Console.Write(i +",");
}
