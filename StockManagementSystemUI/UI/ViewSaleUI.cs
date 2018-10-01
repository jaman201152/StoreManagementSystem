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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

namespace StockManagementSystemUI.UI
{
    public partial class ViewSalesUI : Form
    {

        SqlConnection _con = new SqlConnection(Common.ConnectionString());
        public ViewSalesUI()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(fromDateTimePicker.Text);
            DateTime toDate = Convert.ToDateTime(toDateTimePicker.Text);
            int salesType = (int)StockOut.StockOutTypeEnum.Sales;
            string querySales = "SELECT  i.Name ItemName, SUM(st.StockOutQuantity) Quantity, st.StockOutType sttype from StockOut st "
                                        + "INNER JOIN Items i on st.ItemId=i.Id WHERE st.StockOutType='" + salesType + "' AND StockOutDate BETWEEN '"
                                        + fromDate + "' AND '" + toDate + "' GROUP BY i.Name,st.StockOutType ";
                              
            SqlCommand comm = new SqlCommand(querySales, _con);
            _con.Open();
            DataTable dtCat = new DataTable();
            SqlDataAdapter daCat = new SqlDataAdapter(comm);
            daCat.Fill(dtCat);
            ViewSalesBetweenDataGridView.DataSource = dtCat;
            ViewSalesBetweenDataGridView.Columns["sttype"].Visible = false;
            _con.Close();
        }

        private void ViewSalesBetweenDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.ViewSalesBetweenDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex+1).ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardFormUI dashboard = new DashboardFormUI();
            dashboard.ShowDialog();
        }

        private void ExportToPDFButton_Click(object sender, EventArgs e)
        {



        }
    }
}
