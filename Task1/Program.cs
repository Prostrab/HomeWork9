// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8


void GetIntervalMN (int m , int n)

{ 
   
    if (m % 2 == 0)
    {
    Console.Write($"{m}");
      
    if (m == m-1 || m==n)
   {
    Console.Write($".");
   }
   else 
   Console.Write($",");
    }
   
    if ( m < n )
    {
         GetIntervalMN (m+1,n);
    }
}

GetIntervalMN (4,8);


