using System;
// برنامه ای که اعداد بر مبنای 10 به مبنای مورد نظر تبدیل شود
class program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter n number : ");
        string num = Console.ReadLine();
        int n = Convert.ToInt32(num);

        Console.WriteLine("Enter b number : ");
        string num2 = Console.ReadLine();
        int b = Convert.ToInt32(num2);

        List<int> myArray = new List<int>();

        // the operation(convert decimal to b basis)
        if(b != 0 && b<=10) {
            // update the indexes of myArray
            myArray = convertFunction(n,b, myArray);
            
            // a loop to revers index of array for showing b bases numbers
            for(int j = myArray.Count - 1; j >= 0; j--) {
                Console.Write(myArray[j]);
            }

        }else {
            Console.WriteLine("Error! It should be 0 < b <= 10");
        }


    }

    private static List<int> convertFunction(int n, int b, List<int> convertArray) {
        int temp, y;
        if(n != 0) {
            temp = n;
            n = n / b;
            y = temp % b;
            convertArray.Add(y);
            convertFunction(n, b, convertArray);            
        }

        return convertArray;
    }
}
// created by Mohammad reza jahanbakhsh