using System;
class Program
{
	public static void Main(string[] args)
	{
        Console.WriteLine("Enter a : ");
        string n1 = Console.ReadLine();
        int a = Convert.ToInt32(n1);

        Console.WriteLine("Enter n : ");
        string n2 = Console.ReadLine();
        int n = Convert.ToInt32(n2);

        int i = 0;
        double c = 1;
        double answer = calcFunction(a,n,c,i);

        Console.WriteLine(answer + "e^" + a + "x");
	}

    private static double calcFunction(int a, int n, double c, int i) {
        if(i <= n) {
            c = Math.Pow(a, n);
            i++;
            calcFunction(a,n,c,i);
            return c;
        }

        return 0;
    }
}
// created by Mohammad reza jahanbakhsh