// Вычисление фактоиала

ulong n = 0;
ulong factorial = 1;

System.Console.WriteLine("Введите положительное целое число");
n = Convert.ToUInt64(Console.ReadLine());

for (ulong i = 1; i <= n; i++)
{
    factorial *= i;
}
System.Console.WriteLine($"Факториал = {factorial}");