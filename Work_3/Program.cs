// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

string strValue = Console.ReadLine(); // Вводим число с клавиатуры, иными словами вводит пользователь.
string strValue1 = Console.ReadLine(); 
int value = Convert.ToInt32(strValue); // Конвертирование "Стринг" в свойство int 
int value1 = Convert.ToInt32(strValue1);
if (value1 > value) // Условие value > value1 
{
Console.WriteLine("Max " + value1); // Вывод max
Console.WriteLine("Min " + value);
}
else
{
Console.WriteLine("Max " + value);
Console.WriteLine("Min " + value1); // Вывод min
}

