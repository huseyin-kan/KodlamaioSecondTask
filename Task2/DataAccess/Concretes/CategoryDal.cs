using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.DataAccess.Abstracts;
using Task2.Entities;

namespace Task2.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;
        public CategoryDal() 
        {
            Category category1 = new Category();
            category1.Id = 1;
            category1.Name = "Frontend";
            Category category2 = new Category();
            category2.Id = 2;
            category2.Name = "Backend";
            Category category3 = new Category();
            category3.Id = 3;
            category3.Name = "Data";
            categories = new List<Category> { category1,category2,category3};
        }
        public void Add(Category category)
        {
            categories.Add(category);
            categories.ForEach(c=>Console.WriteLine(c.Name));
        }

        public void Delete(int id)
        {
            Category removedCategory = categories.Find(c =>c.Id == id);
            if (removedCategory != null)
            {
                categories.Remove(removedCategory);
                categories.ForEach(c => Console.WriteLine(c.Name));
            }
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            Category category = categories.Find(c =>  c.Id == id);
            if(category == null)
            {
                return null;
            }
            return category;
        }

        public void Update(Category category)
        {
            if(categories.Exists(c => c.Id == category.Id))
            {
                int index = categories.FindIndex(c => c.Id == category.Id);
                categories[index] = category;
                categories.ForEach(c => Console.WriteLine(c.Name));
            }else
            {
                Console.WriteLine("Böyle bir kategori yok");
            }
        }
    }
}
