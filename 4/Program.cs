using System;
class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Money : ");
        string num = Console.ReadLine();
        double money = Convert.ToDouble(num);

        double moneyTax = calcTax(money);
        Console.WriteLine("Money Tax is : " + moneyTax);

    }

    private static double calcTax(double money) {
        double moneyTax = 0;

        if(money > 0 && money <= 483000) {
            moneyTax = (money) * (0/100d);
        } else if(money > 483000 && money <= 600000) {
            moneyTax = (money) * (10/100d);
        } else if(money > 600000 && money <= 1000000) {
            moneyTax = (money) * (15/100d);
        } else if(money > 1000000 && money <= 2000000) {
            moneyTax = (money) * (20/100d);
        } else if(money > 2000000 && money <= 99999999) {
            moneyTax = (money) * (30/100d);
        }

        return moneyTax;
    }
}
// created by Mohammad reza jahanbakhsh