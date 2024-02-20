//Name : Ashmandeep kaur
//Student id: 200555988
//Lab 1

using System;

// Here we declared a namespace, called "MathMethod"

namespace MathMethod
{  
    //declaring a class called program inside the namespace
    class Program
    {
        //Creating the main methid, which is the entry point of any program
        static void Main(string[] args)
        {
            //Prompting the user to enter an integer value between 0 and 10

            Console.WriteLine("Plaease enter a numeric integer value between 0 and 10:");

            //Then we use the if-else conditionals
            //this line takes the user input from the console and then parse the input into integer value using int.tryParse function
            //Then the integer value is stored in a variable, called "userInput" and then the given conditions are checked 
            //out keyword is used here to declare and assign the variable in the same line
            if (int.TryParse(Console.ReadLine(), out int userInput) && userInput >= 0 && userInput <= 10)
            {
                //If the value of the userInput is between 0 and 10, then it calls the getFactorial method
                //userInput is passed as an argument ot the getFactorial method
                //And the result is stored in a variable called "FactorialResult"
                int factorialResult = getFactorial(userInput);
                //Then the result is printed to the console
                Console.WriteLine($"Factorial of {userInput} is: {factorialResult}");
            }
            //If the user input is not a numeric value between 0 and 10 then it will print the given error message to the console
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric integer value between 0 and 10.");
            }
        }

        // Creating the custom method to calculate factorial,which will be a recursive method
        //This method accepts an integer argument and return its factorial value
        //This method will return an integer value, it is not a void method
        static int getFactorial(int value)
        {
            //if the given value is 0 or 1 this method returns 1
            if (value == 0 || value == 1)
            {
                return 1;
            }

            //if the value is other than 0 or 1 then this method calls itself again with "value-1" as an arguemnt
            //Then it multiplies the result with the current value
            //this process is repeated until the value becomes 1
            
            return value * getFactorial(value - 1);
        }

    }
    
}