using System;
// سوال اخر دنباله به صورت بازگشتی
class program
{
    public static void Main(string[] args)
    {
        for(int i = 1; i <= 15; i++) {
            int answer = calcFunc(i);
            Console.WriteLine(answer);
        }
    }

    private static int calcFunc(int i) {
        if(i == 1) {
            return 2;
        }

        int f = 2 * calcFunc(i - 1) + 1;
        return f;
    }
}
// created by Mohammad reza jahanbakhsh