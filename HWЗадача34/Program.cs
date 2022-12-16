// Задайте массив заполненный случайными трёхзначными числами.Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int [10]; 
DoArray(array);
Console.WriteLine(" : Случайные трёхзначные числа ");
soThat (array);

void soThat (int [] array)
{
     int count=0;
    foreach(int ar in array)
    { 
         if ((ar & 1) ==0)
    {
           count++;
    }
    }
    Console.WriteLine($"Число положительных чисел {count}");
} 
void DoArray (int [] array)
{
     for (int i = 0; i < array.Length; i ++)
     {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
     }
}