// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Input first number");
int FirstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int SecNum = Convert.ToInt32(Console.ReadLine());
if (FirstNum == SecNum)
    Console.WriteLine(":( Not different numbers input, reinput, pls ");

    else if (FirstNum>SecNum){
    Console.WriteLine($"Number {FirstNum} more than number {SecNum}");
    }
    else {
        Console.WriteLine($"Number {SecNum} more than number {FirstNum}");
    }