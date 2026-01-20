namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //console.writeline(5 + 5); // addition
            //console.writeline(5 - 5); // subtraction
            //console.writeline(5 * 5); // multiplication
            //console.writeline(13 / 5); // integer division
            //console.writeline(13 % 5); // modulus operator
            //console.writeline(13d / 5d); // floating point division
            //console.writeline(13.0 / 5); // floating point division
            //console.writeline(13 / 5.0); // floating point division
            //console.writeline(13.0 / 5.0); // floating point division


            //console.writeline(5 > 2); // greater than
            //console.writeline(5 < 2); // less than
            //console.writeline(5 == 2); // equality, test if equal
            //console.writeline(5 != 2); // inequality, test if not equal
            //console.writeline(5 >= 2); // greater than or equal to
            //console.writeline(5 <= 2); // less than or equal to

            // compound operators
            int a = 5; // assign 5 to variable a
            a = a + 9; //compound assignment of a + 9
            //can be simplified to :
            //a += 9;
            
            Console.WriteLine(a); // 14

            Console.WriteLine(++a); // increment then print
            Console.WriteLine(a);
            Console.WriteLine(a++); //print then increment
            Console.WriteLine(a);




            //pause
            Console.Read();
        }
    }
} 
