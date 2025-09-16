using cs_Ecommerce.ProductData;

namespace cs_Ecommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> inventory = new List<Product>();

            bool running = true;
            while (running)
            {
                Console.WriteLine("=== Ammo's WebShop (Admin Panel) ===");
                Console.WriteLine("[1] Add Product");
                Console.WriteLine("[2] List Products");
                Console.WriteLine("[3] Total Products");
                Console.WriteLine("[4] Total Amount");
                Console.WriteLine("[5] Change Global Discount");
                Console.WriteLine("[6] Quit Program");
                Console.WriteLine("====================================");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add Product");
                        break;
                    case 2:
                        Console.WriteLine("List product");
                        break;
                    case 3:
                        Console.WriteLine("Total Products");
                        break;
                    case 4:
                        Console.WriteLine("Total Amount");
                        break;
                    case 5:
                        Console.WriteLine("Change Global Discount");
                        break;
                    case 6:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

        }
    }
}
