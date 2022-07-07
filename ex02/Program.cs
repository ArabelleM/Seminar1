// To find the max from two numbers

Console.WriteLine("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

 if (a > b)
 {
    Console.Write("Max is ");
    Console.WriteLine(a);
    Console.Write("Min is ");
    Console.WriteLine(b);
 }
 else
 {
    if (b > a)
    {
        Console.Write("Max is ");
        Console.WriteLine(b);
        Console.Write("Min is ");
        Console.WriteLine(a);
    }
    else 
    {
        Console.WriteLine("equality");
    }
 }
 
 