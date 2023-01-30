// Нахождение, "Високосный год"

Console.Write("Введите год: ");  
int year = int.Parse(Console.ReadLine()); // Вод года c клавиатуры. 
string output;

if (year % 4 == 0) // проверка условия
{
    if (year % 100 == 0)
    {
        if (year % 400 == 0)
        output = "високосный";
        else
        output = "невисокосный";
    }
    else
    output = "високосный";
}
else
output = "невисокосный";
System.Console.WriteLine($"Год {year} - {output}");