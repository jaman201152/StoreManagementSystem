using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemUI.Model;

namespace StockManagementSystemUI.DAL
{
    public class ItemRepository
    {
        public bool Add(Model.Item item)
        {
            SqlConnection con = new SqlConnection(Common.ConnectionString());

            string query = @"INSERT INTO Items VALUES('" + item.CategoryId + "','" 
                                + item.CompanyId + "','" + item.Name + "','" 
                                + item.ReorderLabel + "')";

            SqlCommand command = new SqlCommand(query, con);
            con.Open();

            bool isRowAffectred = command.ExecuteNonQuery() > 0;

            con.Close();

            return isRowAffectred;
        }

    }
}
