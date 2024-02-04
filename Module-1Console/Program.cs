// See https://aka.ms/new-console-template for more information
int x;
int y;

Console.WriteLine("Please input first item");
x = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Please input second item");
y = Convert.ToInt16(Console.ReadLine());

int z = x + y;

Console.WriteLine("Output sum: " + z.ToString());

Console.ReadLine();