using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.DataAccess.Concretes;
using Task2.Entities;

namespace Task2.Business
{
    public class CategoryManager
    {
        public readonly CategoryDal _categoryDal;

        public CategoryManager(CategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            CategoryDal categoryDal = new CategoryDal();

            return categoryDal.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            CategoryDal categoryDal = new CategoryDal();

            return categoryDal.GetCategoryById(id);
        }

        public void Add(Category category)
        {
            CategoryDal categoryDal = new CategoryDal();

            categoryDal.Add(category);
        }
        public void Delete(int id)
        {
            CategoryDal categoryDal = new CategoryDal();

            categoryDal.Delete(id);
        }
        
        public void Update(Category category)
        {
            CategoryDal categoryDal=new CategoryDal();

            categoryDal.Update(category);
        }
    }
}
