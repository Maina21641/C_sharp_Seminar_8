// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

int rows = 3;
int columns = 4;

int [,] GetArray(int m, int n){
    var result = new int [m, n];

    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i, j] = new Random().Next(100);
        }
    }
    return result;
}

void PrintArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j =0; j < arr.GetLength(1); j++)
        {
            System.Console.WriteLine($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void ChangeRows(int[,] arr){
    int rowCount = arr.GetLength(0) - 1;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int temp = arr[0, i];
        arr [0, i] = arr[rowCount, i];
        arr[rowCount, i] = temp;
    }
    PrintArray(arr);
}
var arr = GetArray(rows, columns);
PrintArray(arr);
System.Console.WriteLine();
ChangeRows(arr);