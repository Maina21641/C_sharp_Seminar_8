//1
// В начале можно не конвертировать и не писать на ввод никакие данные, заместо этого указать:
// int rows = 3;
// int columns = 4;
// А при генерации new Random().NextDouble(); не указывать число после NextDouble, 
// функция сгенерирует числа от 0 до 1-цы по умолчанию

//2
// Напишите программу, которая на вход принимает число в двумерном массиве, и возвращает значение

// int rows = 3;
// int columns = 4;

// int [,] GetArray(int m, int n){
//     var result = new int [m, n];

//     for (int i = 0; i < m; i++){
//         for (int j = 0; j < n; j++){
//             result[i, j] = new Random().Next(100);
//         }
//     }
//     return result;
// }
// bool Contains(int[,] arr, int element){
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (arr[i, j] ==element){
//                 return true;
//             }
//         }
//     }
//     return false;
// }

// void PrintArray(double[,] arr){
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j =0; j < arr.GetLength(1); j++)
//         {
//             System.Console.WriteLine($"{arr[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// var arr = GetArray (rows, columns);
// foreach (var item in arr)
// {
//     System.Console.WriteLine(item);
// }
// System.Console.WriteLine(Contains(arr, 23));

//3

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

double[] GetPer(int [,] arr){
    var result = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++){
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        result[i] = Math.Round(sum / arr.GetLength(0), 2); 
    }
    return result;
}

void PrintArray(double[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j =0; j < arr.GetLength(1); j++)
        {
            System.Console.WriteLine($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}


foreach (var item in GetPer(GetArray(rows, columns)))
{
    System.Console.WriteLine(item);
}