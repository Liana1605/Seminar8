// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на  
// пересечении которых расположен наименьший элемент массива. 
 
int DataEntry(string str) 
{ 
    System.Console.Write("введите " + str + " = "); 
    int num = int.Parse(Console.ReadLine()); 
    return num; 
} 
 
int[,] FillArray(int rows, int columns) 
{ 
    int[,] arr = new int[rows, columns]; 
    Random rand = new Random(); 
 
    for (int i = 0; i < rows; i++) 
    { 
        for (int j = 0; j < columns; j++) 
        { 
            arr[i, j] = rand.Next(0, 10); 
        } 
    } 
    return arr; 
} 
 
void ShowArray(int[,] arr) 
{ 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int j = 0; j < arr.GetLength(1); j++) 
        { 
            System.Console.Write(arr[i, j] + "  "); 
        } 
        System.Console.WriteLine(); 
    } 
} 
 
void NewArray(int[,] arr, int minRow, int minColumn) 
{ 
    int newLengthI = arr.GetLength(0) - 1; 
    int newLengthJ = arr.GetLength(1) - 1; 
    int[,] newArr = new int[newLengthI, newLengthJ]; 
    int m = 0; 
    int n = 0; 
 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        if (i == minRow) 
            continue; 
        for (int j = 0; j < arr.GetLength(1); j++) 
        { 
            if (j == minColumn) 
            { 
                continue; 
            } 
            newArr[m, n] = arr[i, j]; 
            n++; 
 
        } 
        m++; 
        n = 0; 
    } 
    System.Console.WriteLine(); 
    ShowArray(newArr); 
} 

void FindMin(int[,] arr) 
{ 
    int min = arr[0, 0]; 
    int minRow = 0; 
    int minColumn = 0; 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int j = 0; j < arr.GetLength(1); j++) 
        { 
            if (arr[i, j] < min) 
            { 
                min = arr[i, j]; 
                minRow = i; 
                minColumn = j; 
            } 
        } 
 
    } 
    System.Console.WriteLine(); 
    System.Console.WriteLine(minRow + " " + minColumn); 
    NewArray(arr, minRow, minColumn); 
} 
 
 
 
Console.Clear(); 
int m = DataEntry("количество строк"); 
int n = DataEntry("количество столбцов"); 
int[,] array = FillArray(m, n); 
ShowArray(array); 
FindMin(array);

