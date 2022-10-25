// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Например:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double distance(int[]dotsA, int[]dotsB)
{
    return Math.Sqrt(Math.Pow(dotsB[0] - dotsA[0], 2) + Math.Pow(dotsB[1] - dotsA[1], 2) + Math.Pow(dotsB[2] - dotsA[2], 2));
}
int[] dotsA = new int [3];
int[] dotsB = new int [3];


Console.Write("Enter the number X(A): ");
dotsA[0] = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number Y(A): ");
dotsA[1] = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number Z(A): ");
dotsA[2] = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number X(B): ");
dotsB[0] = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number Y(B): ");
dotsB[1] = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number Z(B): ");
dotsB[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Round(distance(dotsA, dotsB), 3));