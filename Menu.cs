using System;
namespace SelfTrainingProject.DotNetShop
{
	public class Menu
	{

		public static int i;
		public Menu()
		{
			WelcomeMessage welcomeMessage = new WelcomeMessage();
            ProfileLogin.LoginResult = 0;

			string errorMessage = "Invalid input";


			for (i = 0; i < 1;)
            {
				while (ProfileLogin.LoginResult < 2)
				{
					Console.WriteLine("Enter 1 to browse catalogue, 2 to sign in, 3 to sign up or quit to shut down program : ");
					Console.ForegroundColor = ConsoleColor.Blue;
					string entry = Console.ReadLine();
					Console.ResetColor();
					if (string.Equals(entry.ToLower(), "quit"))
					{
						System.Environment.Exit(1);
					}
					else if (string.Equals(entry, ""))
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine(errorMessage);
						Console.Beep();
						Console.ResetColor();
					}
					try
					{
						int userEntry = int.Parse(entry);
						if (userEntry == 1)
						{
                            Catalogue catalogue = new Catalogue();
                            catalogue.RunCatalogue();
                        }
						else if (userEntry == 2)
						{
							ProfileLogin.loginAttempt();
							i = 1;
						}
						else if (userEntry == 3)
						{
							NewProfile.addNewProfile();
							i = 0;
						}
						else
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine(errorMessage);
							Console.Beep();
							Console.ResetColor();
						}
					}
					catch (Exception)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine(errorMessage + " Exception handled!");
						Console.Beep();
						Console.ResetColor();
					}
                    if (ProfileLogin.LoginResult == 2)//admin user options
					{
						AdminProfile.RunAdminProfile();
					}
                    else if (ProfileLogin.LoginResult == 3)//general user options
					{
						UserProfile.RunUserProfile();

					}
                    else if (ProfileLogin.LoginResult == 4)//John Doe user options
					{
						ExampleProfile.RunExampleProfile();
					}
                    ProfileLogin.LoginResult = 0;
                }
                i = 0;
			}

		}
	}
}