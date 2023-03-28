
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetIntervalMN (int m , int n)
{ 
    int result = m;
    if (m < n)
    {
        m++;
        result = m + GetIntervalMN(m, n);
        return result;
    }
    else 
    {
    return 0;
    }
}
    
void PrintMN (int m, int n)
{
Console.WriteLine($"{GetIntervalMN(m-1,n)}");
}
PrintMN (4,8);


