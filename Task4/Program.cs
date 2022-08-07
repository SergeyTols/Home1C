Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;

Console.WriteLine("Четные:");

while(a <= N)
{
    if(a % 2 == 0) 
        Console.Write(" " +a);
        a = a + 1;
}    