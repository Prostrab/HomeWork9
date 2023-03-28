
// // Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// // M = 28; N = 7 -> 7


int GetMinSplitter(int n, int m)


{
    if(m==0)
        return n;

    if(n>m)
        return GetMinSplitter(m,n%m);

    else
        return GetMinSplitter(n,m%n);
}
     
Console.WriteLine(GetMinSplitter (10,4));