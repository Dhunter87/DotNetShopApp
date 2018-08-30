using System;
namespace SelfTrainingProject.DotNetShop
{
    public class Basket
    {
        public int arrayIndex;
        public string[] SelectedItems = new string[10];
        public double[] price = new double[10];
        public double totalPrice = 0.0;

        public void ViewSelectedItems()
        {
            PriceList priceList = new PriceList();
            for (int i = 0; i < SelectedItems.Length; i++)
            {
                if (!(SelectedItems[i] == null))
                {
                    arrayIndex = i;
                    price[i] = priceList.GetPrice(SelectedItems[i]);
                    Console.WriteLine("Selected item : " + SelectedItems[i]); 
                    //foreach(string item in Catalogue.ItemDescription)
                    //{
                    //    Console.Write(item);
                    //}
                    for (int l = 0; l < Catalogue.ItemDescription.Length; l++)
                    {
                        Console.Write(Catalogue.ItemDescription[l]);
                    }
                    Console.WriteLine("Price         : " + price[i]);
                    Console.WriteLine("\n");
                }
                else
                {
                    SelectedItems[i] = "No Item selected!";
                }
            }
        }
        public double CalculateTotalPrice()
        {
            for (int i = 0; i < price.Length; i++)
            {
                totalPrice += price[i];
            }
            Console.WriteLine("Total price   : £" + totalPrice);
            Console.WriteLine("\n");
            return totalPrice;
        }
        public bool ProfileLoginCheck()
        {
            return ProfileLogin.LoggedIn;

        }
    }

}
