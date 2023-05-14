// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// Например: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void Task043()
{
    double b1, b2, k1, k2;
    double x = 0, y = 0;
    
    Console.WriteLine($"Please enter b1: ");
    while (!double.TryParse(Console.ReadLine(), out b1)) 
    {
    Console.WriteLine("This is not number! Please enter number!");
    }
    

    Console.WriteLine($"Please enter b2: ");
    while (!double.TryParse(Console.ReadLine(), out b2)) 
    {
    Console.WriteLine("This is not number! Please enter number!");
    }
    

    Console.WriteLine($"Please enter k1: ");
    while (!double.TryParse(Console.ReadLine(), out k1)) 
    {
    Console.WriteLine("This is not number! Please enter number!");
    }
    

    Console.WriteLine($"Please enter k2: ");
    while (!double.TryParse(Console.ReadLine(), out k2)) 
    {
    Console.WriteLine("This is not number! Please enter number!");
    }

    if (k1 == k2 && b1 != b2) Console.WriteLine("Lines are parallel!");
    else if (b1 == b2 && k1 == k2 ) Console.WriteLine("Lines coincide!");
         else
            { 
            x = (b2-b1)/(k1-k2); 
            y = k1 * x + b1;

            Console.WriteLine($"Lines intersect at a point ({x}, {y})");
            }
}


Task043();


