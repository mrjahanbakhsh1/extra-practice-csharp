using System;
class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entere a number : ");
        string a = Console.ReadLine();
        int num = Convert.ToInt32(a);

        int check = isTrain(num);
        Console.WriteLine("-------");

        if(check != 0)  {
            Console.WriteLine(check);
        }else {
            Console.WriteLine(check);
        }


    }

    private static int isTrain(int num) {
        // find it by delat
        int delta = 1 + 4*(2*num);// delta = b^2-4ac
        double b = Math.Sqrt(delta);

        if(b == (int)b) { // if it was integer
            return 1;
        }else {
            return 0;
        }
    }
}
// created by Mohammad reza jahanbakhsh