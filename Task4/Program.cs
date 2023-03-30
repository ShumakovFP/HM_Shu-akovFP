int max = 0;
Console.WriteLine("Введите 1 число: ");
int N1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int N2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3 число: ");
int N3 = int.Parse(Console.ReadLine());

if (N1 > max)
{
    max = N1;
}
if (N2 > max)
{
    max = N2;
}
if (N3 > max)
{
   max = N3;
}
Console.WriteLine(max);