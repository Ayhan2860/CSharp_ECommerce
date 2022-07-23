using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
         List<Category> GetAll();
        Category GetByCategoryId(int categoryId);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}