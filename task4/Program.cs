// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

string toStr = "";
string revStr = "";

if (n < 10)
{
    Console.Write(n);
}
else
{
    while (n > 0)
    {
        int x = n % 10;
        n /= 10;
        if (n > 0)
        {
            toStr = toStr + x.ToString() + ",";
        }
        else
        {
            toStr = toStr + x.ToString();
        }
    }
}

foreach (char i in toStr)
{
    revStr = i + revStr;
}

Console.WriteLine(revStr);