// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0,5; -0,5)


Console.WriteLine("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());




(int,int)PointIntersectionOfStraightLines(int a, int b, int a1, int b1)
{
   int x = (a1-a)/(b-b1);
   int y = b*x+a;
   return (x,y);
}

(int, int )result = PointIntersectionOfStraightLines(b1,k1,b2,k2);
Console.WriteLine($"({result.Item1};{result.Item2})");
