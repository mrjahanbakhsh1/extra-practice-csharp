using System;
class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");
        string a = Console.ReadLine();
        int num = Convert.ToInt32(a);

        int answer = calcFunction(num);
        Console.WriteLine("Answer is : " + answer);
    }

    private static int calcFunction(int num) {
        int x;
        int  p = 1;
        while(num > 0) {
            x = num % 10;
            num = num / 10;
            
            if(x % 2 == 0) {
                p = p * x;
            }
        }

        if(p % 2 != 0) {
            return 0;
        }

        return p;
    }
}
// created by Mohammad reza jahanbakhsh
