Console.Write("Введите первое число ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int secondnumber = Convert.ToInt32(Console.ReadLine());
if (firstnumber > secondnumber)
{
Console.Write("max = " + firstnumber + ", min = " + secondnumber);
}
else if (firstnumber < secondnumber)
{Console.Write("max = "+ secondnumber + ", min = " + firstnumber);}
else 
{
Console.Write("max = min = " + firstnumber);
}