internal class NewBaseType
{
    private static void Main(string[] args)
    {
        int x = 1;
        Console.WriteLine("Введите число N");
        int N = Convert.ToInt32(Console.ReadLine());
        x = x + 1;
        while (x <= N)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine(x);
            }
            x++;
        }
    }
}
