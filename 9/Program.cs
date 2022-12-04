using System;
class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");
        string input = Console.ReadLine();
        int num = Convert.ToInt32(input);

        int total = 0;
        for(int  i = 1; i <= num; i++) {
            int factI = factorialFunc(i);
            total = totalFunc(factI, total); // update total variable to can calcut total
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
    private static int totalFunc(int total, int factI) {
        total = total + factI;
        return total;
    }
}
// created by Mohammad reza jahanbakhsh