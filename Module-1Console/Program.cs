// See https://aka.ms/new-console-template for more information

//Console.WriteLine(DateTime.Today.Date.ToString("dd/MM/yyyy"));

DateTime ptoday = DateTime.ParseExact("04/02/2024", "dd/MM/yyyy", null);
Console.WriteLine(ptoday.ToString());


Console.ReadLine();