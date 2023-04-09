// Задача 25. Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i ++)
    {
        power *= powerBase;
    }
return power;
}
bool ValidateExponent(int exponent)
{
    if(exponent < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}
int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите показатель: ");

if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}



// Задача 27. Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    } 
    return result;
}
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма всех чисел {number} = {SumAllDigit(number)}");



// Задача 29. Программа, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = GenerateArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GenerateArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i ++)
{
    result[i] = new Random().Next(1, 100);
}
return result;
}
