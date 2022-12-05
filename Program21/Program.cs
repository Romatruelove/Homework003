Console.WriteLine("Введите координаты точки А через пробел");
string lineA = Console.ReadLine();
string[] arrayA = lineA.Split(' ');
int[] pointA = new int[arrayA.Length];

Console.WriteLine("Введите координаты точки B через пробел");
string lineB = Console.ReadLine();
string[] arrayB = lineB.Split(' ');
int[] pointB = new int[arrayB.Length];

for (int i = 0; i < arrayA.Length; i++)
            pointA[i] = int.Parse(arrayA[i]); 

for (int i = 0; i < arrayB.Length; i++)
            pointB[i] = int.Parse(arrayB[i]); 

double distance = Math.Sqrt(Math.Pow((pointB[0] - pointA[0]), 2) + Math.Pow((pointB[1] - pointA[1]), 2) + Math.Pow((pointB[2] - pointA[2]), 2));
Console.WriteLine($"{distance}");