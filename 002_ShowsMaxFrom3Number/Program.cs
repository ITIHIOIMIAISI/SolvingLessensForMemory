Console.WriteLine("Finding a max from 3 nubmers");
Console.Write("Enter 1 number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter 2 number: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Enter 3 number: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (max < b)  max = b;
    if (max < c) max = c;
Console.Write($"Max nubmer : {max}");