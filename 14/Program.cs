using System;
class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter x : ");
        string a = Console.ReadLine();
        double x = Convert.ToDouble(a);

        Console.WriteLine("Enter k : ");
        string b = Console.ReadLine();
        double k = Convert.ToDouble(b);

        if(k != 0) {
            double logAnswer = calcLog(x, k);
            Console.WriteLine(logAnswer);
        }else {
            Console.WriteLine("k should not be zero");
        }
    }

    private static double calcLog(double x, double k) {
        double logx = Math.Log10(x);
        double logk = Math.Log10(k);

        double answer = Math.Round(logx / logk, 2);

        return answer;
    }
}
// created by Mohammad reza jahanbakhsh