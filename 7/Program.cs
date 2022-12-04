using System;
class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");
        string x = Console.ReadLine();
        int n = Convert.ToInt32(x);

        calcFunction(n);
    }

    private static void calcFunction(int n) {
        for(int i = 1 ; i <= n; i++) {
            Console.Write(i + " : ");
            for(int j = 1; j <= 10; j++) {
                Console.Write(" X ");
            }
            Console.WriteLine();
        }
    }
}
// created by Mohammad reza jahanbakhsh
