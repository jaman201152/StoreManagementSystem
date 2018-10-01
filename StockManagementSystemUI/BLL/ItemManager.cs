using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemUI.DAL;

namespace StockManagementSystemUI.BLL
{
   public class ItemManager
    {
       ItemRepository itemRepository = new ItemRepository();

       public bool Add(Model.Item item)
       {
          bool isAdded =  itemRepository.Add(item);
          return isAdded;
       }
             
    }
}
