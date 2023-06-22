//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]





 int [] GetArray(int lenght)
{
    int [] arr = new int [lenght];

for (int i = 0; i < lenght; i ++)
    {
        arr[i] = new Random().Next(0, 999);
    }
return arr;
}

int[] array = GetArray(8);
Console.WriteLine ($"[{String.Join(",", array)}]");