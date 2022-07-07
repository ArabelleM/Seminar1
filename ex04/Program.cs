// To find the max from three numbers

Console.WriteLine("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

 if (b > max) max = b;
 if (c > max) max = c;


Console.WriteLine(max);
 