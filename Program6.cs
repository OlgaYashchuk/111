internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число X");
        int X = Convert.ToInt32(Console.ReadLine());
        if (X % 2 ==0)
        {
            Console.WriteLine("да");
        }
        else
        {
             Console.WriteLine("нет");
        }
    }
}