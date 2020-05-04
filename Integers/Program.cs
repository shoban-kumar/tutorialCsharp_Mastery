using System;

namespace Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World! 1");

            //Declaring the variable
            int myNumber;

            //Assigning Value  to the variable
            myNumber = 5;

            //Printing my number value in console
            Console.WriteLine("My Number is " + myNumber);

            //reassigning values to the variable myNumber
            myNumber = 8;

            //printing reassigned variable myNumber
            Console.WriteLine("My Reassigned Number 1 is " + myNumber);

            //updating reassigned varible with expression
            myNumber = myNumber + 1; //eg for an expression (Expression is any combination of valid operands and operator)

            //printing reassigned variable myNumber
            Console.WriteLine("My Reassigned Number 2 is " + myNumber);

            //increment  or decrement by operators and only works on integer
            myNumber++;//incrementing
            Console.WriteLine("Incremented Number is " + myNumber);//incremented

            myNumber--; // decrementing
            Console.WriteLine("Decremented Number is " + myNumber);//decremented

            
            //Other short hand ways of operator overloading

            myNumber *= 3;//Multiply
            Console.WriteLine("Multiplied Number is " + myNumber);

            myNumber /= 3;//divide
            Console.WriteLine("Divided Number is " + myNumber);

            myNumber -= 1;//difference
            Console.WriteLine("Subracted Number is " + myNumber);
            
            myNumber %= 3;//Modulus
            Console.WriteLine("Modulo Number is " + myNumber);

            myNumber += 1;//addition
            Console.WriteLine("Addition Number is " + myNumber);

        }
    }
}
