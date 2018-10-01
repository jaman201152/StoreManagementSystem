using StockManagementSystemUI.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemUI.DAL
{
   public class StockOutRepository
    {
       SqlConnection _con = new SqlConnection(Common.ConnectionString());

       public bool SalesAdd(Model.StockOut stockOut)
       {


           string query = @"INSERT INTO StockOut VALUES('" + stockOut.CompanyId + "','"
                               + stockOut.CategoryId + "','" + stockOut.ItemId + "','"
                               + stockOut.StockOutQuantity + "','"+stockOut.StockOutDate+"','"
                               +stockOut.StockOutType+"')";

           SqlCommand command = new SqlCommand(query, _con);
           _con.Open();

           bool isRowAffectred = command.ExecuteNonQuery() > 0;

           _con.Close();
           /// *************************** //
 

               // Show Item Available Quantity
               string queryItemAvailable = "SELECT * FROM ItemAvailableQuantity WHERE ItemId='" + stockOut.ItemId + "'";
               SqlCommand command_available = new SqlCommand(queryItemAvailable, _con);
               _con.Open();
               SqlDataReader drAvailable = command_available.ExecuteReader();
               if (drAvailable.Read())
               {
                   // student.Name = dr.GetValue(2).ToString();
                   int stockInAvailableQty = Convert.ToInt32(drAvailable["AvailableQuantity"]);
                  int  UpdateStockOutQuantity = stockInAvailableQty - stockOut.StockOutQuantity;

                   _con.Close();
                   // ****************** 
                   string query_update = @"UPDATE ItemAvailableQuantity SET AvailableQuantity='" + UpdateStockOutQuantity + "' WHERE ItemId='" + stockOut.ItemId + "' ";

                   SqlCommand command_update = new SqlCommand(query_update, _con);
                   _con.Open();

                   bool isRowAffectred1 = command_update.ExecuteNonQuery() > 0;

                   _con.Close();

                   // ************************ //
               }
               _con.Close();
           
     

           return isRowAffectred;
       }

       public bool DamageAdd(Model.StockOut stockOut)
       {

           string query = @"INSERT INTO StockOut VALUES('" + stockOut.CompanyId + "','"
                               + stockOut.CategoryId + "','" + stockOut.ItemId + "','"
                               + stockOut.StockOutQuantity + "','" + stockOut.StockOutDate 
                               + "','" + stockOut.StockOutType + "')";

           SqlCommand command = new SqlCommand(query, _con);
           _con.Open();

           bool isRowAffectred = command.ExecuteNonQuery() > 0;

           _con.Close();
           /// *************************** ///


           // Show Item Available Quantity
           string queryItemAvailable = "SELECT * FROM ItemAvailableQuantity WHERE ItemId='" + stockOut.ItemId + "'";
           SqlCommand command_available = new SqlCommand(queryItemAvailable, _con);
           _con.Open();
           SqlDataReader drAvailable = command_available.ExecuteReader();
           if (drAvailable.Read())
           {
               // student.Name = dr.GetValue(2).ToString();
               int stockInAvailableQty = Convert.ToInt32(drAvailable["AvailableQuantity"]);
               stockOut.StockOutQuantity = stockInAvailableQty - stockOut.StockOutQuantity;
           }
           _con.Close();
           // ****************** 
           string query_update = @"UPDATE ItemAvailableQuantity SET AvailableQuantity='" + stockOut.StockOutQuantity + "' WHERE ItemId='" + stockOut.ItemId + "' ";

           SqlCommand command_update = new SqlCommand(query_update, _con);
           _con.Open();

           bool isRowAffectred1 = command_update.ExecuteNonQuery() > 0;

           _con.Close();

           // ************************ //


           return isRowAffectred;
       }

       public bool LostAdd(Model.StockOut stockOut)
       {

           string query = @"INSERT INTO StockOut VALUES('" + stockOut.CompanyId + "','"
                               + stockOut.CategoryId + "','" + stockOut.ItemId + "','"
                               + stockOut.StockOutQuantity + "','" + stockOut.StockOutDate + "','" + stockOut.StockOutType + "')";

           SqlCommand command = new SqlCommand(query, _con);
           _con.Open();

           bool isRowAffectred = command.ExecuteNonQuery() > 0;

           _con.Close();
           /// *************************** //



           // Show Item Available Quantity
           string queryItemAvailable = "SELECT * FROM ItemAvailableQuantity WHERE ItemId='" + stockOut.ItemId + "'";
           SqlCommand command_available = new SqlCommand(queryItemAvailable, _con);
           _con.Open();
           SqlDataReader drAvailable = command_available.ExecuteReader();
           if (drAvailable.Read())
           {
               // student.Name = dr.GetValue(2).ToString();
               int stockInAvailableQty = Convert.ToInt32(drAvailable["AvailableQuantity"]);
               stockOut.StockOutQuantity = stockInAvailableQty - stockOut.StockOutQuantity;
           }
           _con.Close();
           // ****************** 
           string query_update = @"UPDATE ItemAvailableQuantity SET AvailableQuantity='" + stockOut.StockOutQuantity + "' WHERE ItemId='" + stockOut.ItemId + "' ";
           
           SqlCommand command_update = new SqlCommand(query_update, _con);
           _con.Open();

           bool isRowAffectred1 = command_update.ExecuteNonQuery() > 0;

           _con.Close();

           // ************************ //


           return isRowAffectred;
       }


    }
}
