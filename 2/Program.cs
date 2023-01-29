3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 ->  Пятница
Console.Clear();
Console.Write("введите номер дня недели: ");
int numbDayWeek = int.Parse(Console.ReadLine());
if (numbDayWeek < 1 || numbDayWeek > 7)
{
  Console.WriteLine("Введен не правильный номер");
}
if (numbDayWeek == 1)
{
  Console.WriteLine("Понедельник");
}
if (numbDayWeek ==2)
{
  Console.WriteLine("Вторник");
}
if (numbDayWeek ==3)
{
  Console.WriteLine("Среда");
}
if (numbDayWeek == 4)
{
  Console.WriteLine("Четверг");
}
if (numbDayWeek == 5)
{
  Console.WriteLine("Пятница");
}
if (numbDayWeek == 6)
{
  Console.WriteLine("Суббота");
}
if (numbDayWeek == 7)
{
  Console.WriteLine("Воскресенье");
}
