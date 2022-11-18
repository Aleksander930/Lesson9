// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// (НЕ ИСПОЛЬЗОВАТЬ РЕЗУЛЬТИРУЮЩУЮ ПЕРЕМЕННУЮ)
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
if (numM > numN)
{
    int number = numM;
    numM = numN;
    numN = number;
}
int sumarr = ArrayNum(numM, numN);
Console.WriteLine(sumarr);

int ArrayNum(int numM, int numN)
{
    if (numM + 1 >= numN)
    {
        return numM + numN;
    }
    return numM + ArrayNum(numM + 1, numN);
}