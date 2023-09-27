using BitirmeProjesi.DAL.Entities;
using BitirmeProjesi.UI.Models;

namespace BitirmeProjesi.UI.ViewModels
{
    public class CheckOutVM
    {
        public Order Order { get; set; }
        public IEnumerable<Cart> Carts { get; set; }
    }
}
