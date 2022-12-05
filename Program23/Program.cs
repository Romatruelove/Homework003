Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i<=number; i++)
{
    double cube = Math.Pow(i, 3);
    Console.Write($"{cube} ");
}