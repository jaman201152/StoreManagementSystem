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
using StockManagementSystemUI.UI;
using StockManagementSystemUI.BLL;

namespace StockManagementSystemUI.StokOut.UI
{
    public partial class StockOutUi : Form
    {

        SqlConnection _con = new SqlConnection(Common.ConnectionString());

        public StockOutUi()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardFormUI dashboard = new DashboardFormUI();
            dashboard.ShowDialog();
        }

        private void StockOutUi_Load(object sender, EventArgs e)
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
      

      
       
        List<StockOutVM> stockOutdisplayList = new List<StockOutVM>();
       
        List<StockOut> stockOutAddList = new List<StockOut>();
        StockOut _stockAdd = null;
        ErrorProvider ep = new ErrorProvider();
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
            
            if (er > 0)
            {
                return;
            }

            _stockAdd = new StockOut();
          
            StockOutVM stockOutVm = new StockOutVM();
            if (stockOutQuantityTextBox.Text.Length < 1)
            {
                MessageBox.Show("Enter StockOut Quantity.");
                return;
            }
            // For List Class 
        
            // For Add Class
            _stockAdd.CompanyId = Convert.ToInt64(companyComboBox.SelectedValue);
            _stockAdd.CategoryId = Convert.ToInt64(categoryComboBox.SelectedValue);
            _stockAdd.ItemId = Convert.ToInt64(itemComboBox.SelectedValue);
            _stockAdd.StockOutQuantity = Convert.ToInt32(stockOutQuantityTextBox.Text);
                        DateTime date =  DateTime.Now; // Getting System Date
            _stockAdd.StockOutDate = Convert.ToDateTime(date);
            
            // End For Add Class

            // ***************** List For display Class ***************
            stockOutVm.ItemName = itemComboBox.Text;
            stockOutVm.CompanyName = companyComboBox.Text;
            stockOutVm.CategoryName = categoryComboBox.Text;
            stockOutVm.StockOutQuantity = Convert.ToInt32(stockOutQuantityTextBox.Text);
            // ***************** For display Class ***************

            stockOutAddList.Add(_stockAdd); // Object for Insert in List
           

            stockOutdisplayList.Add(stockOutVm); // Object for Display in List

            itemStockOutDataGridView.DataSource = null;
            itemStockOutDataGridView.DataSource = stockOutdisplayList;
           // itemStockOutDataGridView.Columns["CampanyId"].Visible = false;
           // itemStockOutDataGridView.Columns["CategoryId"].Visible = false;
            stockOutQuantityTextBox.Clear();

            // This is for show availabe item Qty will be deducted.
            int avQty = Convert.ToInt32(availableQuantityLabel.Text);
            int stQty = Convert.ToInt32(stockOutVm.StockOutQuantity);
            availableQuantityLabel.Text = Convert.ToString(avQty - stQty);
            // End This is for show availabe item Qty will be deducted.
        }
        StockOutManager _stockOutManager = new StockOutManager();
      
        private void SellButton_Click(object sender, EventArgs e)
        {

            // ******* getting StockOutTye form Enum
            foreach (var stockOut in stockOutAddList)
            {
                stockOut.StockOutType = Convert.ToInt32(StockOut.StockOutTypeEnum.Sales);
            }                       
            
            // ******* getting StockOutTye form Enum

                bool msg = true;
                foreach (StockOut st in stockOutAddList)     // StockOutList Looping here
                {
                    bool isAdded = _stockOutManager.SalesAdd(st);

                    if (isAdded)
                    {

                        if (msg)
                        {
                            MessageBox.Show("Successfully Executed for Sells  ");
                            msg = false;
                        }

                    }
                    else
                    {

                        if (msg)
                        {
                            MessageBox.Show("Sorry! Executed failed");
                            msg = false;
                        }

                    }
            }  // List Loop End
             stockOutAddList.Clear();
             stockOutdisplayList.Clear();
             itemStockOutDataGridView.DataSource = null;
            


        }



        private void DamageButton_Click(object sender, EventArgs e)
        {

      
            // ******* getting StockOutTye form Enum
            foreach (var stockOut in stockOutAddList)
            {
                stockOut.StockOutType = Convert.ToInt32(StockOut.StockOutTypeEnum.Damage);
            }
        

            // ******* getting StockOutTye form Enum
            int listCount = stockOutAddList.Count;
            if (listCount != 0)
            {
                bool msg = true;
                foreach (StockOut st in stockOutAddList)     // StockOutList Looping here
                {
                    bool isAdded = _stockOutManager.DamageAdd(st);

                    if (isAdded)
                    {
                        if (msg)
                        {
                            MessageBox.Show("Successfully Executed for Damage");
                            msg = false;
                        }
                    }
                    else
                    {
                        if (msg)
                        {
                            MessageBox.Show("Sorry! Executed failed");
                            msg = false;
                        }

                    }
                }    // End loop of List here
                stockOutAddList.Clear();
                stockOutdisplayList.Clear();
                itemStockOutDataGridView.DataSource = null;

            }
            else
            {
                MessageBox.Show("Add atleast One Item.");    // If List is empty then show message
            }



        }

        private void LostButton_Click(object sender, EventArgs e)
        {
         
            // ******* getting StockOutTye form Enum
            foreach (var stockOut in stockOutAddList)
            {
                stockOut.StockOutType = Convert.ToInt32(StockOut.StockOutTypeEnum.Lost);
            }
            // ******* getting StockOutTye form Enum

            int listCount = stockOutAddList.Count;
            if (listCount != 0)
            {
                bool msg = true;
                foreach (StockOut st in stockOutAddList)   // StockOutList Looping here
                {
                    bool isAdded = _stockOutManager.LostAdd(st);

                    if (isAdded)
                    {

                        if (msg)
                        {
                            MessageBox.Show("Successfully Executed for Lost");
                            msg = false;

                        }

                    }
                    else
                    {
                        if (msg)
                        {
                            MessageBox.Show("Sorry! Executed failed");
                            msg = false;
                        }

                    }
                }
                stockOutAddList.Clear();
                stockOutdisplayList.Clear();
                itemStockOutDataGridView.DataSource = null;

            }
            else
            {
                MessageBox.Show("Add atleast One Item.");
            }



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

            string query = @"SELECT Id,Name FROM Items  WHERE CategoryId='" + catId + "' and CompanyId='" + comId + "' ";
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

            if (reOrderLabel.Text != "" && availableQuantityLabel.Text != "")
            {
                int reOrderlabel = Convert.ToInt32(reOrderLabel.Text);
                int avqty = Convert.ToInt32(reOrderLabel.Text);
                if (reOrderlabel > avqty)
                {
                    reOrderAvailableQtyMsgLabel.Text = "Stock is out of range.";
                }
            }


        }

        private void stockOutQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (stockOutQuantityTextBox.Text != "")
            {
                int stockOutQty = Convert.ToInt32(stockOutQuantityTextBox.Text);
                int avqty = Convert.ToInt32(availableQuantityLabel.Text);

                if (stockOutQty > avqty)
                {
                    msgLabel.Text = "Stock Item is not available";
                    stockOutQuantityTextBox.Text = String.Empty;

                }
                else
                {
                    msgLabel.Text = "";
                }
            }
    
        }

        

        private void itemStockOutDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.itemStockOutDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
        }

  
    }
}
