// Определение максимума, использование массивов и условий. 

int max = 0;
Console.Write("Введите три целых числа: ");
string[] arr = Console.ReadLine().Split(); 

int a = int.Parse(arr[0]);
int b = int.Parse(arr[1]);
int c = int.Parse(arr[2]);

if (a >= b && a >= c)
max = a;

if (b >= a && b >= c)
max = b;

if (c >= a && c >= b)
max = c;

System.Console.WriteLine($"Максимум: {max}");