namespace StockManagementSystemUI.StockIn.UI
{
    partial class StockInUi
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
            this.components = new System.ComponentModel.Container();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reOrderLabel = new System.Windows.Forms.Label();
            this.availableQuantityLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stokInTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stockInQuantitylevel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stockInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockInItemDataGridView = new System.Windows.Forms.DataGridView();
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInItemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(217, 253);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(95, 31);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Reorder Label";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Available Quantity";
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companyBindingSource;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(217, 24);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(208, 26);
            this.companyComboBox.TabIndex = 13;
            this.companyComboBox.ValueMember = "Id";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementSystemUI.Model.Company);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(217, 67);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(208, 26);
            this.categoryComboBox.TabIndex = 9;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystemUI.Model.Category);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Item Name";
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemBindingSource;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(217, 107);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(208, 26);
            this.itemComboBox.TabIndex = 19;
            this.itemComboBox.ValueMember = "Id";
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(StockManagementSystemUI.Model.Item);
            // 
            // reOrderLabel
            // 
            this.reOrderLabel.AutoSize = true;
            this.reOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reOrderLabel.Location = new System.Drawing.Point(214, 152);
            this.reOrderLabel.Name = "reOrderLabel";
            this.reOrderLabel.Size = new System.Drawing.Size(55, 18);
            this.reOrderLabel.TabIndex = 20;
            this.reOrderLabel.Text = "<view>";
            // 
            // availableQuantityLabel
            // 
            this.availableQuantityLabel.AutoSize = true;
            this.availableQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableQuantityLabel.Location = new System.Drawing.Point(214, 182);
            this.availableQuantityLabel.Name = "availableQuantityLabel";
            this.availableQuantityLabel.Size = new System.Drawing.Size(55, 18);
            this.availableQuantityLabel.TabIndex = 21;
            this.availableQuantityLabel.Text = "<view>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Stock In Quantity";
            // 
            // stokInTextBox
            // 
            this.stokInTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokInTextBox.Location = new System.Drawing.Point(217, 211);
            this.stokInTextBox.Name = "stokInTextBox";
            this.stokInTextBox.Size = new System.Drawing.Size(208, 24);
            this.stokInTextBox.TabIndex = 23;
            this.stokInTextBox.TextChanged += new System.EventHandler(this.stokInTextBox_TextChanged);
            this.stokInTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stokInTextBox_KeyPress);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(336, 253);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 31);
            this.CancelButton.TabIndex = 35;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stockInQuantitylevel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.stokInTextBox);
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.availableQuantityLabel);
            this.groupBox1.Controls.Add(this.companyComboBox);
            this.groupBox1.Controls.Add(this.reOrderLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.itemComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(125, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 303);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "StockIn";
            // 
            // stockInQuantitylevel
            // 
            this.stockInQuantitylevel.AutoSize = true;
            this.stockInQuantitylevel.Location = new System.Drawing.Point(402, 202);
            this.stockInQuantitylevel.Name = "stockInQuantitylevel";
            this.stockInQuantitylevel.Size = new System.Drawing.Size(0, 20);
            this.stockInQuantitylevel.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 36;
            this.label2.Text = "Company";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // stockInBindingSource
            // 
            this.stockInBindingSource.DataSource = typeof(StockManagementSystemUI.Model.StockIn);
            // 
            // stockInItemDataGridView
            // 
            this.stockInItemDataGridView.AllowUserToAddRows = false;
            this.stockInItemDataGridView.AllowUserToDeleteRows = false;
            this.stockInItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockInItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockInItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.ItemName,
            this.CompanyName,
            this.CategoryName,
            this.AvailableQuantity,
            this.dataGridViewTextBoxColumn1});
            this.stockInItemDataGridView.Location = new System.Drawing.Point(11, 333);
            this.stockInItemDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.stockInItemDataGridView.Name = "stockInItemDataGridView";
            this.stockInItemDataGridView.ReadOnly = true;
            this.stockInItemDataGridView.RowTemplate.Height = 24;
            this.stockInItemDataGridView.Size = new System.Drawing.Size(709, 153);
            this.stockInItemDataGridView.TabIndex = 37;
            this.stockInItemDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.stockInItemDataGridView_RowPostPaint);
            // 
            // Sl
            // 
            this.Sl.FillWeight = 30F;
            this.Sl.HeaderText = "SL";
            this.Sl.Name = "Sl";
            this.Sl.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.FillWeight = 101.7259F;
            this.ItemName.HeaderText = "Item";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.FillWeight = 101.7259F;
            this.CompanyName.HeaderText = "Company";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.FillWeight = 101.7259F;
            this.CategoryName.HeaderText = "Category";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.DataPropertyName = "AvailableQuantity";
            this.AvailableQuantity.FillWeight = 101.7259F;
            this.AvailableQuantity.HeaderText = "Available Quantity";
            this.AvailableQuantity.Name = "AvailableQuantity";
            this.AvailableQuantity.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Reorderlabel";
            this.dataGridViewTextBoxColumn1.FillWeight = 101.7259F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Reorder Label";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // StockInUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 497);
            this.Controls.Add(this.stockInItemDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockInUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.StockInUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInItemDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.Label reOrderLabel;
        private System.Windows.Forms.Label availableQuantityLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stokInTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource stockInBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView stockInItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label stockInQuantitylevel;
    }
}