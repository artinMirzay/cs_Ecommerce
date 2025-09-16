namespace cs_Ecommerce.ProductData
{
    public class Product
    {
        //Class Variables
        public static double GlobalDiscount = 0.0;
        public static int NextID = 1;
        public static int TotalCount = 0;

        //Object Variables
        public int Id;
        public string Name;
        public string Brand;
        public double Price;

        //Constructor
        public Product()
        {
            Id = NextID;
            NextID++;
            TotalCount++;
        }

        public virtual string ProductInformation()
        {
            return $"Name: {Name} | Brand: {Brand} | Price: {Price}";
        }

        public virtual string ProductDetails()
        {
            return $"[{Id}] Name: {Name} | Brand: {Brand} | Price: {Price}";
        }
    }
}
