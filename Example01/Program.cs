int m = 3;
int n = 4;
double[,] matr = new double[m,n];
Console.WriteLine("Массив: ");

void FillArray(double[,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
           matr[i, j] = Math.Round(new Random().NextDouble() * 10 - 5, 1);
       } 
   }
}

void PrintArray(double[,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
   {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
           Console.Write($" {matr[ i , j ]}  ");
       }
   Console.WriteLine(); 
   }
}

FillArray(matr);
PrintArray(matr);