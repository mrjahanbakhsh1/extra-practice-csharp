using System;
class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a : ");
        string x = Console.ReadLine();
        double a = Convert.ToDouble(x);

        Console.WriteLine("Enter b : ");
        string y = Console.ReadLine();
        double b = Convert.ToDouble(y);

        Console.WriteLine("Enter c : ");
        string z = Console.ReadLine();
        double c = Convert.ToDouble(z);

        double answer = triangle(a,b,c);
        Console.WriteLine("answer is : " + answer);
    }

    private static double triangle(double a, double b, double c) {
            if(a+b >c && a+c>b && c+b>a) {
            
            if(a*a == b*b + c*c || b*b == c*c + a*a || c*c == b*b + a*a) {
                return 1;
            }else if(a==b && b==c && c==a) {
                return 3;
            }else if(a==c || a==b || c==b) {
                return 2;
            }else {
                return -1;
            }

        } else {
            return 0;
        }
    }
}
// created by Mohammad reza jahanbakhsh