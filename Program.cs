System.Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    System.Console.WriteLine("MAX" + number1);
}
else 
{
    System.Console.WriteLine("MAX" + number2);
}
if (number1 < number2)
{
    System.Console.WriteLine("MIN" + number1);
}
else 
{
    System.Console.WriteLine("MIN" + number2);
}