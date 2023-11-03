using A.Data;
using Microsoft.AspNetCore.Mvc;

namespace MovieApp.ViewComponents
{
    public class CategoryMenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CategoryRepository.Categories);
        }

    }
}
