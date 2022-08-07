Console.WriteLine("Введите 2 числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if(a == b)
{   
    Console.WriteLine("Они равны");
}    
else if(a > b)
{   
    Console.WriteLine("Большее " +a); 
    Console.WriteLine("Меньшее " +b);
}
else
{
    Console.WriteLine("Большее " +b);
    Console.WriteLine("Меньшее " +a);
}
