using StockManagementSystemUI.Category.DAL;
using StockManagementSystemUI.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemUI.Category.BLL
{
    public class CategoryManager
    {
        CategoryRepository _CategoryRepository = new CategoryRepository();
        
        public bool Add(Model.Category category)
        {
            bool isAdded = _CategoryRepository.Add(category);
            return isAdded;

        }

        public bool Update(Model.Category category)
        {
            bool isUpdated = _CategoryRepository.Update(category);
            return isUpdated;
        }
      
        public DataTable CategoryLode(CategoryManager categoryManager)
        {
            return _CategoryRepository.CategoryLode(categoryManager);
        }
        public DataTable SearchDataGrid(string name)
        {
            return _CategoryRepository.SearchDataGridView(name);
        }
    }
}
