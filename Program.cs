// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите число от 1-7: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 0 && a < 6)
{
    if (a == 1)
        Console.WriteLine("Monday");  
    else if (a == 2)      
        Console.WriteLine("Tuesday");
    else if (a == 3)     
        Console.WriteLine("Wednesday");
    else if (a == 4)     
        Console.WriteLine("Thursday");
    else if (a == 5)     
        Console.WriteLine("Friday");
    
    Console.WriteLine("Today is a working day");
}    
else if (a == 6 || a == 7)
{
    if (a == 6)     
        Console.WriteLine("Saturday");
    else if (a == 7)     
        Console.WriteLine("Sunday");
        
     Console.WriteLine("Today is a day off");    
}
else
{
    Console.WriteLine("Неверное значение");
}

