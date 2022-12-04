using System;
class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input : ");
        string input = Console.ReadLine();
        double n;
        char c;

        if(double.TryParse(input, out n)) {
            Console.WriteLine("It is number");

        }else if(char.TryParse(input, out c)) {
            // method for check upper or lower case
            bool upper = Char.IsUpper(c);
            bool lower = Char.IsLower(c);

            if(upper) {
                Console.WriteLine("It is a 'Capital' letter");
            }else if (lower) {
                Console.WriteLine("It is a 'Lower' letter");
            }

        }else {
            Console.WriteLine("We Do Not Support Your Input!");
        }
    }
}
// created by Mohammad reza jahanbakhsh
