using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class MiniGames
    {
        public void TablesGame()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, number, i*number);
            }
        }

        public void FizzBuzzGame()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <=number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                } else if (i%5 == 0)
                {
                    Console.WriteLine("Buzz");
                } else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                } else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void ReverseString()
        {
            Console.Write("Enter the string: ");
            string str = Console.ReadLine();

            //Console.WriteLine(str.Reverse().ToArray());

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }

        public void PasswordChecker()
        {            
            string newPwd = "";
            string pwd = "";

            bool check = false;

            do
            {
                Console.Write("Make a new Password: ");
                newPwd = Console.ReadLine();
                Console.Write("Re-enter your password: ");
                pwd = Console.ReadLine();

                if (string.IsNullOrEmpty(pwd) || string.IsNullOrEmpty(newPwd))
                {
                    if (pwd.Equals("") || newPwd.Equals(""))
                    {
                        Console.WriteLine("Enter the Password");
                        Console.WriteLine();
                    }
                } else
                {
                    check = true;
                }

            } while (!check);

            Console.WriteLine();

            if(newPwd.Equals(pwd))
            {
                Console.WriteLine("Passwords Match");
                Console.WriteLine("User Authenticated");
            } else
            {
                Console.WriteLine("Incorrect Password");
                Console.WriteLine("User Authentication Failed");
            }
            
        }

        public static void ExitMessage(int choice)
        {        
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Thanks for learning!!");
                    break;
                case 2:
                    Console.WriteLine("Thanks for playing!!");
                    break;
            }
        }
    }
}
