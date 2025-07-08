using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Reflection.Emit;
//Task1
/*int a = Convert.ToInt32(Console.ReadLine());
int summma = 0;
if (a < 100)
{
    int pr = a * 5 / 100;
    summma = a + pr;
}
else if (a > 100 && a < 200)
{
    int pr = a * 7 / 100;
    summma = a + pr;
}
else
{
    int pr = a * 10 / 100;
    summma = a + pr;
}
Console.WriteLine(summma);*/
//Task2
/*int a = Convert.ToInt32(Console.ReadLine());
var arr = new int[a];
int pr = 1;
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    pr *= arr[i];
}
Console.WriteLine(pr);*/
//Task3
/*int a = Convert.ToInt32(Console.ReadLine());
var arr = new int[a];
int mx = -9999;
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] > mx) mx = arr[i];
}
for (int i = 0; i < a; i++)
{
    if (mx == arr[i]) Console.WriteLine(i);
}*/
//Task4
/*int a = Convert.ToInt32(Console.ReadLine());
var arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a; i++)
{
    int k = 0;
    for (int j = 0; j < a; j++)
    {
        if (arr[i] == arr[j]) k++;
    }
    if (k == 1)
    {
        Console.Write($"{arr[i]} ");
    }
    
}*/
//Task5
/*int a = Convert.ToInt32(Console.ReadLine());
var arr = new int[a];
int mn = 9999;
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] < mn) mn = arr[i];
}
for (int i = 0; i < a; i++)
{
    if (mn == arr[i]) Console.WriteLine(i);
}*/
//Task6
/*int a = Convert.ToInt32(Console.ReadLine());
var arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int k = 0;
for (int i = 1; i < a - 1; i++)
{
    if (arr[i - 1] < arr[i] && arr[i] > arr[i + 1]) k++;
}
Console.Write(k);*/
//Task7
/*int a = Convert.ToInt32(Console.ReadLine());
var arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int k = 0;
int f = 0, s = 0;
for (int i = 0; i < a - 1; i++)
{
    if ((arr[i] >= 0 && arr[i + 1] >= 0) || (arr[i] <= 0 && arr[i + 1] <= 0))
    {
        f = arr[i];
        s = arr[i + 1];
        k = 1;
    }
}

if (k == 1)
{
    Console.Write($"{f} {s} ");
}*/
//Task8
/*int a = Convert.ToInt32(Console.ReadLine());
var arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a; i++)
{ 
    if (arr[i] % 2 != 0) Console.Write($"{i} ");
}*/
//Task9
/*int a = Convert.ToInt32(Console.ReadLine());
var arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int q = Convert.ToInt32(Console.ReadLine());
int w = Convert.ToInt32(Console.ReadLine());
for (int i = q; i <=w; i++)
{ 
    if (arr[i] % 2 != 0) Console.Write($"{arr[i]} ");
}*/
//Task10
int a = Convert.ToInt32(Console.ReadLine());
var arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a; i++)
{
    if (arr[i] % 2 != 0)
    {
        double pw = Math.Pow(arr[i], 2);
        Console.Write($"{pw} ");
    }
}




