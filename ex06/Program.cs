// even or odd number

Console.WriteLine("Enter the number: ");
int a = Convert.ToInt32(Console.ReadLine());

int div = a % 2;

 if (div > 0) {
    Console.WriteLine("odd");
 }
 if (div == 0) {
    Console.WriteLine("even");
 }
else {
    Console.WriteLine("incorrect value"); // if user want write "wedawfawdaq" instead of number
}