
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            ObjectOrientedPractics.Model.Address address2 = new ObjectOrientedPractics.Model.Address();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.DiscountsListBox = new System.Windows.Forms.ListBox();
            this.AddDiscountButton = new System.Windows.Forms.Button();
            this.RemoveDiscountButton = new System.Windows.Forms.Button();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(465, 11);
            this.SelectedCustomerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(144, 17);
            this.SelectedCustomerLabel.TabIndex = 34;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(561, 75);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FullNameTextBox.MinimumSize = new System.Drawing.Size(132, 20);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(447, 22);
            this.FullNameTextBox.TabIndex = 29;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(475, 79);
            this.FullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(75, 17);
            this.FullNameLabel.TabIndex = 27;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(475, 43);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(25, 17);
            this.IDLabel.TabIndex = 26;
            this.IDLabel.Text = "ID:";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 16;
            this.CustomersListBox.Location = new System.Drawing.Point(8, 31);
            this.CustomersListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomersListBox.MinimumSize = new System.Drawing.Size(132, 24);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(439, 516);
            this.CustomersListBox.TabIndex = 23;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(9, 11);
            this.CustomersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(84, 17);
            this.CustomersLabel.TabIndex = 22;
            this.CustomersLabel.Text = "Customers";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.ColumnCount = 3;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsPanel.Controls.Add(this.RemoveButton, 1, 0);
            this.ButtonsPanel.Controls.Add(this.AddButton, 0, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(8, 555);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 1;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsPanel.Size = new System.Drawing.Size(440, 55);
            this.ButtonsPanel.TabIndex = 35;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(150, 4);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(138, 47);
            this.RemoveButton.TabIndex = 8;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(4, 4);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(138, 47);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTextBox.Location = new System.Drawing.Point(561, 39);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDTextBox.MinimumSize = new System.Drawing.Size(132, 20);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(188, 22);
            this.IDTextBox.TabIndex = 36;
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.AutoSize = true;
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(479, 107);
            this.IsPriorityCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(88, 21);
            this.IsPriorityCheckBox.TabIndex = 38;
            this.IsPriorityCheckBox.Text = "Is Priority";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            this.IsPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.AutoSize = true;
            this.DiscountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountsLabel.Location = new System.Drawing.Point(465, 306);
            this.DiscountsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(79, 17);
            this.DiscountsLabel.TabIndex = 39;
            this.DiscountsLabel.Text = "Discounts";
            // 
            // DiscountsListBox
            // 
            this.DiscountsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscountsListBox.FormattingEnabled = true;
            this.DiscountsListBox.ItemHeight = 16;
            this.DiscountsListBox.Location = new System.Drawing.Point(469, 326);
            this.DiscountsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DiscountsListBox.Name = "DiscountsListBox";
            this.DiscountsListBox.Size = new System.Drawing.Size(393, 112);
            this.DiscountsListBox.TabIndex = 40;
            // 
            // AddDiscountButton
            // 
            this.AddDiscountButton.Location = new System.Drawing.Point(871, 326);
            this.AddDiscountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddDiscountButton.Name = "AddDiscountButton";
            this.AddDiscountButton.Size = new System.Drawing.Size(139, 48);
            this.AddDiscountButton.TabIndex = 41;
            this.AddDiscountButton.Text = "Add";
            this.AddDiscountButton.UseVisualStyleBackColor = true;
            this.AddDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // RemoveDiscountButton
            // 
            this.RemoveDiscountButton.Location = new System.Drawing.Point(871, 382);
            this.RemoveDiscountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveDiscountButton.Name = "RemoveDiscountButton";
            this.RemoveDiscountButton.Size = new System.Drawing.Size(139, 48);
            this.RemoveDiscountButton.TabIndex = 42;
            this.RemoveDiscountButton.Text = "Remove";
            this.RemoveDiscountButton.UseVisualStyleBackColor = true;
            this.RemoveDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            // 
            // AddressControl
            // 
            address2.Apartment = "";
            address2.Building = "";
            address2.City = "";
            address2.Country = "";
            address2.Index = 100000;
            address2.Street = "";
            this.AddressControl.Address = address2;
            this.AddressControl.Location = new System.Drawing.Point(456, 135);
            this.AddressControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.ReadOnly = false;
            this.AddressControl.Size = new System.Drawing.Size(571, 167);
            this.AddressControl.TabIndex = 37;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveDiscountButton);
            this.Controls.Add(this.AddDiscountButton);
            this.Controls.Add(this.DiscountsListBox);
            this.Controls.Add(this.DiscountsLabel);
            this.Controls.Add(this.IsPriorityCheckBox);
            this.Controls.Add(this.AddressControl);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.SelectedCustomerLabel);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.CustomersLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1031, 620);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(1031, 620);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private Controls.AddressControl AddressControl;
        private System.Windows.Forms.CheckBox IsPriorityCheckBox;
        private System.Windows.Forms.Label DiscountsLabel;
        private System.Windows.Forms.ListBox DiscountsListBox;
        private System.Windows.Forms.Button AddDiscountButton;
        private System.Windows.Forms.Button RemoveDiscountButton;
    }
}
