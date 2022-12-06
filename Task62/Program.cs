// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int InputInt(string letter){

    Console.Write($"Введите {letter}: ");
    return int.Parse(Console.ReadLine());
}


int[,] GetFillArray(int m){

    int[,] arr = new int[m,m];
    int i=0; int j=0;

    for (int k = 0; k < arr.Length; k++){

        arr[i,j] = k;  
        if(i <= j+1 && i+j < m-1) j++;
        else 
            if(i < j && i+j >= m-1) i++;
            else 
                if(i >= j && i+j > m-1) j--;
                else i--;
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


Console.Clear();
int m = InputInt("m");
int[,] arr = GetFillArray(m);

Console.WriteLine();
PrintArray(arr);
