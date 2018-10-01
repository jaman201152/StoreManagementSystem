namespace StockManagementSystemUI.Category.UI
{
    partial class CetegoryFormUi
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.categoryDataGridView1 = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hiddenIdTextBox = new System.Windows.Forms.TextBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.searchDataGridViewTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(179, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(208, 22);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(179, 112);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(77, 29);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // categoryDataGridView1
            // 
            this.categoryDataGridView1.AllowUserToAddRows = false;
            this.categoryDataGridView1.AllowUserToDeleteRows = false;
            this.categoryDataGridView1.AutoGenerateColumns = false;
            this.categoryDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.categoryDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.nameDataGridViewTextBoxColumn});
            this.categoryDataGridView1.DataSource = this.categoryBindingSource;
            this.categoryDataGridView1.Location = new System.Drawing.Point(13, 241);
            this.categoryDataGridView1.Name = "categoryDataGridView1";
            this.categoryDataGridView1.ReadOnly = true;
            this.categoryDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryDataGridView1.Size = new System.Drawing.Size(727, 218);
            this.categoryDataGridView1.TabIndex = 7;
            this.categoryDataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.categoryDataGridView1_CellMouseDoubleClick);
            this.categoryDataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.categoryDataGridView1_RowPostPaint);
            // 
            // SL
            // 
            this.SL.FillWeight = 50F;
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(310, 112);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(77, 29);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hiddenIdTextBox);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(149, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 197);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Category";
            // 
            // hiddenIdTextBox
            // 
            this.hiddenIdTextBox.Location = new System.Drawing.Point(51, 96);
            this.hiddenIdTextBox.Name = "hiddenIdTextBox";
            this.hiddenIdTextBox.Size = new System.Drawing.Size(100, 24);
            this.hiddenIdTextBox.TabIndex = 14;
            this.hiddenIdTextBox.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystemUI.Model.Category);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search by Name";
            // 
            // searchDataGridViewTextBox
            // 
            this.searchDataGridViewTextBox.Location = new System.Drawing.Point(623, 215);
            this.searchDataGridViewTextBox.Name = "searchDataGridViewTextBox";
            this.searchDataGridViewTextBox.Size = new System.Drawing.Size(117, 20);
            this.searchDataGridViewTextBox.TabIndex = 15;
            this.searchDataGridViewTextBox.TextChanged += new System.EventHandler(this.searchDataGridViewTextBox_TextChanged);
            // 
            // CetegoryFormUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchDataGridViewTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.categoryDataGridView1);
            this.Name = "CetegoryFormUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CetegoryFormUi";
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView categoryDataGridView1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hiddenIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchDataGridViewTextBox;
    }
}