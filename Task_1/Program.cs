// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3 , 5 -> 243 (3⁵)

// 2, 4 -> 16

using System.Globalization;
using System.Security.Cryptography;

int a = ReadInt("a");
int b = ReadInt("b");
int c = Degree(a, b);
System.Console.WriteLine(c);



int ReadInt(string argument)    // запрос на ввод с клавиатуры и проверка на точ то введенн тип Int если нет выдаст сообщение
{

    Console.Write($"input {argument} : ");
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("It's not a number");

    }
    return i;
}

int Degree(int number, int deg)
{

    int stepen = 1;
    for (int i = 1; i <= deg; i++)
    {
        stepen = stepen * number;
    }
    return stepen;

}