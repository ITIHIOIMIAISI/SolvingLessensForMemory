Console.WriteLine("Shows max and min from Two numbers");
Console.Write("Enter one nubmer : ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter two nubmer : ");
int b = int.Parse(Console.ReadLine());
int max = a;
int min = b;
if (a < b) max = b; min = a;
    Console.Write($"Max number : {max}, Min namber : {min}");