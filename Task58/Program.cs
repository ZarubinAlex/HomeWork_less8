// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

void SummArray(int[,] arr1, int[,] arr2){

    if(arr1.GetLength(1) != arr2.GetLength(0)){
        Console.WriteLine();
        Console.WriteLine("матрицы нельзя перемножить");
        return;
    } 

    Console.WriteLine();
    PrintArray(arr1);
    Console.WriteLine();
    PrintArray(arr2);
    Console.WriteLine();

    int[,] summArr = new int[arr1.GetLength(0) , arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++){
       for (int j = 0; j < arr2.GetLength(1); j++){
            for (int m = 0; m < arr1.GetLength(1); m++){

                summArr[i,j] += arr1[i,m] * arr2[m,j];
            }
            
        }
    }

    Console.WriteLine("Результирующая матрица:");
    PrintArray(summArr);
    Console.WriteLine();

}

Console.Clear();
int m1 = InputInt("m1");
int n1 = InputInt("n1");
int m2 = InputInt("m2");
int n2 = InputInt("n2");
int[,] arr1 = GetFillArray(m1,n1);
int[,] arr2 = GetFillArray(m2,n2);

SummArray(arr1, arr2);

