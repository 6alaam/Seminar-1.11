//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8]; //  создание массива с 8 элементами заполнен нулями


void FillArray(int[] collection)  // метод заполнения массива рандомными числами от 0 до 1
{

    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next();
        index++;

    }

}

void PrintArray(int[] col)      // распечатываем все элементы массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        System.Console.Write(" ");
        position++;
    }

}
FillArray(array);
PrintArray(array);