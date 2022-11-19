using System;

namespace GuessGame2
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Guess Game started (0 to 20)!!");
            Random rdn = new Random();//Object type 
            int rdnNumer = rdn.Next(20);// 0 to 20 
            Console.WriteLine($"generated value is {rdnNumer}");
            Console.Write("Guess Number:");
            int inputvalue = Convert.ToInt32(Console.ReadLine());
            bool isNext = true;
            int count = 0;
            while (isNext) {
                count++;
                  if (inputvalue > 20) {
                    Console.WriteLine("Hay!! Read the game info carefully idiot!! our guess number is between 0 to 20 !! ");
                    Console.Write("Guess again:");
                    inputvalue = Convert.ToInt32(Console.ReadLine());
                }
                else if  (inputvalue == rdnNumer) {// 21 ,22 nd , 3 rd     
                                                    string time = Convert.ToString(count); //21 ,31,41,81,101,201,301,1001
                                                    if (time.EndsWith("1")){
                                                        Console.WriteLine("Wow!! you got it right at " + count + "st time.");
                                                    }
                                                    else if  (time.EndsWith("2")) {//22 82
                                                        Console.WriteLine("Wow!! you got it right at " + count + "nd time.");
                                                    }
                                                    else if (time.EndsWith("3")) {
                                                        Console.WriteLine("Wow!! you got it right at " + count + "rd time.");
                                                    }
                                                    else {
                                                        Console.WriteLine("Wow!! you got it right at " + count + "th time.");
                                                    }
                    isNext = false;
                }
                else if (inputvalue<rdnNumer) {
                    Console.WriteLine("No!! you got it wrong.Your number is too close to my number.Plz try again !! You can do it .");
                    Console.Write("Guess again:");
                    inputvalue = Convert.ToInt32(Console.ReadLine());
                }
                else if (inputvalue > rdnNumer) {
                    Console.WriteLine("No Oh!! Sorry !! you got it wrong Your number is too far to my number.Plz try again !! You can do it .");
                    Console.Write("Guess again:");
                    inputvalue = Convert.ToInt32(Console.ReadLine());
                }
                else if (inputvalue > 20) {
                    Console.WriteLine("Hay!! Read the game info carefully idiot!! our guess number is between 0 to 20 !! ");
                    Console.Write("Guess again:");
                    inputvalue = Convert.ToInt32(Console.ReadLine());
                }
            }//end of while 
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
