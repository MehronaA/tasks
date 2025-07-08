using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Reflection.Emit;
//Task1
/*int b = 0;
for (; ; )
{
    int a = Convert.ToInt32(Console.ReadLine());
    if (a >= b)
    {
        b = a;
    }
    if (a == 0)
    {
        break;
    }

}
Console.WriteLine(b);*/
//Task2
/*int a = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double sum = 1;
for (int i = 1; i <= n; i++)
{
    sum += Math.Pow(a, i);
}
Console.WriteLine(sum);*/
//Task3
/*int f = Convert.ToInt32(Console.ReadLine());
int sum = f;
for (; ; )
{
    int a = Convert.ToInt32(Console.ReadLine());
    sum += a;
    if (f == 0 && a == 0)
    {
        break;
    }
    f = a;
}
Console.WriteLine(sum);*/
//Task4
/*int a = Convert.ToInt32(Console.ReadLine());
var arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int k = 0;
for (int i = 0; i < a - 1; i++)
{
    if ((arr[i] >= 0 && arr[i + 1] >= 0) || (arr[i] <= 0 && arr[i + 1] <= 0))
    {
        k++;
    }
    else
    {
        k = 0;
    }
}
if (k == 0) Console.WriteLine("NO");
else Console.WriteLine("YES");*/
//Task5
/*int a = Convert.ToInt32(Console.ReadLine());
var arr = new int[a];
int rep = 0;
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
var c = new int[a];
for (int i = 0; i < a; i++)
{
    int k = 0;
    int tr = 0;
    for (int p = 0; p < rep; p++)
    {
        if (c[p] == arr[i]) tr = 1;
    }
    if (tr!= 0) continue;
    for (int j = 0; j < a; j++)
    {
        if (arr[i] == arr[j])
        {
            k++;
        }

    }
    if (k > 1)
    {
        for (int j = 0; j < a; j++)
        {
            if (arr[i] == arr[j])
            {
                Console.Write($"{arr[j]} ");
                c[rep] = arr[j];
                rep++;
            }
        }
    }

}*/
//Task6
/*int a = Convert.ToInt32(Console.ReadLine());
var arr = new int[a];
int mn = 9999;
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] < mn) mn = arr[i];
}
Console.WriteLine(mn);*/
//Task7
/*int sum = 0;
int k = 0;
for (; ; )
{
    Console.WriteLine("Give a number:");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a == 0) break;
    sum += a;
    k++;
}
Console.WriteLine($"Sum of numbers: {sum}");
Console.WriteLine($"Count of numbers: {k}");*/
//Task8
/*int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int pr = 1;
for (int i = a; i > 0; i /= 10)
{
    sum += i % 10;
    pr *= i % 10;
}
Console.WriteLine($"Sum of digits = {sum}");
Console.WriteLine($"Product of digits = {pr}");*/
//Task9
/*int a = Convert.ToInt16(Console.ReadLine());
int rev = 0;
for (int i = a; i > 0; i /= 10)
{
    rev = rev * 10 + (i % 10);
}
Console.WriteLine(rev);*/
//Task10
/*int a = Convert.ToInt32(Console.ReadLine());
var arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a; i++)
{
    int k = 0;
    for (int j = 1; j <= arr[i]; j++)
    {
        if (arr[i] % j == 0) k++;
    }
    if (k == 2) continue;
    else Console.Write($"{arr[i]} ");
}*/
