using BitirmeProjesi.DAL.Entities;
using BitirmeProjesi.BL.Repositories;
using Microsoft.AspNetCore.Mvc;
using BitirmeProjesi.UI.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BitirmeProjesi.UI.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Slide> repoSlide;
        IRepository<Product> repoProduct;
        public HomeController(IRepository<Slide> _repoSlide, IRepository<Product> _repoProduct)
        {
            repoSlide = _repoSlide;
            repoProduct = _repoProduct;

        }
        public IActionResult Index()
        {
            IndexVM indexVM = new IndexVM()
            {
                Slides=repoSlide.GetAll().OrderBy(x=>x.DisplayIndex),
                Products = repoProduct.GetAll().Include(x => x.ProductPictures).OrderByDescending(x => x.ID).Take(8)
            };
            return View(indexVM);
        }
    }
}
