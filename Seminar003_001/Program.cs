// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Input first number");
// int FirstNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int SecNum = Convert.ToInt32(Console.ReadLine());
// if (FirstNum == SecNum)
//     Console.WriteLine(":( Not different numbers input, reinput, pls ");
//     else if (FirstNum>SecNum){
//     Console.WriteLine($"Number {FirstNum} more than number {SecNum}");
//     }
//     else {
//         Console.WriteLine($"Number {SecNum} more than number {FirstNum}");
//     }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Input first number");
// int FirstNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int SecNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number");
// int ThdNum = Convert.ToInt32(Console.ReadLine());
// int max = FirstNum;
// if (max<SecNum)
// max = SecNum;
// if (max<ThdNum)
// max = ThdNum;
// Console.WriteLine($"Max number is {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Input a number");
// int number = Convert.ToInt32(Console.ReadLine());
// if ((number % 2) == 0)
//     {
//         Console.WriteLine($"Number {number} is even :)");
//     }
//     else
//     {
//         Console.WriteLine($" Number {number} is odd :(");
//     }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Input number");
// int N = Convert.ToInt32(Console.ReadLine());
// int current = N;
// if (N==0)
//    Console.WriteLine($" Have no even numbers at 0 to 0 :("); 
// if (N>0)
//      if ((N % 2) == 0)
//     {for(int i=0; i<=N-2; i=i+2)
//             Console.Write($"{i} ");
//         }
//         else for(int i=0; i<=N-1; i=i+2)
//             Console.Write($"{i} ");
// else if (N<0)
//         if ((N % 2) == 0)
//             {for(int i=0; i>=N+2; i=i-2)
//             Console.Write($"{i} ");
//         }
//         else for(int i=0; i>=N+1; i=i-2)
//             Console.Write($"{i} ");
    