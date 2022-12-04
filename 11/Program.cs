using System;
class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter x : ");
        string a = Console.ReadLine();
        int x = Convert.ToInt32(a);

        Console.WriteLine("Enter a number : ");
        string b = Console.ReadLine();
        int num = Convert.ToInt32(b);

        double total = 0;
        for(int  i = 1; i <= num; i++) {
            int factI = factorialFunc(i);
            total = totalFunc(factI, total, i, x);
            
            if(i==num) {
                Console.Write(x + "^" + i + "/" + i + "! = ");
            }else if(i < num) {
                Console.Write(x + "^" + i + "/" + i + "!" + " + ");
            }
        }

        Console.WriteLine("Answer is : " + total);
    }

    // calcut factorial
    private static int factorialFunc(int i) {
        int p = 1;
        for(int j = 1; j <= i; j++) {
            p = p * j;
        }
        return p;
    }

    // calcut the total of factorial
    private static double totalFunc(double factI ,double total, double i, double x) {
        double powX = Math.Pow(x, i);// power method
        total = total + (powX / factI);
        return total;
    }
}
// created by Mohammad reza jahanbakhsh