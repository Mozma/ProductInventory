using System;


namespace ProductInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            welcomCommand();
           
            var tmp = Console.ReadLine();
            while (tmp != "q")
            {
                bool f1 = true;
                switch (tmp.ToLower())
                {
                    case "show":
                        inventory.printProductList();
                        break;

                    case "help":
                        printCommand();
                        break;

                    case "gen":
                        genCommand(inventory);
                        break;

                    case "del":
                        deleteCommand(inventory);
                        break;

                    case "clear":
                        Console.Clear();
                        welcomCommand();
                        break;

                    default:
                        Console.WriteLine("Command not found. Type \"help\" for more info.");
                        break;
                }
                tmp = Console.ReadLine();
            }
        }

        private static void deleteCommand(Inventory inventory)
        {
            Console.WriteLine("Enter № of product:");

            int num = 0;
            while (!Int32.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("That's not a number! Try again: ");
            }

            inventory.removeFromList(num - 1);

            Console.WriteLine($"Product {num} removed.");
        }

        public static void genCommand(Inventory inv)
        {
            Console.WriteLine("How much?");

            int length = 0;
            while (!Int32.TryParse(Console.ReadLine(), out length))
            {
                Console.Write("That's not a number! Try again: ");
            }
            Console.WriteLine($"Genegated {length} products.");

            for (var i = 0; i < length; i++)
            {
                inv.addProduct(new Product());
            }
        }

        public static void welcomCommand()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("        ProductInventory");
            Console.WriteLine(new string('-', 30));
            printCommand();
        }
        
        public static void printCommand()
        {
            Console.WriteLine("{0,10} - Print all commands.", "help");
            Console.WriteLine("{0,10} - Show Inventory list.", "show");
            Console.WriteLine("{0,10} - Generate some products.", "gen");
            Console.WriteLine("{0,10} - Clear screen.", "clear");
            Console.WriteLine("{0,10} - Delete product from Inventory.", "del");
        }







    }
}
