using System;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcWebUI.Models;

namespace MvcWebUI.ViewsComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            var categories = _categoryService.GetAll();
            CategoryListViewModel model = new CategoryListViewModel
            {
                Categories = categories,
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["category"])
            };
             return View(model);
        }
    }
}