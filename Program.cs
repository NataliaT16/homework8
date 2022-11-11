// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int SetNumber(string str)
{
    Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetRandomMatrix(int rows, int columns, int maxVal = 100, int minVal = -100)
{
int[,] matrix = new int[rows, columns];
var random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = random.Next(minVal, maxVal+1);
    }
}
return matrix;
}

 int[,] matrix = GetRandomMatrix(4,5, 9, 0);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)  
  {
    Console.Write(matrix[i,j] + " ");
  }
  Console.WriteLine(); 
}
}

PrintMatrix(matrix);

 
            Console.WriteLine("отсортированный массив:");
           
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                  int[] temp = new int[matrix.GetLength(1)];;
                for (int j = 0; j < matrix.GetLength(1); j++)
                
                    temp[j] = matrix[i, j];
                Array.Sort(temp);
                
                for (int k = 0; k < temp.GetLength(0); k++)
                {
                    matrix[i, k] = temp[k];
                    Console.Write( matrix[i, k]);
                }
                Console.WriteLine();
            }
 
          
    

   


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int SetNumber(string str)
{
    Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetRandomMatrix(int rows, int columns, int maxVal = 100, int minVal = -100)
{
int[,] matrix = new int[rows, columns];
var random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = random.Next(minVal, maxVal+1);
    }
}
return matrix;
}

 int[,] matrix = GetRandomMatrix(4,5, 9, 0);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)  
  {
    Console.Write(matrix[i,j] + " ");
  }
  Console.WriteLine(); 
}
}

int minSumLine = 0;
int sumLine = SumLineElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(matrix, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"{minSumLine+1} строка - наименьшая сумма элементов =>({sumLine})  ");


int SumLineElements(int[,] matrix, int i)
{
  int sumLine = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sumLine += matrix[i,j];
  }
  return sumLine;
}


PrintMatrix(matrix);
System.Console.WriteLine(SumLineElements);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int m = ReadNumbers("число строк 1-й матрицы");
int n = ReadNumbers("Число столбцов 1-й матрицы");
int p = ReadNumbers("число столбцов 2-й матрицы");
int range = ReadNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[n, p];
CreateArray(secondMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secondMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int ReadNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}





// // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // Массив размером 2 x 2 x 2
// // 66(0,0,0) 25(0,1,0)
// // 34(1,0,0) 41(1,1,0)
// // 27(0,0,1) 90(0,1,1)
// // 26(1,0,1) 55(1,1,1)


int SetNumber(string str)
{
    Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,,] GetRandomMatrix(int rows, int columns, int depth, int maxVal = 100, int minVal = 10)
{
int[,,] matrix = new int[rows, columns, depth];
var random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
      for (int k = 0; k < depth; k++)
      {
    
        matrix[i,j,k] = random.Next(minVal, maxVal+1);
      }
    }
}
return matrix;
}

 int[,,] matrix = GetRandomMatrix(4,5,2, 100, 10);

void PrintMatrix(int[,,] matrix)
{


    for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)  
  {
    for (int k = 0; k < matrix.GetLength(2); k++)
      {
    Console.WriteLine($"{matrix[i,j,k]},({i}, {j}, {k})");
    System.Console.Write("  ");
      }
  }
  Console.WriteLine(); 
}
}

PrintMatrix(matrix);



// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07


Console.WriteLine($"Задача 62: Заполните спирально массив 4 на 4.");

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}


