//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int n;

while (true)
{
   n = Convert.ToInt32(Console.ReadLine());
   if (n >= 10000 && n < 100000)
   {
      break;
   }
   Console.WriteLine("Число не пятизначное. Попробуйте снова");
}

string a = Convert.ToString(n);
if (a[0] == a[4] && a[1] == a[3])
{
   Console.Write("Число " + n + " палиндром ");

}
else
{
   Console.Write("Число " + n + " не палиндром");

}

