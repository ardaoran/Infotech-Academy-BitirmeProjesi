using BitirmeProjesi.DAL.Entities;

namespace BitirmeProjesi.UI.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }

        public IEnumerable<Product> RelatedProducts { get; set; }
    }
}
