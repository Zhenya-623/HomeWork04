/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую. использовать метод string.Split())*/


//метод преобразования массива с испольованием функции split
string[] PrintArray(string arrayStr)
{

    string [] array = arrayStr.Split(", ");

    return array;
}

//команда для ввода массива
Console.WriteLine("Введите массив:");
//в переменную arrayStr передаем введенные числа
string arrayStr = Console.ReadLine()??"";
// вводим переменную в которую закладываем число с длинной массива
int arrayLength = arrayStr.Length;
// преобразовываем массив с использованием метода PrintArray
string [] array = PrintArray(arrayStr);
//цикл вывода массива 
for (var i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");
}

