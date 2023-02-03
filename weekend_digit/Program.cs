//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
if ((NumberA == 6)||(NumberA == 7))
{    
    Console.WriteLine("Ура! Это выходной!");
}
    else
    {
        Console.WriteLine("Будни. Работаем.");
    }



