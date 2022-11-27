Console.Clear();
Console.WriteLine("Введите номер дня недели:");
int num = Convert.ToInt32(Console.ReadLine());
if(num <= 5)
Console.WriteLine("Не выходной день.");
else if (num == 6)
Console.WriteLine("Выходной.");
else if (num == 7)
Console.WriteLine("Выходной.");
else Console.WriteLine("Не является днем недели.");
