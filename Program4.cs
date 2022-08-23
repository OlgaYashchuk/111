internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число A");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите целое число B");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите целое число C");
        int C = Convert.ToInt32(Console.ReadLine());
        if(A>B)
        {
            if(A>C)
            {
                Console.WriteLine(A);
            }
            else                  
            
            {
                Console.WriteLine(C);
            }
           
        }
        else
        {
            if(B>C)
            {
                Console.WriteLine(B);
            }
           else
            {
                Console.WriteLine(C);
            }
        }    
    }
}
