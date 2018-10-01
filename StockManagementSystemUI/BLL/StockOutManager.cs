using StockManagementSystemUI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemUI.BLL
{
  
   public class StockOutManager
    {
       StockOutRepository _stockOutRepository = new StockOutRepository();
        public bool SalesAdd(Model.StockOut stockOut)
        {
            bool isAdded = _stockOutRepository.SalesAdd(stockOut);
            return isAdded;
        }

        public bool DamageAdd(Model.StockOut stockOut)
        {
            bool isAdded = _stockOutRepository.DamageAdd(stockOut);
            return isAdded;
        }
        public bool LostAdd(Model.StockOut stockOut)
        {
            bool isAdded = _stockOutRepository.LostAdd(stockOut);
            return isAdded;
        }
        
    }
}
