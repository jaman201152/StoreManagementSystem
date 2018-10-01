namespace StockManagementSystemUI.UI
{
    partial class ViewSalesUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewSalesBetweenDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSalesBetweenDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "To Date";
            // 
            // ViewSalesBetweenDataGridView
            // 
            this.ViewSalesBetweenDataGridView.AllowUserToAddRows = false;
            this.ViewSalesBetweenDataGridView.AllowUserToDeleteRows = false;
            this.ViewSalesBetweenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewSalesBetweenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewSalesBetweenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.Name,
            this.SalesQuantity});
            this.ViewSalesBetweenDataGridView.Location = new System.Drawing.Point(6, 23);
            this.ViewSalesBetweenDataGridView.Name = "ViewSalesBetweenDataGridView";
            this.ViewSalesBetweenDataGridView.ReadOnly = true;
            this.ViewSalesBetweenDataGridView.Size = new System.Drawing.Size(716, 178);
            this.ViewSalesBetweenDataGridView.TabIndex = 4;
            this.ViewSalesBetweenDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.ViewSalesBetweenDataGridView_RowPostPaint);
            // 
            // SL
            // 
            this.SL.FillWeight = 45.68528F;
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "ItemName";
            this.Name.FillWeight = 127.1574F;
            this.Name.HeaderText = "Item";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // SalesQuantity
            // 
            this.SalesQuantity.DataPropertyName = "Quantity";
            this.SalesQuantity.FillWeight = 127.1574F;
            this.SalesQuantity.HeaderText = "Sales Quantity";
            this.SalesQuantity.Name = "SalesQuantity";
            this.SalesQuantity.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.toDateTimePicker);
            this.groupBox1.Controls.Add(this.fromDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(140, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Sales Between To Dates";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(300, 140);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 32);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(193, 140);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(89, 32);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(193, 87);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.toDateTimePicker.TabIndex = 4;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(193, 46);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.fromDateTimePicker.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ViewSalesBetweenDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 223);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sales Report";
            // 
            // ViewSalesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
     //       this.Name = "ViewSalesUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Sales Between To Dates";
            ((System.ComponentModel.ISupportInitialize)(this.ViewSalesBetweenDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ViewSalesBetweenDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesQuantity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CancelButton;

    }
}