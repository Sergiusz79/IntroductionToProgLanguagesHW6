// Задача 41 v.01


void Task041_1()
{
int lght = 8;
int num;
int count = 0;

Console.WriteLine("Please enter numbers: ");

    for (int i = 0; i < lght; i++)
    {
        while (!int.TryParse(Console.ReadLine(), out num))
        {
        Console.WriteLine("This is not number! Please enter number!");
        }
        if (num >= 0) count++;
    }

Console.WriteLine($"{count} entered positive numbers!");
}

Task041_1();

