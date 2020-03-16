using System;
using System.Linq;

namespace ovning2
{
    class Program
    {
       
        static void Main(string[] args)
        {

        // Main meny
        Found:
            Console.WriteLine("Hello! You have came to main meny . \n " +
                "1. Enter 1 to go to cinema  \n" +
                "2. Enter 2 to print 10 times your text \n" +
                "3. Enter 3 to Split a statement" +
                "0. Enter 0 or greater/equal 4 to finish \n");

           
            int  SwCase = Convert.ToInt32(Console.ReadLine());

            
            switch (SwCase)
            {

                case 0:     // Finish
                    Console.WriteLine("You finished");
                    break;


                case 1:    //CINEMA
                   

                        int i = 1;
                        int price = 0;
                        int sum = 0;
                        Console.WriteLine("Hello! You have came to cinema. \n Enter how many you are? ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        while (i <= num)
                        {
                            Console.WriteLine(" Enter Your age");

                            int age = Convert.ToInt32(Console.ReadLine());

                            {


                                if (age < 20 && age > 4)
                                {
                                    Console.WriteLine("Price for Youth is 80 kr");
                                    price = 80;
                                    sum = sum + price;
                                   
                                }
                                else if (age > 64 && age < 101)
                                {
                                    Console.WriteLine("Price for Pensioners is 90 kr");
                                    price = 90;
                                    sum = sum + price;
                                    
                                }
                                else if (age < 5 || age > 100)
                                {
                                    Console.WriteLine("Your entre is free");
                                    price = 0;
                                    sum = sum + price;
                                }
                                else
                                {
                                    Console.WriteLine("Adult Price  is 120 kr");
                                    price = 120;
                                    sum = sum + price;
                                   
                                }
                            }

                            i++;

                        }
                        Console.WriteLine("Your common sum is " + sum + "kr");
                        goto Found;
                   


                case 2:     // ten times to print a text
                    Console.WriteLine("Hello! You have came to FOR LOOP. \n Enter your text ");
                    string text = Console.ReadLine();
                    for ( int count = 1; count < 11; count++)
                    {
                        Console.Write(count+"."+text+" ");
                    }

                    goto Found;
                
                case 3:  // print last item from  the statement
                    Console.WriteLine("Hello! You have came to Split block. \n" +
                        " Enter your statement that consists of minst 3 words ");
                    string statement = Console.ReadLine();
                    string[] words = statement.Split(" ");
                    
                    Console.WriteLine(words[words.Length - 1]);          //fist method

                    string last = statement.Split(" ").LastOrDefault();  //second method
                     Console.WriteLine(last);


                    foreach (var v in words)                             //Hantera flera mellanslag i rad

                    {
                        Console.WriteLine(v);
                    }

                    goto Found;
                    
            }

            
        }
    }
}
