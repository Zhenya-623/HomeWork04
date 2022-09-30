/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


//метод для получения первого и второго числа
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

//метод для вычиления результата возведения числа А в степень числа В
double FindNumber(double firstNumber, double secondNumber)
{
    
    double result = Math.Pow(firstNumber, secondNumber);
    return result;
}

//метод вывода результата на консоль
void PrintData(string prefix, double value)
{
    Console.WriteLine(prefix + value);
}

//программа для получения пераого и второго числа путем ввода с консоли
double firstNumber = ReadData("Введите первое число: ");
double secondNumber = ReadData("Введите второе число: ");

//получение результата с использованием метода FindNunber
double outline = FindNumber(firstNumber, secondNumber);

//вывод результата на консоль
PrintData("Первое число возведённое в степень второго числа равно: ", outline);