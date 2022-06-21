using System;

namespace Static_method_hidding
{
    // static method hidding :
    class MyClass
    {
        public static void name()
        {
            Console.WriteLine("my name akshay saini");
        }
        public static void show()
        {
            Console.WriteLine("HEllo :");
        }
    }
    class Program:MyClass
    {
        public  new static  void show()
        {
           Program.name();
                Console.WriteLine("hiiii :");
        }
        static void Main(string[] args)
        {
            show();

        }
    }
}
