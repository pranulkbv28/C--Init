using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyFirstProject
{
    internal class Program
    {
        public static void BasicsTutorial()
        {
            int num = 2;
            string letter = "a";
            string name = "Pranaav";

            // Other data types
            /*
             * char -> here, the value should be inside single quotes
             * long -> this is just a bigger data type than "int"
             * double -> this is a way to declare a decimal
             * float -> if your precision isn't very strict use "float"
             */



            Console.WriteLine(letter + num);
            Console.Write("Your name is: ");
            Console.WriteLine(name);

            // here, by using "Console.Write()", we can get the outpust to come in a single line.
            // whereas "Console.WriteLine()" starts the curson in another line

            // Convert Data types

            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            // other methods
            /*
             * Convert.ToInt64()
             * Convert.ToDouble()
             * Convert.ToSingle() --> this is to convert it to a float
             * Convert.ToDecimal()
             */

            // Boolean DataType
            bool value = true;

            Console.WriteLine(value);


            // Operators +, -, *, /, ++, --, %
            // it is always preferred to keep a certyain variable as a "double" if "division" is going to be happening over it.
            // instead of the usual way to initialize a variable, i.e. using "int", "string", amd etc, we can also use the "var" keyword
            // but, the catch is that you will have to declare the variable with a value while initializing as it cannot be empty

            var newNum = 42;
            Console.WriteLine(newNum);
            Console.WriteLine(newNum.GetType());

            /* "const" keyword
             * This is used when you want to make a certain variable a constant
             */

            const double taxPercentage = 15.5;
            Console.WriteLine("Tax on ₹1000 is: " + (1000 * taxPercentage) / 100);


            // Input data from user
            // when getting a value from thew user, the datatype should always be a "string"

            string username, userAge;
            Console.WriteLine("What is your name?");
            username = Console.ReadLine();
            Console.WriteLine("The user's name is: " + username);
            Console.WriteLine("What is your age?");
            userAge = Console.ReadLine();
            Console.WriteLine("The user's age is: " + Convert.ToInt32(userAge));


            double money = -30.5;
            CultureInfo ci = new CultureInfo("en-GB");
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));
            Console.WriteLine(ci);


            // TryParse function
            /*
             * This function is used to check if the parsing of a string is being done correctly or not.
             * And, even if it doesn't, then the program won't stop, but it will be able to return a boolean value which can help us in the debugging process
             */

            bool success = true;

            while (success)
            {
                Console.Write("Enter a number: ");
                string numInp = Console.ReadLine();

                if (int.TryParse(numInp, out int outNum))
                // here, numInp is the string which is being converted to an int and outNum is the value being sent out when the conversion happens.
                /* Usually, when the conversion takes place, two things are returned
                 * int.TryParse() function returns a boolean value
                 * and "outNum" return the value of the conversion
                    * now, if the conversion is successful, then
                    * "outNum" returns the converted value
                    * else, it returns 0
                 * to tackle the confusion if in case the user given value is also a 0, we use the boolean to check if the conversion was successful or not
                 */
                {
                    success = false;
                    Console.WriteLine("Successfully converted!!");
                    Console.WriteLine(outNum);
                }
                else
                {
                    Console.WriteLine("Failed to convert");
                }
            }

            // Verbatim Identifier and other ways to write a string
            /*
             * you can use $"Hi my name is {name}"; here, name is the variable
             * you can use @""; and when you type the string here, you do not need to put in the escape character
             */

            string myName = "Pranaav";
            int myAge = 22;
            string sentence = $"My name is {myName} and my age is {myAge}"; // this is also called string interpolation     
            Console.WriteLine(sentence);
            Console.WriteLine("My name is {0} and my age is {1}", myName, myAge); // this is another way to get variables inserted into a string

            string nonVerbatimPath = "C:\\Users\\prana\\OneDrive\\Pranaav\\WebDev\\C#\\MyFirstProject"; // here you can see that there is an extra '\' present which is actually the escape character
            string path = @"C:\Users\prana\OneDrive\Pranaav\WebDev\C#\MyFirstProject"; // here, you see that you do not need to use that escape character

            Console.WriteLine(nonVerbatimPath);
            Console.WriteLine(path);


            // How to check if two strings are equal

            string str1 = "Hello", str2 = "Hello";

            Console.WriteLine(str1.Equals(str2)); // this is how to check if two strings are the same

            // while comparing strings, it is better to use inbuilt functions rather than using the "==" method, as the latter ("==") checks for type, value and memory, which is not suited for this sort of a comparison
            //whereas the "Equals" method checks for the value and then returns the comparison

            /* Strings
             * Strings are nothing but an array of characters
             */

            string test1 = "C# is awesome";
            for (int i = 0; i < test1.Length; i++)
            {
                Console.Write(test1[i]);
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {

            bool start = true;

            while (start)
            {
                Console.WriteLine("1. Just basics");
                Console.WriteLine("2. Mini Games");
                Console.Write("Choose what you want to start: ");
                string choice = Console.ReadLine();

                bool rightChoice = int.TryParse(choice, out int result);                

                if (rightChoice)
                {
                    switch (result)
                    {
                        case 1:
                            BasicsTutorial();
                            start = false;
                            Console.WriteLine();
                            Console.WriteLine("Thanks for Learning");
                            break;
                        case 2:
                            Console.WriteLine("1. Tables Game");
                            Console.WriteLine("2. FizzBuzz Game");
                            Console.WriteLine("3. Reverse Your String");
                            Console.WriteLine("4. Password Checker");
                            Console.WriteLine("Choose the Games");
                            string option = Console.ReadLine();
                            bool rightOption = int.TryParse(option, out int gameOption);
                            MiniGames mg = new MiniGames();

                            if (rightOption)
                            {
                                switch (gameOption)
                                {
                                    case 1:
                                        mg.TablesGame();
                                        start = false;                                       
                                        break;
                                    case 2:
                                        mg.FizzBuzzGame();
                                        start = false;                                        
                                        break;
                                    case 3:
                                        mg.ReverseString();
                                        start = false;
                                        break;
                                    case 4:
                                        mg.PasswordChecker();
                                        start = false;
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Choice");
                                        break;
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Thanks for Playing");
                            break;
                        default:
                            Console.WriteLine("Enter the right option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            Console.ReadLine();
        }
    }
}
