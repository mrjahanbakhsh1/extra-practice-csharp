using System;
class program
{
    public static void Main(string[] args)
    {
        double r;
        for(int i = 5; i <= 90; i += 5) {
            r = (3.1415 * i) / 180;

            double mySin = Math.Floor(Math.Sin(r) * 1000 + 0.5) / 1000;
            double myCon = Math.Floor(Math.Cos(r) * 1000 + 0.5) / 1000;
            double myTan = Math.Floor(Math.Tan(r) * 1000 + 0.5) / 1000;
            Console.Write("Sin : " +mySin + "\t" + "Cos : " +myCon + "\t" + "Tan : " +myTan);
            Console.WriteLine();
        }

    }
}
// created by Mohammad reza jahanbakhsh