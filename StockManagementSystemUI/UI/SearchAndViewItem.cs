using StockManagementSystemUI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemUI.UI
{
    public partial class SearchAndViewItem : Form
    {

        SqlConnection _con = new SqlConnection(Common.ConnectionString());
        public SearchAndViewItem()
        {
            InitializeComponent();
        }

        private void SearchAndViewItem_Load(object sender, EventArgs e)
        {
            // For Company Name Combo Box
            string query = "SELECT * FROM Companies";
            SqlCommand command = new SqlCommand(query, _con);
            _con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            companyBindingSource.DataSource = dt;
            _con.Close();
        
        }

        ErrorProvider ep = new ErrorProvider();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            int er = 0;
            ep.Clear();
            if (categoryComboBox.Text == "")
            {
                er++;
                ep.SetError(categoryComboBox, "Required");
            }
            if (companyComboBox.Text == "")
            {
                er++;
                ep.SetError(companyComboBox, "Required");
            }
           
            if (er > 0)
            {
                return;
            }

            long comId = Convert.ToInt64(companyComboBox.SelectedValue);
            long catId = Convert.ToInt64(categoryComboBox.SelectedValue);

            string queryCat = "SELECT i.Name ItemName,comp.Name CompanyName,cat.Name CategoryName,"
                +" iabl.AvailableQuantity AvailableQuantity,i.ReorderLabel ReorderLabel FROM Items i "
            +" INNER jOIN ItemAvailableQuantity iabl on i.Id=iabl.ItemId "
            +" INNER jOIN Companies comp on i.CompanyId=comp.Id "
            +" INNER jOIN Categories cat on i.CategoryId=cat.Id "
            + " WHERE comp.Id='" + comId + "' and cat.Id='" + catId + "'";
            SqlCommand comm = new SqlCommand(queryCat, _con);
            _con.Open();
            DataTable dtCat = new DataTable();
            SqlDataAdapter daCat = new SqlDataAdapter(comm);
            daCat.Fill(dtCat);
            ItemDataGridView.DataSource = dtCat;
            _con.Close();


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardFormUI dashboard = new DashboardFormUI();
            dashboard.ShowDialog();
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            long comId = Convert.ToInt64(companyComboBox.SelectedValue);

            string query = "SELECT DISTINCT c.Name,c.Id FROM Items i INNER JOIN Categories c ON i.CategoryId=c.Id WHERE i.CompanyId='" + comId + "' ";
            SqlCommand command = new SqlCommand(query, _con);
            _con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            categoryBindingSource.DataSource = dt;
            _con.Close();
        }

        private void ItemDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.ItemDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ep.SetError(categoryComboBox, "");
        }
    }
}
