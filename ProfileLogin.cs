using System;
namespace SelfTrainingProject.DotNetShop
{
    public class ProfileLogin
    {
        
		public static bool LoggedIn = false;

		public static int LoginResult = 0;

        public static void loginAttempt()
        {
            string errorMessage = "Ivalid input";

			for (int loginAttempts = 1; loginAttempts <= 3; loginAttempts++)
			{
				Console.WriteLine("");
				Console.WriteLine("login attempts : " + loginAttempts);
				Console.WriteLine("Please enter your username or type \"quit\" to exit: ");
				Console.ForegroundColor = ConsoleColor.Blue;
				string userNameAttempt = Console.ReadLine();
				Console.ResetColor();
				if (string.Equals(userNameAttempt.ToLower(), "quit"))
				{
					break;
				}
				else if (string.Equals(userNameAttempt, UserProfile.UserName) ||
						(string.Equals(userNameAttempt, ExampleProfile.UserName)))
				{
					Console.WriteLine("Please enter your password or type \"quit\" to exit : ");
					Console.ForegroundColor = ConsoleColor.Blue;
					string passwordAttempt = Console.ReadLine();
					Console.ResetColor();
					if (string.Equals(userNameAttempt.ToLower(), "quit"))
					{
						break;
					}
					else if (string.Equals(passwordAttempt, UserProfile.Password))
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("Access Granted!");
						Console.WriteLine(DateTime.Now);
						Console.ResetColor();
						Console.WriteLine("");
						LoggedIn = true;
                        LoginResult = 3;
						break;
					}
					else if (string.Equals(passwordAttempt, ExampleProfile.Password))
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("Access Granted!");
						Console.WriteLine(DateTime.Now);
						Console.ResetColor();
						Console.WriteLine("");
						LoggedIn = true;
                        LoginResult = 4;
                        break;
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Access Denied!");
						Console.WriteLine(DateTime.Now);
						Console.Beep();
						Console.ResetColor();

						Console.WriteLine("Press enter to continue or 1 to retrieve forgotten password!");
						Console.ForegroundColor = ConsoleColor.Blue;
						string entry = Console.ReadLine();
						Console.ResetColor();
						if (string.Equals(entry, "") || (string.Equals(entry, null)))
						{
							if (loginAttempts == 3)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("Login attempts limit reached!");
								Console.ResetColor();
								Console.WriteLine("");
								Menu.i = 0;
								Menu menu = new Menu();
								continue;
							}
						}
						if (string.Equals(entry, "1"))
						{
							Console.WriteLine("");
							Console.WriteLine("Please enter users first name: ");
							Console.ForegroundColor = ConsoleColor.Blue;
							string firstname = Console.ReadLine().Trim();
							Console.ResetColor();
							if (string.Equals(firstname, UserProfile.FirstName) ||
							   (string.Equals(firstname, ExampleProfile.FirstName)))
							{
								Console.WriteLine("Please enter users last name: ");
								Console.ForegroundColor = ConsoleColor.Blue;
								string lastName = Console.ReadLine().Trim();
								Console.ResetColor();
								if (string.Equals(lastName, UserProfile.LastName) ||
								   (string.Equals(lastName, ExampleProfile.LastName)))
								{
									Console.WriteLine("Please enter date of birth: ");
									Console.ForegroundColor = ConsoleColor.Blue;
									string dateOfBirth = Console.ReadLine().Trim();
									Console.ResetColor();
									if (string.Equals(dateOfBirth, UserProfile.DateOfBirth) ||
									   (string.Equals(dateOfBirth, ExampleProfile.DateOfBirth)))
									{
										Console.WriteLine("Please enter address: ");
										Console.ForegroundColor = ConsoleColor.Blue;
										string address = Console.ReadLine().Trim();
										Console.ResetColor();
										if (string.Equals(address, UserProfile.Address) ||
										   (string.Equals(address, ExampleProfile.Address)))
										{
											Console.WriteLine("Please enter phone number: ");
											Console.ForegroundColor = ConsoleColor.Blue;
											string phoneNumber = Console.ReadLine().Trim();
											Console.ResetColor();
											if (string.Equals(phoneNumber, UserProfile.PhoneNumber) ||
											   (string.Equals(phoneNumber, ExampleProfile.PhoneNumber)))
											{
												Console.WriteLine("Please enter user name: ");
												Console.ForegroundColor = ConsoleColor.Blue;
												string userName = Console.ReadLine().Trim();
												Console.ResetColor();
												if (string.Equals(userName, UserProfile.UserName))
												{
													Console.WriteLine("Your password is : " + UserProfile.Password);
												}
												else if (string.Equals(userName, ExampleProfile.UserName))
												{
													Console.WriteLine("Your password is : " + ExampleProfile.Password);
												}
												else
												{
													Console.ForegroundColor = ConsoleColor.Red;
													Console.WriteLine(errorMessage);
													Console.Beep();
													Console.ResetColor();
												}
											}
											else
											{
												Console.ForegroundColor = ConsoleColor.Red;
												Console.WriteLine(errorMessage);
												Console.Beep();
												Console.ResetColor();
											}
										}
										else
										{
											Console.ForegroundColor = ConsoleColor.Red;
											Console.WriteLine(errorMessage);
											Console.Beep();
											Console.ResetColor();
										}
									}
									else
									{
										Console.ForegroundColor = ConsoleColor.Red;
										Console.WriteLine(errorMessage);
										Console.Beep();
										Console.ResetColor();
									}
								}
								else
								{
									Console.ForegroundColor = ConsoleColor.Red;
									Console.WriteLine(errorMessage);
									Console.Beep();
									Console.ResetColor();
								}
							}
							else
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine(errorMessage);
								Console.Beep();
								Console.ResetColor();
							}
						}
						else if (string.Equals(entry, ""))
						{
							continue;
						}
						else
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine(errorMessage);
							Console.Beep();
							Console.ResetColor();
						}
					}
				}
				else if (string.Equals(userNameAttempt, AdminProfile.adminUserName))
				{
					Console.WriteLine("Please enter admin password or type \"quit\" to exit : ");
					Console.ForegroundColor = ConsoleColor.Blue;
					string adminPasswordAttempt = Console.ReadLine().Trim();
					Console.ResetColor();
					if (string.Equals(adminPasswordAttempt.ToLower(), "quit"))
					{
						break;
					}
					else if (string.Equals(adminPasswordAttempt, AdminProfile.adminPassword))
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("Access Granted!");
						LoggedIn = true;
						Console.WriteLine(DateTime.Now);
                        Console.ResetColor();
                        Console.WriteLine("");
                        LoginResult = 2;
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("User name not found!");
                    Console.Beep();
                    Console.ResetColor();
                    Console.WriteLine("Press enter to continue or 1 to retrieve forgotten user name!");
                    Console.ForegroundColor = ConsoleColor.Blue;
					string entry = Console.ReadLine();
                    Console.ResetColor();
					if (string.Equals(entry, "")|| (string.Equals(entry, null)))
                    {
						if (loginAttempts == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Login attempts limit reached!");
                            Console.ResetColor();
                            Console.WriteLine("");
                            Menu.i = 0;
                            Menu menu = new Menu();
							continue;
                        }
                    }
                    if (string.Equals(entry, "1"))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Please enter users first name: ");
						Console.ForegroundColor = ConsoleColor.Blue;
						string firstname = Console.ReadLine().Trim();
                        Console.ResetColor();
                        if (string.Equals(firstname, UserProfile.FirstName) ||
                           (string.Equals(firstname, ExampleProfile.FirstName)))
                        {
                            Console.WriteLine("Please enter users last name: ");
							Console.ForegroundColor = ConsoleColor.Blue;
							string lastName = Console.ReadLine().Trim();
                            Console.ResetColor();
                            if (string.Equals(lastName, UserProfile.LastName) ||
                               (string.Equals(lastName, ExampleProfile.LastName)))
                            {
                                Console.WriteLine("Please enter date of birth: ");
								Console.ForegroundColor = ConsoleColor.Blue;
								string dateOfBirth = Console.ReadLine().Trim();
                                Console.ResetColor();
                                if (string.Equals(dateOfBirth, UserProfile.DateOfBirth) ||
                                   (string.Equals(dateOfBirth, ExampleProfile.DateOfBirth)))
                                {
                                    Console.WriteLine("Please enter address: ");
									Console.ForegroundColor = ConsoleColor.Blue;
									string address = Console.ReadLine().Trim();
                                    Console.ResetColor();
                                    if (string.Equals(address, UserProfile.Address) ||
                                       (string.Equals(address, ExampleProfile.Address)))
                                    {
                                        Console.WriteLine("Please enter phone number: ");
										Console.ForegroundColor = ConsoleColor.Blue;
										string phoneNumber = Console.ReadLine().Trim();
                                        Console.ResetColor();
                                        if (string.Equals(phoneNumber, UserProfile.PhoneNumber))
                                        {
                                            Console.WriteLine("Your user name is : " + UserProfile.UserName);
                                        }
                                        else if (string.Equals(phoneNumber, ExampleProfile.PhoneNumber))
                                        {
                                            Console.WriteLine("Your user name is : " + ExampleProfile.UserName);
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(errorMessage);
                                            Console.Beep();
                                            Console.ResetColor();
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(errorMessage);
                                        Console.Beep();
                                        Console.ResetColor();
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(errorMessage);
                                    Console.Beep();
                                    Console.ResetColor();
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(errorMessage);
                                Console.Beep();
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(errorMessage);
                            Console.Beep();
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(errorMessage);
                        Console.Beep();
                        Console.ResetColor();
                    }

                }
                if (loginAttempts == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Login attempts limit reached!");
                    Console.ResetColor();
                    Console.WriteLine("");
                    Menu newMenu = new Menu();
                }
            }
        }
    }
}
