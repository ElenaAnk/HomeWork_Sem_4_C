//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine()!);

int GetResult(int A, int B)
{
    int Result = 1;
    for (int i = 0; i < B; i++)
    {
        Result = Result * A;
    }
    return Result;
}

Console.WriteLine($"Число {A} в степени {B}, равно {GetResult(A, B)}");