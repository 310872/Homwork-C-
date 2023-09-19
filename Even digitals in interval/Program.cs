Console.WriteLine("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count <= n)
{
    if(count%2 > 0)
    {
        Console.WriteLine(" ");
    }
    else
    {
        Console.WriteLine($"четные: {count}");
            }
count = count + 1;
}
