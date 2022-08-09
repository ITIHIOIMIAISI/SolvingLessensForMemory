Console.WriteLine("ShowsAllEvenNumber(N)");
Console.Write("Enter nubmer : ");
int nubmer = int.Parse(Console.ReadLine());

for (int index = 0; index < nubmer; index++)
{
    if ((index % 2) == 0)
        Console.Write($"{index} ");
}