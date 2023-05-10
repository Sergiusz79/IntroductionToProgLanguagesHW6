// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Например: 0, 7, 8, -2, -2     -> 2
//           1, -7, 567, 89, 223 -> 3


void EnterNumbers(int[] arr)
{
int num;
Console.WriteLine("Please enter numbers: ");

    for (int i = 0; i < arr.Length; i++)
    {
        while (!int.TryParse(Console.ReadLine(), out num))
        {
        Console.WriteLine("This is not number! Please enter number!");
        }
    arr[i] = num;
    }
}

void CheckForPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0) count++;
    }
    Console.WriteLine($"{count} entered positive numbers!");
}



void Task041()
{
int[] arr = new int[8];
EnterNumbers(arr);
CheckForPositive(arr);
}


Task041();
