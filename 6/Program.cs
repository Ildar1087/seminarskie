Console.Clear();
Console.Write("введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num > 999)
Console.Write("введено не корректное значение");
return;
int otvet = num% 10;
Console.WriteLine($"3 цифра" {otvet});