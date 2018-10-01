using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemUI.Model
{
   public class StockOut
    {

        public long Id { get; set; }
        public long CategoryId { get; set; }
        public long CompanyId { get; set; }
        public long ItemId { get; set; }
        public int StockOutQuantity { get; set; }
        public DateTime StockOutDate { get; set; }
        public int StockOutType { get; set; }
       
      

    public  enum StockOutTypeEnum{
          Sales=1,
          Damage=2,
          Lost=3
       }
    }
}
