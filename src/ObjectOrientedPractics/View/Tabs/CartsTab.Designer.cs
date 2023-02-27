namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.ButtonsPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountDigitLabel = new System.Windows.Forms.Label();
            this.TotalDigitLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.DiscountCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.DiscountAmountDigitLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.ButtonsPanel.SuspendLayout();
            this.ButtonsPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.Location = new System.Drawing.Point(9, 11);
            this.ItemsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(46, 17);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 16;
            this.ItemsListBox.Location = new System.Drawing.Point(8, 31);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemsListBox.MinimumSize = new System.Drawing.Size(439, 516);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(439, 516);
            this.ItemsListBox.TabIndex = 1;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.ColumnCount = 3;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsPanel.Controls.Add(this.AddToCartButton, 0, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(8, 555);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 1;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsPanel.Size = new System.Drawing.Size(440, 55);
            this.ButtonsPanel.TabIndex = 23;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddToCartButton.Location = new System.Drawing.Point(4, 4);
            this.AddToCartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(138, 47);
            this.AddToCartButton.TabIndex = 7;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerLabel.Location = new System.Drawing.Point(479, 46);
            this.CustomerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(81, 17);
            this.CustomerLabel.TabIndex = 24;
            this.CustomerLabel.Text = "Customer:";
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(565, 42);
            this.CustomerComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(440, 24);
            this.CustomerComboBox.TabIndex = 25;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartLabel.Location = new System.Drawing.Point(479, 85);
            this.CartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(38, 17);
            this.CartLabel.TabIndex = 26;
            this.CartLabel.Text = "Cart:";
            // 
            // CartListBox
            // 
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.ItemHeight = 16;
            this.CartListBox.Location = new System.Drawing.Point(479, 105);
            this.CartListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(527, 164);
            this.CartListBox.TabIndex = 27;
            // 
            // ButtonsPanel2
            // 
            this.ButtonsPanel2.ColumnCount = 4;
            this.ButtonsPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.ButtonsPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.ButtonsPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.ButtonsPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.ButtonsPanel2.Controls.Add(this.CreateOrderButton, 0, 0);
            this.ButtonsPanel2.Controls.Add(this.RemoveItemButton, 2, 0);
            this.ButtonsPanel2.Controls.Add(this.ClearCartButton, 3, 0);
            this.ButtonsPanel2.Location = new System.Drawing.Point(479, 322);
            this.ButtonsPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonsPanel2.Name = "ButtonsPanel2";
            this.ButtonsPanel2.RowCount = 1;
            this.ButtonsPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsPanel2.Size = new System.Drawing.Size(528, 55);
            this.ButtonsPanel2.TabIndex = 28;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateOrderButton.Location = new System.Drawing.Point(4, 4);
            this.CreateOrderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(139, 47);
            this.CreateOrderButton.TabIndex = 7;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveItemButton.Location = new System.Drawing.Point(235, 4);
            this.RemoveItemButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(139, 47);
            this.RemoveItemButton.TabIndex = 8;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearCartButton.Location = new System.Drawing.Point(382, 4);
            this.ClearCartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(142, 47);
            this.ClearCartButton.TabIndex = 9;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(936, 273);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(67, 17);
            this.AmountLabel.TabIndex = 29;
            this.AmountLabel.Text = "Amount:";
            // 
            // AmountDigitLabel
            // 
            this.AmountDigitLabel.AutoSize = true;
            this.AmountDigitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountDigitLabel.Location = new System.Drawing.Point(935, 289);
            this.AmountDigitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountDigitLabel.Name = "AmountDigitLabel";
            this.AmountDigitLabel.Size = new System.Drawing.Size(27, 29);
            this.AmountDigitLabel.TabIndex = 30;
            this.AmountDigitLabel.Text = "0";
            // 
            // TotalDigitLabel
            // 
            this.TotalDigitLabel.AutoSize = true;
            this.TotalDigitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalDigitLabel.Location = new System.Drawing.Point(863, 534);
            this.TotalDigitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalDigitLabel.Name = "TotalDigitLabel";
            this.TotalDigitLabel.Size = new System.Drawing.Size(27, 29);
            this.TotalDigitLabel.TabIndex = 32;
            this.TotalDigitLabel.Text = "0";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalLabel.Location = new System.Drawing.Point(864, 518);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(64, 17);
            this.TotalLabel.TabIndex = 31;
            this.TotalLabel.Text = "TOTAL:";
            // 
            // DiscountCheckedListBox
            // 
            this.DiscountCheckedListBox.FormattingEnabled = true;
            this.DiscountCheckedListBox.Location = new System.Drawing.Point(479, 448);
            this.DiscountCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DiscountCheckedListBox.Name = "DiscountCheckedListBox";
            this.DiscountCheckedListBox.Size = new System.Drawing.Size(231, 106);
            this.DiscountCheckedListBox.TabIndex = 33;
            this.DiscountCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.DiscountCheckedListBox_SelectedIndexChanged);
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.AutoSize = true;
            this.DiscountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountsLabel.Location = new System.Drawing.Point(479, 428);
            this.DiscountsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(84, 17);
            this.DiscountsLabel.TabIndex = 40;
            this.DiscountsLabel.Text = "Discounts:";
            // 
            // DiscountAmountDigitLabel
            // 
            this.DiscountAmountDigitLabel.AutoSize = true;
            this.DiscountAmountDigitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmountDigitLabel.Location = new System.Drawing.Point(863, 464);
            this.DiscountAmountDigitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiscountAmountDigitLabel.Name = "DiscountAmountDigitLabel";
            this.DiscountAmountDigitLabel.Size = new System.Drawing.Size(27, 29);
            this.DiscountAmountDigitLabel.TabIndex = 42;
            this.DiscountAmountDigitLabel.Text = "0";
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmountLabel.Location = new System.Drawing.Point(864, 448);
            this.DiscountAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(135, 17);
            this.DiscountAmountLabel.TabIndex = 41;
            this.DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DiscountAmountDigitLabel);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.DiscountsLabel);
            this.Controls.Add(this.DiscountCheckedListBox);
            this.Controls.Add(this.TotalDigitLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.AmountDigitLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ButtonsPanel2);
            this.Controls.Add(this.CartListBox);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ItemsLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1031, 620);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(1031, 620);
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel2;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label AmountDigitLabel;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Label TotalDigitLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.CheckedListBox DiscountCheckedListBox;
        private System.Windows.Forms.Label DiscountsLabel;
        private System.Windows.Forms.Label DiscountAmountDigitLabel;
        private System.Windows.Forms.Label DiscountAmountLabel;
    }
}