using StockManagementSystemUI.Category.UI;
using StockManagementSystemUI.Company.UI;
using StockManagementSystemUI.Item.UI;
using StockManagementSystemUI.StockIn.UI;
using StockManagementSystemUI.StokOut.UI;
using StockManagementSystemUI.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemUI
{
    public partial class DashboardFormUI : Form
    {
        public DashboardFormUI()
        {
            InitializeComponent();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CetegoryFormUi category = new CetegoryFormUi();
            category.ShowDialog();
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompanyUi item = new CompanyUi();
            item.ShowDialog();
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemFormUi item = new ItemFormUi();
            item.ShowDialog();

        }

        private void StokInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockInUi stockIn = new StockInUi();
            stockIn.ShowDialog();

        }

        private void StokOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockOutUi stockOut = new StockOutUi();
            stockOut.ShowDialog();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchAndViewItem searchItem = new SearchAndViewItem();
            searchItem.ShowDialog();


        }

        private void ViewSalesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSalesUI viewSales = new ViewSalesUI();
            viewSales.ShowDialog();
        }

    
    }
}
