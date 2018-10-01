using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemUI.Model;
using System.Data;

namespace StockManagementSystemUI.DAL
{
   public class StockInRepository
    {
       SqlConnection _con = new SqlConnection(Common.ConnectionString());
       public bool Add(Model.StockIn stockIn)
       {


          bool _isRowAffected = false;

           string query_check_item = @"SELECT COUNT(*) FROM StockIn WHERE ItemId='" + stockIn.ItemId + "' and CompanyId='"+stockIn.CompanyId+"' ";

           SqlCommand command_check_item = new SqlCommand(query_check_item, _con);
           _con.Open();
           SqlDataAdapter dr = new SqlDataAdapter(command_check_item);
           DataTable dt = new DataTable();
           _con.Close();
           dr.Fill(dt);
           if (Convert.ToInt32(dt.Rows[0][0]) == 1)
           {
               // ************************

           

               // Show Item Available Quantity
               string queryItemAvailable = "SELECT * FROM ItemAvailableQuantity WHERE ItemId='" + stockIn.ItemId + "'";
               SqlCommand command_available = new SqlCommand(queryItemAvailable, _con);
               _con.Open();
               SqlDataReader drAvailable = command_available.ExecuteReader();
               if (drAvailable.Read())
               {
                   // student.Name = dr.GetValue(2).ToString();
                 int  stockInUpdate = Convert.ToInt32(drAvailable["AvailableQuantity"]);
                 stockIn.AvailableQuantity = stockInUpdate + stockIn.AvailableQuantity;
               }
               _con.Close();
               // ****************** 
               string query_update = @"UPDATE ItemAvailableQuantity SET AvailableQuantity='" + stockIn.AvailableQuantity + "' WHERE ItemId='" + stockIn.ItemId + "' ";

               SqlCommand command_update = new SqlCommand(query_update, _con);
               _con.Open();

               _isRowAffected = command_update.ExecuteNonQuery() > 0;

               _con.Close();

               // ************************ //
           }
           else
           {
               // ************************
               string query = @"INSERT INTO StockIn VALUES('" + stockIn.CompanyId + "','"
                                   + stockIn.CategoryId + "','" + stockIn.ItemId + "','"
                                   + stockIn.AvailableQuantity + "')";

               SqlCommand command = new SqlCommand(query, _con);
               _con.Open();

                _isRowAffected = command.ExecuteNonQuery() > 0;

               _con.Close();
               /// *************************** //
               ///  
               // ************************
             
               string query1 = @"INSERT INTO ItemAvailableQuantity VALUES('" + stockIn.ItemId + "','"
                                  + stockIn.AvailableQuantity + "')";

               SqlCommand command1 = new SqlCommand(query1, _con);
               _con.Open();

               _isRowAffected = command1.ExecuteNonQuery() > 0;

               _con.Close();

               // ************************ //
           }


           return _isRowAffected;
       }


       public DataTable StockInLoad()
       {

           string queryCat = "SELECT TOP 100 i.Name ItemName,comp.Name CompanyName,cat.Name CategoryName,"
               + " iabl.AvailableQuantity AvailableQuantity,i.ReorderLabel ReorderLabel FROM Items i "
           + " INNER jOIN ItemAvailableQuantity iabl on i.Id=iabl.ItemId "
           + " INNER jOIN Companies comp on i.CompanyId=comp.Id "
           + " INNER jOIN Categories cat on i.CategoryId=cat.Id  ORDER BY i.Id DESC ";
           SqlCommand comm = new SqlCommand(queryCat, _con);
           _con.Open();
           DataTable dtCat = new DataTable();
           SqlDataAdapter daCat = new SqlDataAdapter(comm);
           daCat.Fill(dtCat);
           _con.Close();

           return dtCat;
       }

    }
}
