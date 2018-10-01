using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemUI.Model
{
   public class StockOutVM
    {
       public string ItemName { get; set; }
       public string CompanyName { get; set; }
       public string CategoryName { get; set; }
       public int StockOutQuantity { get; set; }

    }
}
