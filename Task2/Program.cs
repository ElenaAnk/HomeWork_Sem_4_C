//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine()!);

int GetSum(int Num)
{
    int sum = 0;
    int resault = 0;
    while(Num>0)
    {
        resault = Num%10;
        sum = sum + resault;
        Num=Num/10;
    }
    return sum;
}

Console.WriteLine($"Сумма цифр в числе {Num}, равна {GetSum(Num)}");

