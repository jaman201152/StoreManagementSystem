using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemUI.Model
{
   public class Item
    {
       public int Id { get; set; }
       public long CategoryId { get; set; }
       public long CompanyId { get; set; }

       public string Name { get; set; }
       public int ReorderLabel { get; set; }

    }
}
