// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int M = new Random().Next(1, 9 );
Console.WriteLine ($"Введите {M} числа положительные и отрицательные ");
int [] num = new int [M];

Console.WriteLine(DoArray(num));
Console.WriteLine($"В массиве {OtricatSum(num)} отрицательных чисел");

int [] DoArray (int [] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.WriteLine ($"Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
    int OtricatSum(int [] array)
{
    int count = 0;
    foreach(int x in array )
    {
        if (x < 0) count ++;
    }
    return count;
}