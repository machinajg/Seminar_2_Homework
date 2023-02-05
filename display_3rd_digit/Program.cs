// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine()); 
if (numberA < 100) 
{
    Console.WriteLine("Третьей цифры нет");
}
else
if (numberA < 1000)
{
    int  numberB  = numberA % 10;
}
if (numberA < 10000 & numberA > 1000)
{
    int numberB  = (numberA / 10) % 10;
}
if (numberA < 100000 & numberA > 10000)
{
    int numberB = (numberA / 100) % 10; 
}
if (numberA < 1000000 & numberA > 100000)
{
    int numberB = (numberA / 1000) % 10;
    Console.WriteLine($"Третья цифра - это: {numberB}");
}

// и так далее
// Вопрос: Как автоматизировать цикл, чтобы при увеличении  numberA в 10 раз делитель тоже увеличивался на один ноль?
