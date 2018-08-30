using System;
namespace SelfTrainingProject.DotNetShop
{
    public class NewProfile
    {
		public static int UserCount;

        public static void addNewProfile()
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter users first name : ");
			Console.ForegroundColor = ConsoleColor.Blue;
            UserProfile.FirstName = Console.ReadLine().Trim();
			Console.ResetColor();
			Console.WriteLine("Please enter users last name  : ");
			Console.ForegroundColor = ConsoleColor.Blue;
			UserProfile.LastName = Console.ReadLine().Trim();
			Console.ResetColor();
			Console.WriteLine("Please enter users date of birth  : ");
			Console.ForegroundColor = ConsoleColor.Blue;
			UserProfile.DateOfBirth = Console.ReadLine().Trim();
			Console.ResetColor();
			Console.WriteLine("Please enter users E-Mail address  : ");
			Console.ForegroundColor = ConsoleColor.Blue;
			UserProfile.EMailAddress = Console.ReadLine().Trim();
			Console.ResetColor();
			Console.WriteLine("Please enter users phone number  : ");
			Console.ForegroundColor = ConsoleColor.Blue;
			UserProfile.PhoneNumber = Console.ReadLine().Trim();
			Console.ResetColor();
			Console.WriteLine("Please enter users address  : ");
			Console.ForegroundColor = ConsoleColor.Blue;
			UserProfile.Address = Console.ReadLine().Trim();
			Console.ResetColor();
			Console.WriteLine("Please enter users user name  : ");
			Console.ForegroundColor = ConsoleColor.Blue;
			UserProfile.UserName = Console.ReadLine().Trim();
			Console.ResetColor();
			Console.WriteLine("Please enter users password   : ");
			Console.ForegroundColor = ConsoleColor.Blue;
			UserProfile.Password = Console.ReadLine().Trim();
			Console.ResetColor();
            UserCount++;
            Console.WriteLine("User count : " + UserCount);
            Console.WriteLine("");

        }
    }
}
