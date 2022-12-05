Console.Write("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num <=5) {
    Console.WriteLine($"{num} день недели рабочий");
}
else if (num >= 6 && num <=7) {
    Console.WriteLine($"{num} день недели выходной");
    }
else {
Console.WriteLine("Указанного дня недели нет");
}