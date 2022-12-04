using System;
// سوال دوم
class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entere a ZOJ number : ");
        string a = Console.ReadLine();
        int num = Convert.ToInt32(a);

        if(num % 2 == 0) {
            List<int> myArray = new List<int>();

            // چک کردن عدد اول و فرد بودن
            for(int i = 3; i <= num; i++) {
                int x = 0;
                for(int j = 1; j <= num; j++) {
                    if(i % j == 0) {
                        x++;
                    }
                }

                if(x == 2) {
                    myArray.Add(i);
                }
            }

            for(int i = 0; i < myArray.Count; i++) {

                for(int j = i; j < myArray.Count; j++) {
                    int check = myArray[i] + myArray[j];
                    if(check == num) {
                        Console.WriteLine(myArray[i] + "+" + myArray[j] + " = " + check);
                    }
                }
            }
        } else {
            Console.WriteLine("Adad Joz Nist! adad joz vared konid.");
        }
    }
}
// created by Mohammad reza jahanbakhsh