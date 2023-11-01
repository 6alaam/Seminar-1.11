// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
 // 82 -> 10
// 9012 -> 12




int a = ReadInt("a");

IntegerSum(a);



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


void IntegerSum(int n)  // сумма всех состовляющих
{
    
    int sum = 0;
while (n != 0)      // идея пока число меньше нуля 
{
    sum += n%10;   // сумма равна сумма плюс остаток от деления на 10
    n /= 10;     // здесь мы делим целочисленно на 10 начальное число и запоминаем его таким. соотвественно после того как число перестанет делится на 10 вылетим из цикла
    
}
System.Console.WriteLine(sum);

}