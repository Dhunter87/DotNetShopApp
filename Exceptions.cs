using System;
namespace SelfTrainingProject.DotNetShop
{
    public class DotNetExceptions : System.Exception
    {
        public DotNetExceptions()
        {
        }
        public DotNetExceptions(string message): base (message)
        {
        }
    }
    public class OutOfBoundsException : DotNetExceptions
    {
        public static string OutOfBoundsExceptionMessage = "Number not within range, Try again!";
        public OutOfBoundsException()
        {
            Console.WriteLine("Number not within range, Try again!");
        }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}