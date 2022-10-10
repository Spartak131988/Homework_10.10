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

Console.Write("Введите строку: ");
int pos1 = int.Parse(Console.ReadLine()) - 1;
Console.Write("Введите сстолбец: ");
int pos2 = int.Parse(Console.ReadLine()) - 1;
Console.WriteLine();

int rows = 5;
int columns = 6;
int[,] matr = new int[rows,columns];
Console.WriteLine("Массив: ");

FillArray(matr, 1, 10);
PrintArray(matr);
Console.WriteLine();

if (pos1 < 0 | pos1 > matr.GetLength(0) - 1 | pos2 < 0 | pos2 > matr.GetLength(1) - 1)
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else
{
    Console.WriteLine("Элемент: {0} ", matr[pos1,pos2]);
}