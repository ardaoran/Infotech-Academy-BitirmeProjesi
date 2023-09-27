namespace BitirmeProjesi.UI.Models
{
    public class Cart
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductPicture { get; set; }
        public decimal ProductPrice { get; set; }
        public string FiyatFormatted
        {
            get
            {
               
                string formattedFiyat = ProductPrice.ToString("N0");

                formattedFiyat += " ₺";

                return formattedFiyat;
            }
        }
        public int Quantity { get; set; }
    }
}
