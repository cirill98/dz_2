Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
{
    Console.WriteLine("Третьей цифры нет");
}    
while (a > 999)
{
    a = a / 10;
    if (a < 1000)
    {
    Console.WriteLine(a % 10);   
    }
}

