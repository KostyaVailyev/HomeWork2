Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num % 10;
int num2 = num / 10 % 10;
int num3 = num / 100 % 10;
Console.WriteLine(num3 == 0 ? $"В числе {num} нет третей цифры." : $"Третья цифра числа {num} это {num1}");