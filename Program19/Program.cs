
Console.WriteLine("Введите целое пятизначное число");
string num = Console.ReadLine();
char[] array = num.ToCharArray();

if(array[0]==array[4] && array[1]==array[3])
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("не палиндром");
}