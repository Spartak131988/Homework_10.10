void PrintArray(int[,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
           Console.Write($" {matr[ i, j ]} ");
       }
   Console.WriteLine(); 
   }
}

void FillArray(int[,] matr, int min, int max)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
           matr[i, j] = new Random(). Next (min, max);
       } 
   }
}

int rows = 3;
int columns = 4;
int[,] matr = new int[rows,columns];

FillArray(matr, 1, 10);
PrintArray(matr);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");

for (int i = 0; i < columns; i++)
{
    double sum = 0;
    double Av = 0;
    for (int j = 0; j < rows; j++)
    {
        sum = sum + matr[j,i];
        Av = Math.Round(sum / rows, 2);
    }
    Console.Write( Av + "; ");
}
