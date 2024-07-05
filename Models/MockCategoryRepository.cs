
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List <Category>
        {
            new Category{CategoryId=1 , CategoryName= "Fruit Pies" , Description="all-Fruity pies" } ,
            new Category{CategoryId=2 , CategoryName= "cheese Cakes" , Description="Chessy all the way" },
            new Category{CategoryId=3 , CategoryName= "Seasonal Pies" , Description="Get in the moof for" }
        };

        IEnumerable<Category> ICategoryRepository.AllCategories()
        {
            throw new NotImplementedException();
        }
    }
}
