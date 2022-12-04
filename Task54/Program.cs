// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int InputInt(string letter){

    Console.Write($"Введите {letter}: ");
    return int.Parse(Console.ReadLine());
}


int[,] GetFillArray(int m, int n){

    int[,] arr = new int[m,n];
    for (int i=0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0, 10);
        }
    }
    
    return arr;
}


void PrintArray(int[,] arr){

    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            
            Console.Write($"{arr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void SortArrayInLine(int[,] arr, int row){

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1 - i; j++)
        {
            if(arr[row, j] > arr[row, j+1]) (arr[row, j],arr[row, j+1]) = (arr[row, j+1],arr[row, j]);
        }
    }
}

void SortInArray(int[,] arr){

    for (int i = 0; i < arr.GetLength(0); i++) SortArrayInLine(arr, i);
    
}

Console.Clear();
int m = InputInt("m");
int n = InputInt("n");
int[,] arr = GetFillArray(m,n);

PrintArray(arr);
Console.WriteLine();

SortInArray(arr);
PrintArray(arr);

