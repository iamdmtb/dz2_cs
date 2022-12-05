Console.Write("Введите 3х-значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = num / 10;
int res = num % 10;
Console.Write($"Вторая цифра введенного числа: {res}");