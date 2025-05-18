namespace Food_ordering_app
{
    partial class Form8
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
            this.searchByName = new System.Windows.Forms.Label();
            this.mealName = new System.Windows.Forms.Label();
            this.sortByPrice = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.maxPrice = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.maxPriceTextBox = new System.Windows.Forms.TextBox();
            this.minPriceTextBox = new System.Windows.Forms.TextBox();
            this.searchByNameBtn = new System.Windows.Forms.Button();
            this.searchByPriceCatBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.nameResultsGrid = new System.Windows.Forms.DataGridView();
            this.searchByCategoryPrice = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.sortOrderComboBox = new System.Windows.Forms.ComboBox();
            this.minPrice = new System.Windows.Forms.Label();
            this.priceCatResultsGrid = new System.Windows.Forms.DataGridView();
            this.orderNowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nameResultsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCatResultsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchByName
            // 
            this.searchByName.AutoSize = true;
            this.searchByName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByName.Location = new System.Drawing.Point(55, 25);
            this.searchByName.Name = "searchByName";
            this.searchByName.Size = new System.Drawing.Size(244, 27);
            this.searchByName.TabIndex = 0;
            this.searchByName.Text = "Search for Meal by Name";
            this.searchByName.Click += new System.EventHandler(this.label1_Click);
            // 
            // mealName
            // 
            this.mealName.AutoSize = true;
            this.mealName.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealName.Location = new System.Drawing.Point(56, 61);
            this.mealName.Name = "mealName";
            this.mealName.Size = new System.Drawing.Size(86, 20);
            this.mealName.TabIndex = 1;
            this.mealName.Text = "Meal Name";
            this.mealName.Click += new System.EventHandler(this.label2_Click);
            // 
            // sortByPrice
            // 
            this.sortByPrice.AutoSize = true;
            this.sortByPrice.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByPrice.Location = new System.Drawing.Point(56, 397);
            this.sortByPrice.Name = "sortByPrice";
            this.sortByPrice.Size = new System.Drawing.Size(95, 20);
            this.sortByPrice.TabIndex = 3;
            this.sortByPrice.Text = "Sort by price";
            this.sortByPrice.Click += new System.EventHandler(this.label4_Click);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(56, 358);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(69, 20);
            this.category.TabIndex = 4;
            this.category.Text = "Category";
            this.category.Click += new System.EventHandler(this.label5_Click);
            // 
            // maxPrice
            // 
            this.maxPrice.AutoSize = true;
            this.maxPrice.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPrice.Location = new System.Drawing.Point(478, 358);
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(76, 20);
            this.maxPrice.TabIndex = 5;
            this.maxPrice.Text = "Max Price";
            this.maxPrice.Click += new System.EventHandler(this.label6_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(148, 61);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // maxPriceTextBox
            // 
            this.maxPriceTextBox.Location = new System.Drawing.Point(560, 360);
            this.maxPriceTextBox.Name = "maxPriceTextBox";
            this.maxPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.maxPriceTextBox.TabIndex = 7;
            this.maxPriceTextBox.TextChanged += new System.EventHandler(this.maxPriceTextBox_TextChanged);
            // 
            // minPriceTextBox
            // 
            this.minPriceTextBox.Location = new System.Drawing.Point(357, 358);
            this.minPriceTextBox.Name = "minPriceTextBox";
            this.minPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.minPriceTextBox.TabIndex = 8;
            this.minPriceTextBox.TextChanged += new System.EventHandler(this.minPriceTextBox_TextChanged);
            // 
            // searchByNameBtn
            // 
            this.searchByNameBtn.Location = new System.Drawing.Point(531, 58);
            this.searchByNameBtn.Name = "searchByNameBtn";
            this.searchByNameBtn.Size = new System.Drawing.Size(126, 23);
            this.searchByNameBtn.TabIndex = 9;
            this.searchByNameBtn.Text = "Search by Name";
            this.searchByNameBtn.UseVisualStyleBackColor = true;
            this.searchByNameBtn.Click += new System.EventHandler(this.searchByNameBtn_Click);
            // 
            // searchByPriceCatBtn
            // 
            this.searchByPriceCatBtn.Location = new System.Drawing.Point(585, 398);
            this.searchByPriceCatBtn.Name = "searchByPriceCatBtn";
            this.searchByPriceCatBtn.Size = new System.Drawing.Size(75, 23);
            this.searchByPriceCatBtn.TabIndex = 10;
            this.searchByPriceCatBtn.Text = "Search";
            this.searchByPriceCatBtn.UseVisualStyleBackColor = true;
            this.searchByPriceCatBtn.Click += new System.EventHandler(this.searchByPriceCatBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(265, 645);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // nameResultsGrid
            // 
            this.nameResultsGrid.AllowUserToAddRows = false;
            this.nameResultsGrid.AllowUserToDeleteRows = false;
            this.nameResultsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameResultsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nameResultsGrid.BackgroundColor = System.Drawing.Color.White;
            this.nameResultsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameResultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nameResultsGrid.Location = new System.Drawing.Point(57, 99);
            this.nameResultsGrid.Name = "nameResultsGrid";
            this.nameResultsGrid.ReadOnly = true;
            this.nameResultsGrid.RowHeadersVisible = false;
            this.nameResultsGrid.RowHeadersWidth = 51;
            this.nameResultsGrid.RowTemplate.Height = 24;
            this.nameResultsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nameResultsGrid.Size = new System.Drawing.Size(600, 200);
            this.nameResultsGrid.TabIndex = 12;
            this.nameResultsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nameResultsGrid_CellContentClick);
            // 
            // searchByCategoryPrice
            // 
            this.searchByCategoryPrice.AutoSize = true;
            this.searchByCategoryPrice.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByCategoryPrice.Location = new System.Drawing.Point(55, 321);
            this.searchByCategoryPrice.Name = "searchByCategoryPrice";
            this.searchByCategoryPrice.Size = new System.Drawing.Size(360, 27);
            this.searchByCategoryPrice.TabIndex = 13;
            this.searchByCategoryPrice.Text = "Search for Meal by Category and Price";
            this.searchByCategoryPrice.Click += new System.EventHandler(this.searchByCategoryPrice_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(157, 358);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(104, 24);
            this.categoryComboBox.TabIndex = 14;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // sortOrderComboBox
            // 
            this.sortOrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortOrderComboBox.FormattingEnabled = true;
            this.sortOrderComboBox.Location = new System.Drawing.Point(157, 397);
            this.sortOrderComboBox.Name = "sortOrderComboBox";
            this.sortOrderComboBox.Size = new System.Drawing.Size(104, 24);
            this.sortOrderComboBox.TabIndex = 15;
            this.sortOrderComboBox.SelectedIndexChanged += new System.EventHandler(this.sortOrderComboBox_SelectedIndexChanged);
            // 
            // minPrice
            // 
            this.minPrice.AutoSize = true;
            this.minPrice.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPrice.Location = new System.Drawing.Point(277, 358);
            this.minPrice.Name = "minPrice";
            this.minPrice.Size = new System.Drawing.Size(74, 20);
            this.minPrice.TabIndex = 16;
            this.minPrice.Text = "Min Price";
            this.minPrice.Click += new System.EventHandler(this.label7_Click);
            // 
            // priceCatResultsGrid
            // 
            this.priceCatResultsGrid.AllowUserToAddRows = false;
            this.priceCatResultsGrid.AllowUserToDeleteRows = false;
            this.priceCatResultsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceCatResultsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.priceCatResultsGrid.BackgroundColor = System.Drawing.Color.White;
            this.priceCatResultsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.priceCatResultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceCatResultsGrid.Location = new System.Drawing.Point(57, 427);
            this.priceCatResultsGrid.Name = "priceCatResultsGrid";
            this.priceCatResultsGrid.ReadOnly = true;
            this.priceCatResultsGrid.RowHeadersVisible = false;
            this.priceCatResultsGrid.RowHeadersWidth = 51;
            this.priceCatResultsGrid.RowTemplate.Height = 24;
            this.priceCatResultsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.priceCatResultsGrid.Size = new System.Drawing.Size(600, 200);
            this.priceCatResultsGrid.TabIndex = 17;
            this.priceCatResultsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.priceCatResultsGrid_CellContentClick);
            // 
            // orderNowBtn
            // 
            this.orderNowBtn.BackColor = System.Drawing.Color.White;
            this.orderNowBtn.Location = new System.Drawing.Point(357, 645);
            this.orderNowBtn.Name = "orderNowBtn";
            this.orderNowBtn.Size = new System.Drawing.Size(75, 23);
            this.orderNowBtn.TabIndex = 0;
            this.orderNowBtn.Text = "Order Selected Meal";
            this.orderNowBtn.UseVisualStyleBackColor = false;
            this.orderNowBtn.Click += new System.EventHandler(this.orderNowBtn_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(742, 693);
            this.Controls.Add(this.orderNowBtn);
            this.Controls.Add(this.priceCatResultsGrid);
            this.Controls.Add(this.minPrice);
            this.Controls.Add(this.sortOrderComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.searchByCategoryPrice);
            this.Controls.Add(this.nameResultsGrid);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchByPriceCatBtn);
            this.Controls.Add(this.searchByNameBtn);
            this.Controls.Add(this.minPriceTextBox);
            this.Controls.Add(this.maxPriceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.maxPrice);
            this.Controls.Add(this.category);
            this.Controls.Add(this.sortByPrice);
            this.Controls.Add(this.mealName);
            this.Controls.Add(this.searchByName);
            this.Name = "Form8";
            this.Text = "Search for Meals";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nameResultsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceCatResultsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchByName;
        private System.Windows.Forms.Label mealName;
        private System.Windows.Forms.Label sortByPrice;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label maxPrice;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox maxPriceTextBox;
        private System.Windows.Forms.TextBox minPriceTextBox;
        private System.Windows.Forms.Button searchByNameBtn;
        private System.Windows.Forms.Button searchByPriceCatBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView nameResultsGrid;
        private System.Windows.Forms.Label searchByCategoryPrice;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox sortOrderComboBox;
        private System.Windows.Forms.Label minPrice;
        private System.Windows.Forms.DataGridView priceCatResultsGrid;
        private System.Windows.Forms.Button orderNowBtn;
    }
}