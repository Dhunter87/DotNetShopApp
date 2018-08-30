using System;
namespace SelfTrainingProject.DotNetShop
{
    public class Catalogue
    {
        //public static int item;
        public static int CatalogueOptionLoop;
        PriceList priceList = new PriceList();
        char[] code = new char[4];
        string ProductCode = "";
        public static string[] ItemDescription = new string[4];   //char array to store product code

        int FstInput;
        String fstInput = "";
        int SndInput;
        String sndInput = "";
        int TrdInput;               // empty varibles for user input declaired uotside scopes in which they are used, to be accessed outside their scope.
        String trdInput = "";
        int FrthInput;
        String frthInput = "";

        string[] options = new string[4]
        {
                "1. Mens\n"     + "2. Womens",
                "1. Trainers\n" + "2. T-shirts\n" + "3. Shorts\n" + "4. Tracksuit bottoms\n" + "5. Hoodies",
                "1. White\n"    + "2. Black\n"    + "3. Blue\n"   + "4. Red\n"               + "5. Green",
                "1. Nike\n"     + "2. Addidas\n"  + "3. Puma\n"   + "4. Converse\n"          + "5. Lonsdale"
        };

        string PromptUser = "Please select catagory, press B for basket or type quit to exit/logout : ";


            Basket basket = new Basket();

        public Catalogue()
        {

        }
        public void RunCatalogue()
        {
            Console.WriteLine("Welcome");
            for (int j = 0; j < basket.SelectedItems.Length; j++)
            {
                for (CatalogueOptionLoop = 1; CatalogueOptionLoop == 1;)
                {
                    Console.WriteLine(PromptUser);
                    Console.WriteLine("");
                    Console.WriteLine(options[0]);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    fstInput = Console.ReadLine();
                    Console.ResetColor();
                    if (!(string.Equals(fstInput.ToLower(), "b")) || (string.Equals(fstInput.ToLower(), "quit")))
                    {
                        try
                        {
                            FstInput = int.Parse(fstInput);
                            if (!(FstInput == 1 || FstInput == 2))
                            {
                                throw new OutOfBoundsException(OutOfBoundsException.OutOfBoundsExceptionMessage);
                            }
                            if (FstInput == 1)
                            {
                                code[0] = 'M';
                                ItemDescription[0] = "Mens ";
                            }
                            else if (FstInput == 2)
                            {
                                code[0] = 'W';
                                ItemDescription[0] = "Womens ";
                            }
                            CatalogueOptionLoop = 2;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            CatalogueOptionLoop = 1;
                        }
                    }
                    else
                    {
                        basket.ProfileLoginCheck();
                        if (ProfileLogin.LoggedIn == true)
                        {
                            basket.ViewSelectedItems();
                            basket.CalculateTotalPrice();
                        }
                        else if (ProfileLogin.LoggedIn == false)
                        {
                            ProfileLogin.loginAttempt();
                            basket.ViewSelectedItems();
                            basket.CalculateTotalPrice();
                            //break;
                        }

                    }

                    if (fstInput.ToLower() == "quit")
                    {
                        ProfileLogin.LoggedIn = false;
                        Console.Clear();
                        Menu menu = new Menu();
                    }

                }

                for (CatalogueOptionLoop = 2; CatalogueOptionLoop == 2;)
                {
                    Console.WriteLine(PromptUser);
                    Console.WriteLine("");
                    Console.WriteLine(options[1]);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    sndInput = Console.ReadLine();
                    Console.ResetColor();
                    if (string.Equals(sndInput.ToLower(), "quit"))
                    {
                        ProfileLogin.LoggedIn = false;
                        Console.Clear();
                        Menu menu = new Menu();
                    }
                    try
                    {
                        SndInput = int.Parse(sndInput);
                        if (!(SndInput == 1 || SndInput == 2 || SndInput == 3 || SndInput == 4 || SndInput == 5))
                        {
                            throw new OutOfBoundsException(OutOfBoundsException.OutOfBoundsExceptionMessage);
                        }
                        if (SndInput == 1)
                        {
                            code[1] = 'K';
                            ItemDescription[1] = "Trainers ";
                        }
                        else if (SndInput == 2)
                        {
                            code[1] = 'T';
                            ItemDescription[1] = "T-shirts ";
                        }
                        else if (SndInput == 3)
                        {
                            code[1] = 'S';
                            ItemDescription[1] = "Shorts ";
                        }
                        else if (SndInput == 4)
                        {
                            code[1] = 'B';
                            ItemDescription[1] = "Tracksuit bottoms ";
                        }
                        else if (SndInput == 5)
                        {
                            code[1] = 'H';
                            ItemDescription[1] = "Hoodies ";
                        }
                        CatalogueOptionLoop = 3;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        CatalogueOptionLoop = 2;
                    }
                }

                for (CatalogueOptionLoop = 3; CatalogueOptionLoop == 3;)
                {
                    Console.WriteLine(PromptUser);
                    Console.WriteLine(options[2]);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    trdInput = Console.ReadLine();
                    Console.ResetColor();
                    if (string.Equals(trdInput.ToLower(), "quit"))
                    {
                        ProfileLogin.LoggedIn = false;
                        Console.Clear();
                        Menu menu = new Menu();
                    }
                    try
                    {
                        TrdInput = int.Parse(trdInput);
                        if (!(TrdInput == 1 || TrdInput == 2 || TrdInput == 3 || TrdInput == 4 || TrdInput == 5))
                        {
                            throw new OutOfBoundsException(OutOfBoundsException.OutOfBoundsExceptionMessage);
                        }
                        if (TrdInput == 1)
                        {
                            code[2] = '1';
                            ItemDescription[2] = "White ";
                        }
                        else if (TrdInput == 2)
                        {
                            code[2] = '2';
                            ItemDescription[2] = "Black ";
                        }
                        else if (TrdInput == 3)
                        {
                            code[2] = '3';
                            ItemDescription[2] = "Blue ";
                        }
                        else if (TrdInput == 4)
                        {
                            code[2] = '4';
                            ItemDescription[2] = "Red ";

                        }
                        else if (TrdInput == 5)
                        {
                            code[2] = '5';
                            ItemDescription[2] = "Green ";
                        }
                        CatalogueOptionLoop = 4;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        CatalogueOptionLoop = 3;
                    }
                }


                for (CatalogueOptionLoop = 4; CatalogueOptionLoop == 4;)
                {
                    Console.WriteLine(PromptUser);
                    Console.WriteLine(options[3]);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    frthInput = Console.ReadLine();
                    Console.ResetColor();
                    if (string.Equals(frthInput.ToLower(), "quit"))
                    {
                        ProfileLogin.LoggedIn = false;
                        Console.Clear();
                        Menu menu = new Menu();
                    }
                    try
                    {
                        FrthInput = int.Parse(frthInput);
                        if (!(FrthInput == 1 || FrthInput == 2 || FrthInput == 3 || FrthInput == 4 || FrthInput == 5))
                        {
                            throw new OutOfBoundsException(OutOfBoundsException.OutOfBoundsExceptionMessage);
                        }
                        else if (FrthInput == 1)
                        {
                            code[3] = 'N';
                            ItemDescription[3] = "Nike \n";
                        }
                        else if (FrthInput == 2)
                        {
                            code[3] = 'A';
                            ItemDescription[3] = "Addidas \n";
                        }
                        else if (FrthInput == 3)
                        {
                            code[3] = 'P';
                            ItemDescription[3] = "Puma \n";
                        }
                        else if (FrthInput == 4)
                        {
                            code[3] = 'C';
                            ItemDescription[3] = "Converse \n";
                        }
                        else if (FrthInput == 5)
                        {
                            code[3] = 'L';
                            ItemDescription[3] = "Lonsdale \n";
                        }
                        CatalogueOptionLoop = 5;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        CatalogueOptionLoop = 4;
                    }
                }

                for (CatalogueOptionLoop = 5; CatalogueOptionLoop == 5;)
                {
                    ProductCode = new string(code);
                    Console.WriteLine("Product Code : " + ProductCode);
                    foreach (string item in ItemDescription)
                    {
                        Console.Write(item);
                    }
                    double price = priceList.GetPrice(ProductCode);
                    Console.WriteLine("Price : £" + price);
                    Console.WriteLine("Add item to basket Y/N?");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    string addToBasket = Console.ReadLine();
                    Console.ResetColor();
                    if (!(addToBasket.ToLower() == "y" || addToBasket == "n"))
                    {
                        CatalogueOptionLoop = 5;
                        throw new Exception();
                    }
                    if (addToBasket.ToLower() == "y")
                    {
                        try
                        {
                            basket.SelectedItems[j] = ProductCode;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            CatalogueOptionLoop = 5;
                        }

                        CatalogueOptionLoop = 1;

                    }
                    else if (addToBasket.ToLower() == "n")
                    {
                        j--;
                        CatalogueOptionLoop = 1;
                    }
                }
            }
            basket.ViewSelectedItems();
            basket.CalculateTotalPrice();
        }
    }
}
