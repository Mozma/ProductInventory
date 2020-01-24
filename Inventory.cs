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

        public void printProductList()
        {
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("| {0,9}|{1,9} |{2,15} |","Number/ID","Amount","Price");
            Console.WriteLine(new string('=', 40));

            foreach (var product in ProductList)
            {
                Console.WriteLine("|{0,9} |{1,9} |{2,15:c} |", product.Number, product.Amount, product.Price);
            }
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("{0,23} {1,15:C}","Total Price: ", TotalCost);
        }



    }
}
