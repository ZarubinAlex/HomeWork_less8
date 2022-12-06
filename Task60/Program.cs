// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int InputInt(string letter){

    Console.Write($"Введите {letter}: ");
    return int.Parse(Console.ReadLine());
}

int RndForArray(){

    return new Random().Next(10, 100); 
}

int[,,] GetFillArray(int i, int j, int q){

    int[,,] arr = new int[i,j,q];

    for (int m = 0; m < arr.GetLength(0); m++){
        for (int n = 0; n < arr.GetLength(1); n++){
            for (int k = 0; k < arr.GetLength(2); k++){
                
                int index = RndForArray();
                foreach (int x in arr){
                    if(index == x) index = RndForArray();
                }
                arr[m,n,k] = index;
            }
        }
    }
    return arr;
}


void PrintArray(int[,,] arr){

    for (int m = 0; m < arr.GetLength(0); m++){
        for (int n = 0; n < arr.GetLength(1); n++){
            for (int k = 0; k < arr.GetLength(2); k++){
            
            Console.Write($"{arr[m, n, k]}({m},{n},{k})\t ");
            }
        Console.WriteLine();
       }
    Console.WriteLine();
    }
}


Console.Clear();
int m = InputInt("m");
int n = InputInt("n");
int k = InputInt("k");
int[,,] arr = GetFillArray(m,n,k);

Console.WriteLine();
PrintArray(arr);
