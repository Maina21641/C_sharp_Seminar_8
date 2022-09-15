// Задача 57:** Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

int rows = 3;
int columns = 4;

int [,] GetArray(int m, int n){
    var result = new int [m, n];

    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i, j] = new Random().Next(10);
        }
    }
    return result;
}

void PrintArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j =0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

// void ChangeRows(int[,] arr){
//     int rowCount = arr.GetLength(0) - 1;
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         int temp = arr[0, i];
//         arr [0, i] = arr[rowCount, i];
//         arr[rowCount, i] = temp;
//     }
//     PrintArray(arr);
// }

// int[,] ChangeArray(int[,] array)
// {   int roes = array.GetLength(0);
// int columns = array.GetLength(1);
//     var result = new int[array.GetLength(1), array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result[j, i] = array[i, j];
//         }
//     }
//     return result;
// }

void GetDictionary(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int number = arr[i,j];
            int count = 0;
            for (int b = 0; b < arr.GetLength(0); b++)
            {
                for (int v = 0; v < arr.GetLength(1); v++)
                {
                    if  (number == arr[b, v]) count++;
                }
            }
            Console.WriteLine($"{arr[i,j]} meet {count} time");
        }
    }
}

int[,] arr = GetArray(rows, columns);
PrintArray(arr);
System.Console.WriteLine();
GetDictionary(arr);