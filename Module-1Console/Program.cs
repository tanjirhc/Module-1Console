// See https://aka.ms/new-console-template for more information
string[] arrStr = { "ASP", "MVC", "CORE" };

int i = 0;
foreach (string item in arrStr)
{
    Console.WriteLine("Item no: " + (i+1).ToString()+" :"+item);
    i++;
}

Console.ReadLine();