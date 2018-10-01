using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemUI.DAL;
using System.Data;

namespace StockManagementSystemUI.BLL
{
    public class StockInManager
    {
       StockInRepository _stockInRepository = new StockInRepository();
        public bool Add(Model.StockIn stockIn)
        {
            bool isAdded = _stockInRepository.Add(stockIn);
            return isAdded;
        }

        public DataTable StockInLoad()
        {
          return  _stockInRepository.StockInLoad();
        }
        
    }
}
