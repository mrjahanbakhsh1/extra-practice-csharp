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
            // show the Shape
            for(int i = 1; i <= check; i++) {
                for(int j = 1; j <= i; j++) {

                    for(int k = 1; k <= i - j; k++) {
                        Console.Write(" ");
                    }

                    for(int z = 0; z < j; z++) {
                        Console.Write("o ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("n =  " + i);
                Console.WriteLine();
            }
        }else {
            Console.WriteLine(check);
        }


    }

    private static int isTrain(int num) {
        int x = 0;
        bool check = false;
        int  i;
        for(i = 0; i <= num; i++) { // 6 = 1+2+3 ....
            x = x + i;
            if(x == num) {
                // Console.WriteLine(i+1); // نشان دادن جمله ان ام
                check = true;
                break;
            }
            check = false;
        }

        if(check) {
            return i+1;
        }else {
            return 0;
        }
    }
}
// created by Mohammad reza jahanbakhsh