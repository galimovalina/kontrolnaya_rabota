// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <=3 символам

Console.WriteLine("Введите строки через пробел");
string s = Console.ReadLine();
string[] array = s.Split(" ");
string[] result = new string[array.Length];

void SecondArray(string[] array1, string[] array2)
{
int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[count] = array1[i];
        count++;
    }
}
}

void Print(string[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],5}");
}

SecondArray(array,result);
Print(result);