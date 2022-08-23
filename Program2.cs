internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число A ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите целое число B ");
        int B = Convert.ToInt32(Console.ReadLine());
        if(A-B==0)
        {
             Console.WriteLine("равны");
        }
        if(A-B>0)
        {
            Console.WriteLine (A);
        }
        if(A-B<0)
        {
            Console.WriteLine (B);
        }    

    }
}