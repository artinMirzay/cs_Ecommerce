namespace cs_Ecommerce.ProductData
{
    public class Clothing : Product
    {
        public string Size;
        public override string ProductInformation()
        {
            return $"The clothing {Name} has the size {Size} and was made by {Brand}. Price is {Price}$";
        }
    }
}
