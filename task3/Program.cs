// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.



Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void CreateArray(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
Console.WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.Next(1,9);
Console.Write($"{randomArray[i,j]} ");
}
Console.WriteLine();
}
}

void FindAverage(int m, int n)
{
Console.Write("Среднее арифметическое каждого столбца: ");
int i,j;
Random rand = new Random();
for (j = 0; j < n; j++)
{
double sum = 0;
for (i = 0; i < m; i++)
{
sum = sum + randomArray[i,j];
}
Console.Write($"{sum/(i):F1}; ");
}
}
CreateArray(m,n);
FindAverage(m,n);