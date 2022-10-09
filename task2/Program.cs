/*Задача 52. Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int m = Convert.ToInt32(Console.ReadLine());
int [,]arr = new int [n, m];
double []sum = new double [m];
Random Arr1 = new Random();

for (int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        arr[i, j] = Arr1.Next(0, 100);

        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
        sum[i] += arr[j, i];
    }
}

for (int i=0; i<m; i++)
{
    Console.Write((sum[i] / n)  + "\t");
}
















/*
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array1 = new int [n,m];
Random arr = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array1[i, j] = arr.Next(1,100); 
        Console.Write(array1[i,j] + "\t");
    }
        Console.WriteLine();
}
void PrintArrayWithSum ( int [] Nums)
{
    int sum =0;
    for (int i = 0; i < Nums.Length; i++)
    {
        sum+= Nums[i];
        Console.WriteLine($"числа = {sum}");
    }

PrintArrayWithSum (Nums);
}



foreach(double Num in res)
{
    double res1 = res / n;
}       
Console.WriteLine(res1);
*/