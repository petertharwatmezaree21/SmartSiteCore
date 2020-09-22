using SmartSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartSite.ViewModels
{
    public class navbarVM
    {
        ApplicationDbContext Context;
        public navbarVM(ApplicationDbContext _Context)
        {
            Context = _Context;
        }

        public IEnumerable<Category> GetCategories() => Context.Category.ToList();

        public IEnumerable<ProductType> GetProductTypesForSpecificCategory(int categoryID) => Context.ProductType.Where(t=>t.CategoryID==categoryID);

        IEnumerable<News> selectedNews() => Context.News.OrderByDescending(n => n.Date);

        public IEnumerable<News> GetLastNews()
        {
            if(this.selectedNews().Count() > 2)
            {
                return this.selectedNews().Take(2);
            }
            else
            {
                return this.selectedNews();
            }
        }


    }
}