// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

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

void SummInArray(int[,] arr){

    int[] sumInRow = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++){
       for (int j = 0; j < arr.GetLength(1); j++){
            
            sumInRow[i] += arr[i,j];
        }
    }

    int sumRow = sumInRow[0];
    for (int i = 1; i < sumInRow.Length; i++)
    {
        if(sumInRow[i] < sumRow) sumRow = sumInRow[i];
    }

    Console.Write($"Наименьшая сумма элементов в строках: ");

    for (int i = 0; i < sumInRow.Length; i++)
    {
        if(sumInRow[i] == sumRow) Console.Write($"{i+1} ");
    }

}

Console.Clear();
int m = InputInt("m");
int n = InputInt("n");
int[,] arr = GetFillArray(m,n);

PrintArray(arr);
Console.WriteLine();

SummInArray(arr);



