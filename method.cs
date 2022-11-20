using System;

namespace MethodDemo
{
     class Program
    {
        static void Main(string[] args) {
            PrintStar();//invoke or call of defining of method (PrintStar)
            Console.WriteLine("program start");
            DrawLine();
            int result = AddTwoNums(20, 30);
            float result2 = addFloatValue(10.2f, 23.2f, 14.0f);
            Console.WriteLine($"adding result is :{result}"); //50 
            Console.WriteLine($"adding flating value  is :{result2}"); //50 
            PrintStar();//invoke or call of defining of method (PrintStar)
            Console.WriteLine("program finished");
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
        //define a method 
        static void PrintStar() {
            Console.WriteLine("**********");
        }

        static void DrawLine() {
          for(int j = 0; j < 10; j++) {
                Console.WriteLine( "______________________________________");
            }
        }
        // it has two parameter with int type return 
        static int AddTwoNums(int n1,int n2) {
            int result = n1 + n2;
            return result;
        }
        static float addFloatValue(float f1,float f2,float f3) {
            float result = f1 + f2 + f3;
            return result;
        }
    }
}
