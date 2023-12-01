// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

int [,] Create2dArray(int row, int col, int min, int max){
    int [,] array = new int [row,col];
    for (int i =0; i<row; i++){
        for(int j = 0; j<col;j++){
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void ShowArray(double [] array){
    for(int i = 0; i<array.Length; i++){
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

// void Show2dSquare(int [,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j=0; j<array.GetLength(1); j++){
//             if(i%2==0 && j%2==0){
//               Console.Write(array[i,j]*array[i,j]+" ");  
//             }
//             else{
//                 Console.Write(array[i,j]+" ");
//             }
            
//         }
//         Console.WriteLine();
//     }
// }

// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// void ShowArrayDiago(int [,] array){
//     int count = 0;
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j=0; j<array.GetLength(1); j++){
//             if(i==j){
//                 count += array[i,j];
//             }
//         }
//     }
//     Console.WriteLine(count+" ");
// }


// Задайте двумерный массив из целых чисел. 
// Сформируйте новый одномерный массив, состоящий из 
// средних арифметических значений по строкам двумерного массива. 

// double [] Average2dArray(int [,] array){
//     double [] createdArray = new double [array.GetLength(0)];
//     for(int i = 0; i<array.GetLength(0); i++){
//         double count = 0;
//         for(int j = 0; j<array.GetLength(1); j++){
//             count+=array[i,j];
//         }
//         createdArray[i] = count/array.GetLength(0);
//     }
//     return createdArray;
// }


//Задайте двумерный массив размера i на j, каждый элемент в 
//массиве находится по формуле: Aₘₙ = i+j. 
//Выведите полученный массив на экран.

// int [,] SumArray(int row, int col){
//     int [,] array = new int [row,col];
//     for(int i=0;i<row;i++){
//         for(int j=0;j<col;j++){
//             array[i,j] = i+j;
//         }
//     }
//     return array;
// }

//Задайте двумерный массив из целых чисел. Напишите программу, 
//которая заменит все элементы в  
//строке и столбеце на 0, на пересечении которых 
//расположен наименьший элемент массива.

int [,] MyArray(int[,] array){
    int min = array[0,0];
    int rowIndex = 0;
    int colIndex = 0;
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            if (min>array[i,j]){
                rowIndex = i;
                colIndex = j;
                min = array[i,j];
            }
        }
    }
    for(int i = 0; i<array.GetLength(0); i++){
        array[i,colIndex] = 0;
    }
    for(int j = 0; j<array.GetLength(1); j++){
        array[rowIndex,j] = 0;
    }
    return array;

}

Console.WriteLine("Enter row numbers: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter col numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] created2dArray = Create2dArray(row,col,min,max);
//int [,] sumArr = SumArray(row,col);
Console.WriteLine();
Show2dArray(created2dArray);
Console.WriteLine();
int [,] changedArr = MyArray(created2dArray);
Show2dArray(changedArr);
// double [] createdArray = Average2dArray(created2dArray);
// ShowArray(createdArray);
//ShowArrayDiago(created2dArray);
//Show2dSquare(created2dArray);