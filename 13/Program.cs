using System;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter n : ");
        string num1 = Console.ReadLine();
        int n = Convert.ToInt32(num1);

        Console.WriteLine("Enter x : ");
        string num2 = Console.ReadLine();
        int x = Convert.ToInt32(num2);

        double sum = 0;

        for(int i = 1; i <= n; i++) {
            int p = 1;
            double powx = Math.Pow(x,i);

            if(i % 2 != 0) { // fard
                for(int j = 1; j <= i; j++) {
                    if(j % 2 != 0) {
                        p = p * j;
                    }
                }
                sum = sum + (powx/p);
                Console.Write(x + "^" + i + "/" + p + "  -  ");
            }

            if(i % 2 == 0) { // zoj
                for(int k = 1; k <= i; k++) {
                    if(k % 2 == 0) {
                        p = p * k;
                    }
                }
                sum = sum - (powx/p);
                Console.Write(x + "^" + i + "/" + p + "  +  ");
            }

        }
        Console.WriteLine(":|: answer : " + sum);
    }
}
// created by Mohammad reza jahanbakhsh