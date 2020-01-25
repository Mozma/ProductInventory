using System;
using System.Collections.Generic;


namespace ProductInventory
{
    class Inventory
    {
        public int ID { get; set; }

        public double TotalCost { get; set; }

        List<Product> ProductList = new List<Product>();
        
        public void addProduct(Product product)
        {
            TotalCost += product.getTotalCost();
            ProductList.Add(product);
        }

        public List<Product> getFullList()
        {
            return ProductList;

        }

        public void removeFromList(int position)
        {
            ProductList.RemoveAt(position);
        }

        public void printProductList()
        {
            Console.WriteLine(new string('=', 46));
            Console.WriteLine("|{0,5}| {1,9}|{2,9} |{3,15} |", "№","Number/ID","Amount","Price");
            Console.WriteLine(new string('=', 46));

            for(var i = 0; i < ProductList.Count; i++)
            {
                Console.WriteLine("|{0,5}|{1,9} |{2,9} |{3,15:c} |", i + 1, ProductList[i].Number, ProductList[i].Amount, ProductList[i].Price);
            }

            Console.WriteLine(new string('=', 46));
            Console.WriteLine("{0,23} {1,15:C}","Total Price: ", TotalCost);
        }






    }
}
