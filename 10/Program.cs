using System;
class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");
        string input = Console.ReadLine();
        int num = Convert.ToInt32(input);

        int p = 1;
        double total = 0;
        for(int  i = 1; i <= num; i++) {

            for(int j = 1; j <= i; j++) {
                p = p * j;
            }

            // to make the output beautiful
            if(i==num) {
                Console.Write(i + "/" + i + "! = ");
            }else if(i < num) {
                Console.Write(i + "/" + i + "!" + " + ");
            }

            total = total + (i / (double)p);
            p = 1;
        }
        Console.WriteLine(total);
    }
}
// created by Mohammad reza jahanbakhsh