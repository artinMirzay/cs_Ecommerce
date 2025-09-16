namespace cs_Ecommerce.ProductData
{
    public class Book : Product
    {
        public string Author;

        public override string ProductInformation()
        {
            return $"The book {Name} was written by {Author} and published by {Brand}. Price is {Price}$";
        }
    }

}
