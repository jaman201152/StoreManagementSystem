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
using StockManagementSystemUI.BLL;
using StockManagementSystemUI.Model;

namespace StockManagementSystemUI.StockIn.UI
{
    public partial class StockInUi : Form
    {

        SqlConnection _con = new SqlConnection(Common.ConnectionString());
        public StockInUi()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardFormUI dashboard = new DashboardFormUI();
            dashboard.ShowDialog();

        }

        private void StockInUi_Load(object sender, EventArgs e)
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

         

           stockInItemDataGridView.DataSource = _stockInManager.StockInLoad(); // Load new StockIn Item

        }
        ErrorProvider ep = new ErrorProvider();
        StockInManager _stockInManager = new StockInManager();
        private void SaveButton_Click(object sender, EventArgs e)
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
            if (itemComboBox.Text == "")
            {
                er++;
                ep.SetError(itemComboBox, "Required");
            }
            if (stokInTextBox.Text == "")
            {
                er++;
                ep.SetError(stokInTextBox, "Required");
            }
            if (er > 0)
            {
                return;
            }

            Model.StockIn stockIn = new Model.StockIn();

            stockIn.CompanyId = Convert.ToInt64(companyComboBox.SelectedValue);
          
             stockIn.CategoryId = Convert.ToInt64(categoryComboBox.SelectedValue);
            stockIn.ItemId = Convert.ToInt64(itemComboBox.SelectedValue);
            stockIn.AvailableQuantity = Convert.ToInt32(stokInTextBox.Text);
           bool isAdded = _stockInManager.Add(stockIn);

           if (isAdded)
           {
               MessageBox.Show("Successfully Added. ");
               stokInTextBox.Clear();
           }
           else
           {
               MessageBox.Show("Sry! Added Failed.");
           }

           stockInItemDataGridView.DataSource = _stockInManager.StockInLoad(); // Load new StockIn Item


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

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ep.SetError(categoryComboBox, "");


            long catId = Convert.ToInt64(categoryComboBox.SelectedValue);
           
            long comId = Convert.ToInt64(companyComboBox.SelectedValue);

            string query = @"SELECT Id,Name FROM Items  WHERE CategoryId='" + catId + "' and CompanyId='"+comId+"' ";
            SqlCommand command = new SqlCommand(query, _con);
            _con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            itemBindingSource.DataSource = dt;
            _con.Close();
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ep.SetError(itemComboBox, "");
            long itemId = Convert.ToInt64(itemComboBox.SelectedValue);
        
            // Show Reorder label
            string query = "SELECT * FROM Items WHERE Id='" + itemId + "'";
            SqlCommand command = new SqlCommand(query, _con);
            _con.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
               // student.Name = dr.GetValue(2).ToString();
               reOrderLabel.Text = dr["ReorderLabel"].ToString();
            }

            _con.Close();

            // Show Item Available Quantity
            string queryItemAvailable = "SELECT * FROM ItemAvailableQuantity WHERE ItemId='" + itemId + "'";
            SqlCommand command_available = new SqlCommand(queryItemAvailable, _con);
            _con.Open();
            SqlDataReader drAvailable = command_available.ExecuteReader();
            if (drAvailable.Read())
            {
                // student.Name = dr.GetValue(2).ToString();
                availableQuantityLabel.Text = drAvailable["AvailableQuantity"].ToString();
            }
            else
            {
                availableQuantityLabel.Text = "0".ToString();
            }
            _con.Close();

        }

        private void stockInItemDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.stockInItemDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }

        private void stokInTextBox_TextChanged(object sender, EventArgs e)
        {
            ep.SetError(stokInTextBox, "");
        }

        private void stokInTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string item = stokInTextBox.Text;

            foreach (char c in item)
            {
                if (char.IsDigit(c) == false)
                {
                    stockInQuantitylevel.Text = "ERROR";
                }
                else
                {
                    stockInQuantitylevel.Text = "";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
