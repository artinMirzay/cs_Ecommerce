namespace cs_Ecommerce.ProductData
{
    public class Product
    {
        //Class Variables
        public static double GlobalDiscount = 0.0;
        public static int NextID = 1;
        private static int TotalCount = 0;

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


    }
}
