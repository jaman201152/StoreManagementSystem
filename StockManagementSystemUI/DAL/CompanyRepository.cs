using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemUI.Company.BLL;
using StockManagementSystemUI.Model;

namespace StockManagementSystemUI.Company.DAL
{
    public class CompanyRepository
    {

        SqlConnection _con = new SqlConnection(Common.ConnectionString());
        public bool Add(Model.Company company)
        {

            string query = @"INSERT INTO Companies VALUES('" + company.Name + "')";

            SqlCommand command = new SqlCommand(query, _con);
            _con.Open();

            bool isRowAffectred = command.ExecuteNonQuery() > 0;

            _con.Close();

            return isRowAffectred;
        }

        internal DataTable CategoryLode(CompanyManager companyManager)
        {
            string query = "SELECT * FROM Companies ORDER BY Id  DESC";
            SqlCommand com = new SqlCommand(query, _con);
            _con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            _con.Close();
            return dt;
        }

      
   
          
            
     

        //internal bool Add(Model.Company company)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
