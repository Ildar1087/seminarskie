Console.Clear();
Console.Write("введите ваше число товарищ: ");
int num = int.Parse(Console.ReadLine());
int a1 = 0;
while (a1 < num)
{
  a1 = a1 + 2;
   Console.Write($"{a1}");
}
