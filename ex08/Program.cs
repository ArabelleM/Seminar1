// all even numbers till N
Console.WriteLine("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
        Console.Write(" ");
        i++;
    }
    else {
        i++;
    }
}