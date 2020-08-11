using System;

namespace AnonymousDelegates
{
    //Anonymous functions can be used to increase your code's
    //readability by declaring the implementation of the delegate 
    //right in line where it is used.
    public delegate string myDelegate(int arg1, int arg2);

    class Program
    {
        static void Main(string[] args)
        {
            //delegate in this context is used to declare the 
            //the function in line with the code
            myDelegate f = delegate (int arg1, int arg2)
            {
                return (arg1 + arg2).ToString();
            };
            Console.WriteLine("The number is " + f(10, 20));
            //Keep the console open until a key is pressed
            Console.WriteLine("\n press any key to continue");
            Console.ReadLine();

        }
    }
}
