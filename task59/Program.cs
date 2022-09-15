// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

int [,] GetArray(int m, int n){
    var result = new int [m, n];

    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            result[i, j] = new Random().Next(10);
        }
    }
    return result;
}

int[] GetIndexMin(int [,] arr)
{
    var result = new int []{0, 0};
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(min > arr[i,j]){
                min = arr[i,j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int [,] GetResultArray(int[,] arr, int[] indexes){
    var result = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int rows = 0;
    int columns = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == indexes[0]){
            continue;
        }
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == indexes[1]){
                continue;
            }
            result[rows, columns] = arr[i,j];
            columns++;
        }
        columns =0;
        rows++;
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
var arr = GetArray(3, 4);
PrintArray(arr);
System.Console.WriteLine();
PrintArray(GetResultArray(arr, GetIndexMin(arr)));

// ребята писали, но препод прервал
// int [] FindMin (int[,] arr)
// {
//     int imin = 0;
//     int jmin = 0;
//     int min = arr[imin,jmin];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (arr[i,j] < min)
//             {
//                 min = arr[i,j];
//             }
//         }
//     }
//     return arr;
// }
