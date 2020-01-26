using System;


namespace ProductInventory
{
    class Product
    {
        public static Random rnd = new Random();
        

        public int Amount { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }


        public Product()
        {
            Amount = rnd.Next(100);
            Price = rnd.Next(10, 900);
            Number = rnd.Next(10000);
        }

        public Product(int amount, double price)
        {
            Amount = amount;
            Price = price;
            Number = rnd.Next(10000);
        }

        public Product(int name, int amount, double price)
        {
            Number = name;
            Amount = amount;
            Price = price;
        }

        public double getTotalCost()
        {
            return Price * Amount;
        }

    }
}
