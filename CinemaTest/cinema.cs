using System;
using System.Linq;

namespace CinemaTest
{
    public class cinema
    {

        int i = 1;
        public int price = 0;
        int sum = 0;
        int age;

        public int Price(age)
        {
            // int i = 1;
            //public  int price = 0;
            // int sum = 0;
            Console.WriteLine("Hello! You have came to cinema. \n Enter how many you are? ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (i <= num)
            {
                Console.WriteLine(" Enter Your age");

                age = Convert.ToInt32(Console.ReadLine());

                                   
                        if (age < 20 && age > 4)
                        {
                            Console.WriteLine("Price for Youth is 80 kr");
                            price = 80;
                            sum = sum + price;
                           
                            return price;
                        }


                        else if (age > 64 && age < 101)
                        {
                            Console.WriteLine("Price for Pensioners is 90 kr");
                            price = 90;
                            sum = sum + price;
                    
                            return price;
                        }
                        else if (age < 5 || age > 100)
                        {
                            Console.WriteLine("Your entre is free");
                            price = 0;
                            sum = sum + price;
                            return price;
                        }
                        else
                        {
                            Console.WriteLine("Adult Price  is 120 kr");
                            price = 120;
                            sum = sum + price;
                    
                            return price;
                        }
           

                            i++;

            }
                Console.WriteLine("Your common sum is " + sum + "kr");

                return price;
            }
        }
    

    

