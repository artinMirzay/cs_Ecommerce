namespace cs_Ecommerce.ProductData
{
    public class Electronics : Product
    {
        public int WarrantyYears;

        public override string ProductInformation()
        {
            return $"The Electronic {Name} Has the warranty (years): {WarrantyYears}. Price is {Price}$";
        }
    }
}
