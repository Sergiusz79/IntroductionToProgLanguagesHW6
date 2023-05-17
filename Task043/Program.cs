// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// Например: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// double Task043(double b1, b2, k1, k2)
// {
    
//     double x = 0, y = 0;

//     Console.WriteLine($"Please enter b1: ");
//     while (!double.TryParse(Console.ReadLine(), out b1))
//     {
//         Console.WriteLine("This is not number! Please enter number!");
//     }
//     return b1;

//     Console.WriteLine($"Please enter b2: ");
//     while (!double.TryParse(Console.ReadLine(), out b2))
//     {
//         Console.WriteLine("This is not number! Please enter number!");
//     }
//     return b2;

//     Console.WriteLine($"Please enter k1: ");
//     while (!double.TryParse(Console.ReadLine(), out k1))
//     {
//         Console.WriteLine("This is not number! Please enter number!");
//     }
//     return k1;

//     Console.WriteLine($"Please enter k2: ");
//     while (!double.TryParse(Console.ReadLine(), out k2))
//     {
//         Console.WriteLine("This is not number! Please enter number!");
//     }
//     return k2;
// }



//     if (k1 == k2 && b1 != b2) Console.WriteLine("Lines are parallel!");
//     else if (b1 == b2 && k1 == k2) Console.WriteLine("Lines coincide!");
//     else
//     {
//         x = (b2 - b1) / (k1 - k2);
//         y = k1 * x + b1;

//         Console.WriteLine($"Lines intersect at a point ({x}, {y})");
//     }
// }


// Task043();



void EnterNumbers(double[] array)
{
    int num;
    string[] coef = {"b1", "k1", "b2", "k2"};
    for (int i = 0; i<4; i++)
    {
        Console.WriteLine($"Please enter {coef[i]}: ");
        while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("This is not number! Please enter number!");
    }
    array[i] = num;
    }
}

void CheckPoint(double[] array)
{
    double x, y;
    if (array[1] == array[3] && array[0] != array[2]) Console.WriteLine("Lines are parallel!");
    else if (array[0] == array[2] && array[1] == array[3]) Console.WriteLine("Lines coincide!");
    else
    {
         x = (array[2] - array[0]) / (array[1] - array[3]);
         y = array[1] * x + array[0];
         Console.WriteLine($"Lines intersect at a point ({x}, {y})");
    }
}


void Task043()
{
double[] array = new double[4];
EnterNumbers(array);
CheckPoint(array);
}

Task043();
