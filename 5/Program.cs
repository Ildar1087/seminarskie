Console.Clear();
Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());
int i = -1 * number;
while(i <= number)
{
  Console.Write($"{i}");
  i++;
}