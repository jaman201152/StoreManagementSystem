using StockManagementSystemUI.Category.BLL;
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
using StockManagementSystemUI.Model;

namespace StockManagementSystemUI.Category.UI
{
    public partial class CetegoryFormUi : Form
    {
        CategoryManager _CategoryManager = new CategoryManager();

        public CetegoryFormUi()
        {
            InitializeComponent() ;
             CategoryLode();
        }
        private void CategoryLode()
        {
            DataTable getTable = _CategoryManager.CategoryLode(_CategoryManager);
             categoryBindingSource.DataSource = getTable;
            categoryDataGridView1.DataSource = categoryBindingSource;


        }
        ErrorProvider ep = new ErrorProvider();
        SqlConnection _con = new SqlConnection(Model.Common.ConnectionString());
        private void SaveButton_Click(object sender, EventArgs e)
        {
            int er = 0;
            ep.Clear();
            if (nameTextBox.Text == "")
            {
                er++;
                ep.SetError(nameTextBox, "Required");
            }

            if (er > 0)
            {
                return;
            }

            Model.Category _category = new Model.Category();
            _category.Name = nameTextBox.Text;
            if (hiddenIdTextBox.Text != "")
            {
                _category.Id = Convert.ToInt64(hiddenIdTextBox.Text);
            }
           
            string checkOrUpdate = SaveButton.Text;

            if (checkOrUpdate == "Save")
            {
                string QueryDuplicate = @"SELECT COUNT(*) FROM Categories where Name='" + _category.Name + "' ";

                SqlCommand commandDuplicateCheck = new SqlCommand(QueryDuplicate, _con);
                DataTable ds = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(commandDuplicateCheck);
                da.Fill(ds);
                if (ds.Rows[0][0].ToString() == "1")
                {
                    string msg = "Duplicate Entry not Allowed.";
                    MessageBox.Show(msg);
                }
                else
                {
                    bool isAdded = _CategoryManager.Add(category: _category);
                    if (isAdded)
                    {
                        MessageBox.Show("Successfuly Saved.");
                        nameTextBox.Clear();
                        CategoryLode();
                        return;
                    }
                    MessageBox.Show("Sorry! failed.");
                }
            
            }
           if(checkOrUpdate=="Update")
            {
                bool isUpdated = _CategoryManager.Update(category: _category);
                if (isUpdated)
                {
                    MessageBox.Show("Saved Changed Successfully!");
                    nameTextBox.Clear();
                    hiddenIdTextBox.Clear();
                    CategoryLode();
                    SaveButton.Text = "Save";
                    return;
                }
            }

            



        }

     

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardFormUI dashboard = new DashboardFormUI();
            dashboard.ShowDialog();
        }

        private void categoryDataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.categoryDataGridView1.Rows[e.RowIndex].Cells["SL"].Value=(e.RowIndex+1).ToString();
        }

        private void categoryDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string catName = this.categoryDataGridView1.CurrentRow.Cells[1].Value.ToString();
            nameTextBox.Text = catName;

            string query = @"SELECT * FROM Categories WHERE Name ='"+catName+"' ";
            SqlCommand command = new SqlCommand(query, _con);
            _con.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
               hiddenIdTextBox.Text = dr["Id"].ToString();
            }
            _con.Close();
            SaveButton.Text = "Update";
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if (nameTextBox.Text=="")
            {
                SaveButton.Text = "Save";
            }
        }

        private void searchDataGridViewTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchDataGridViewTextBox.Text != "")
            {
                
                string name = searchDataGridViewTextBox.Text;
                DataTable getTable = _CategoryManager.SearchDataGrid(name);

                categoryDataGridView1.DataSource = getTable;

            }
            else
            {
                CategoryLode();
            }
        }
    }
}
