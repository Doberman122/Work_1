int n1, n2, LCM= 0;
Console.Write("Введите два целых числа: ");
string[] arr = Console.ReadLine().Split();

n1 = int.Parse(arr[0]);
n2 = int.Parse(arr[1]);
LCM = (n1 > n2) ? n1 : n2;

// Бесконечный цикл
while (true)
{
    if (LCM % n1 == 0 && LCM % n2 ==0)
    {
        Console.WriteLine($"HOK = {LCM}");
        break;
    }
    ++LCM;
}