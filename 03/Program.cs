Console.Clear();
Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int z = int.Parse(Console.ReadLine());
int max = 0;
if (x >= y && x >= z)
  max = x;
else if (y >= x && y >= z)
  max = y;
else if (z >= y && z >= x)
  max = z;
Console.WriteLine(max);
