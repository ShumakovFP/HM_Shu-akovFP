Console.WriteLine("Введите 1 число: ");
int N1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int N2 = int.Parse(Console.ReadLine());
if (N1 > N2)
{
    Console.WriteLine("Большее число");
    Console.WriteLine(N1);
    Console.WriteLine("Меньшее число");
    Console.WriteLine(N2);
}
else
{
    Console.WriteLine("Большее число");
    Console.WriteLine(N2);
    Console.WriteLine("Меньшее число");
    Console.WriteLine(N1);
}