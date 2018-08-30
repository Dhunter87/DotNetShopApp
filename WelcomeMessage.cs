using System;
namespace SelfTrainingProject.DotNetShop
{
    public class WelcomeMessage
    {
		public WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***************************************************************************************");
            Console.Write("*");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("                                                                                     ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("*");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("                            HUNTER TECHNICIAL SOLUTIONS!                             ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("*");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("                                    .NET shop                                        ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*");

            Console.Write("*");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("                                                                                     ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***************************************************************************************\n\n");

            Console.ResetColor();
            Console.WriteLine("                                 Welcome to the menu                                  \n");
        }
    }
}
