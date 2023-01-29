Console.Clear();
Console.Write("введите ваше число товарищ: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
  Console.Write("цифра чётная и делится на 2");
  
}
else 
{
  Console.Write("цифра не чётная ");
}