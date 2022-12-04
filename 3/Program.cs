using System;
class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entere a number : ");
        string a = Console.ReadLine();
        int num = Convert.ToInt32(a);

        isSquare(num);
        // یا میتوان از کد سوال 2 باری اینکه تشخیص دهیم صحیص است یا نه استفاده شود
        // b == (int)b => عدد صحیح است یا خیر
    }

    private static void isSquare(int num) {
        for(int i = 0; i <= num; i++) {
            
            int check = i*i;
            if(check == num) {
                Console.WriteLine("YES : "+i);
                break;
            }else if(check > num) {
                Console.WriteLine("NO");
                break;
            }

            // OR

            /*
                double b = Math.Sqrt(check);
                if(b == (int)b){}
            */
        }
    }
}
// created by Mohammad reza jahanbakhsh