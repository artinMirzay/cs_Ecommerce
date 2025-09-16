using cs_Ecommerce.ProductData;

namespace cs_Ecommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> inventory = new List<Product>()
            {
                new Book {Name = "PotatoTech", Brand = "Potatoes united", Price = 99.99, Author = "Artin Mirzay"},
                new Clothing {Name = "Polo by polo", Brand = "Temu", Price = 59.99, Size = "L"},
                new Electronics {Name = "Iphone 12", Brand = "Apple", Price = 1299.99, WarrantyYears = 3 }
            };


            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Ammo's WebShop (Admin Panel) ===");
                Console.WriteLine("[1] Add Product");
                Console.WriteLine("[2] List Products");
                Console.WriteLine("[3] Total Products");
                Console.WriteLine("[4] Total Value");
                Console.WriteLine("[5] Change Global Discount");
                Console.WriteLine("[6] Quit Program");
                Console.WriteLine("====================================");
                Console.Write("Choice: ");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddProductMenu(inventory);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("=== Inventory List ===");
                        ListProducts(inventory);
                        Console.WriteLine("======================");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Total Products: " + Product.TotalCount);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($"The total value of your inventory is {CalculateTotalValue(inventory)}$");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
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

            static void AddProductMenu(List<Product> inventory)
            {
                Console.Clear();
                Console.WriteLine("=== Choose Category ===");
                Console.WriteLine("[1] Book");
                Console.WriteLine("[2] Electronics");
                Console.WriteLine("[3] Clothing");
                Console.WriteLine("=======================");
                Console.Write("Choice: ");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Book b = new Book();
                        FillCommonFields(b);
                        Console.Write("Author: ");
                        b.Author = Console.ReadLine();
                        inventory.Add(b);
                        CommonReadKey();
                        break;
                    case 2:
                        Electronics e = new Electronics();
                        FillCommonFields(e);
                        Console.Write("Warranty (years): ");
                        e.WarrantyYears = int.Parse(Console.ReadLine());
                        inventory.Add(e);
                        CommonReadKey();
                        break;
                    case 3:
                        Clothing c = new Clothing();
                        FillCommonFields(c);
                        Console.Write("Size: ");
                        c.Size = Console.ReadLine();
                        inventory.Add(c);
                        CommonReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        CommonReadKey();
                        break;

                }
            }

            static void FillCommonFields(Product p)
            {
                Console.Write("Name: ");
                p.Name = Console.ReadLine();
                Console.Write("Brand: ");
                p.Brand = Console.ReadLine();
                Console.Write("Price: ");
                p.Price = double.Parse(Console.ReadLine());
            }

            static void ListProducts(List<Product> products)
            {
                foreach (Product p in products)
                {
                    Console.WriteLine(p.ProductDetails());
                }
            }

            static double CalculateTotalValue(List<Product> products)
            {
                double sum = 0;
                foreach (Product p in products)
                {
                    sum += p.Price;
                }
                return sum;
            }

            static void CommonReadKey()
            {
                Console.Clear();
                Console.WriteLine("New Product added...");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }

        }
    }
}
