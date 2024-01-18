namespace GAIntegralMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int myInt = 2147483647;
            // Int32: Ranges from -2,147,483,648 to 2,147,483,647. Commonly used for general counting.
            long myLong = 9223372036854775807L;
            // Int64: Larger range for big numbers, from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            byte myByte = 255;
            // Byte: Ranges from 0 to 255, often used for small counts or data manipulation.
            short myShort = 32767;
            // Int16: Useful for numbers between -32,768 and 32,767, when int is more than;
            int sum = myInt + 100;
            // Addition: Combines two numbers into a larger sum.
            int difference = myInt - 50;
            // Subtraction: Removes a quantity from another.
            int product = myShort * 2;
            // Multiplication: Scales a number by another number.
            int quotient = myInt / 2;
            // Division: Splits a number into equal parts.
            int remainder = myByte % 10;
            // Modulus: Finds the remainder after division.

            // Assuming the declarations of 'number' and 'shortNumber' variables
            int number = 20; 
            // Example value;
            short shortNumber = 30;
            // Example value;


        }
    }
}
