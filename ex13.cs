Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
double poryadok = Math.Log10(num);
poryadok = Math.Truncate(poryadok);
if (poryadok > 1) {
    num = num / Convert.ToInt32(Math.Pow(10, poryadok-2));
    int res = num % 10;
    Console.WriteLine ($"Третья цифра заданного числа: {res}");
}
else {
    Console.WriteLine ("Третья цифра отсутствует");
}

