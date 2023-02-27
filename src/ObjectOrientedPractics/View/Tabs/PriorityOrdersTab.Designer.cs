
namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.AmountDigitLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.ButtonsPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearOrderButton = new System.Windows.Forms.Button();
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonsPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AmountDigitLabel
            // 
            this.AmountDigitLabel.AutoSize = true;
            this.AmountDigitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountDigitLabel.Location = new System.Drawing.Point(492, 486);
            this.AmountDigitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountDigitLabel.Name = "AmountDigitLabel";
            this.AmountDigitLabel.Size = new System.Drawing.Size(27, 29);
            this.AmountDigitLabel.TabIndex = 54;
            this.AmountDigitLabel.Text = "0";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(493, 470);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(67, 17);
            this.AmountLabel.TabIndex = 53;
            this.AmountLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 16;
            this.OrderItemsListBox.Location = new System.Drawing.Point(9, 331);
            this.OrderItemsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderItemsListBox.MinimumSize = new System.Drawing.Size(553, 116);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(553, 116);
            this.OrderItemsListBox.TabIndex = 52;
            this.OrderItemsListBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderItemsLabel.Location = new System.Drawing.Point(9, 311);
            this.OrderItemsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(93, 17);
            this.OrderItemsLabel.TabIndex = 51;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // AddressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            this.AddressControl.Address = address1;
            this.AddressControl.Location = new System.Drawing.Point(0, 140);
            this.AddressControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.ReadOnly = false;
            this.AddressControl.Size = new System.Drawing.Size(571, 167);
            this.AddressControl.TabIndex = 50;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(80, 107);
            this.StatusComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusComboBox.MinimumSize = new System.Drawing.Size(132, 0);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(132, 24);
            this.StatusComboBox.TabIndex = 49;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTextBox.Location = new System.Drawing.Point(80, 36);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDTextBox.MinimumSize = new System.Drawing.Size(132, 20);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(132, 22);
            this.IDTextBox.TabIndex = 48;
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedTextBox.Location = new System.Drawing.Point(80, 71);
            this.CreatedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreatedTextBox.MinimumSize = new System.Drawing.Size(132, 20);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.Size = new System.Drawing.Size(132, 22);
            this.CreatedTextBox.TabIndex = 47;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(9, 111);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(52, 17);
            this.StatusLabel.TabIndex = 46;
            this.StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(9, 75);
            this.CreatedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(62, 17);
            this.CreatedLabel.TabIndex = 45;
            this.CreatedLabel.Text = "Created:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(9, 39);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(25, 17);
            this.IDLabel.TabIndex = 44;
            this.IDLabel.Text = "ID:";
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedOrderLabel.Location = new System.Drawing.Point(9, 11);
            this.SelectedOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(118, 17);
            this.SelectedOrderLabel.TabIndex = 43;
            this.SelectedOrderLabel.Text = "Selected Order";
            // 
            // ButtonsPanel2
            // 
            this.ButtonsPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonsPanel2.ColumnCount = 4;
            this.ButtonsPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.ButtonsPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.ButtonsPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.ButtonsPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.ButtonsPanel2.Controls.Add(this.AddItemButton, 0, 0);
            this.ButtonsPanel2.Controls.Add(this.RemoveItemButton, 2, 0);
            this.ButtonsPanel2.Controls.Add(this.ClearOrderButton, 3, 0);
            this.ButtonsPanel2.Location = new System.Drawing.Point(9, 533);
            this.ButtonsPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonsPanel2.Name = "ButtonsPanel2";
            this.ButtonsPanel2.RowCount = 1;
            this.ButtonsPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsPanel2.Size = new System.Drawing.Size(555, 55);
            this.ButtonsPanel2.TabIndex = 55;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddItemButton.Location = new System.Drawing.Point(4, 4);
            this.AddItemButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(147, 47);
            this.AddItemButton.TabIndex = 7;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveItemButton.Location = new System.Drawing.Point(247, 4);
            this.RemoveItemButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(147, 47);
            this.RemoveItemButton.TabIndex = 8;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearOrderButton.Location = new System.Drawing.Point(402, 4);
            this.ClearOrderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(149, 47);
            this.ClearOrderButton.TabIndex = 9;
            this.ClearOrderButton.Text = "Clear Order";
            this.ClearOrderButton.UseVisualStyleBackColor = true;
            this.ClearOrderButton.Click += new System.EventHandler(this.ClearOrderButton_Click);
            // 
            // PriorityOptionsLabel
            // 
            this.PriorityOptionsLabel.AutoSize = true;
            this.PriorityOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityOptionsLabel.Location = new System.Drawing.Point(324, 11);
            this.PriorityOptionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(121, 17);
            this.PriorityOptionsLabel.TabIndex = 56;
            this.PriorityOptionsLabel.Text = "Priority Options";
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(324, 39);
            this.DeliveryTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(98, 17);
            this.DeliveryTimeLabel.TabIndex = 57;
            this.DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(431, 36);
            this.DeliveryTimeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeliveryTimeComboBox.MinimumSize = new System.Drawing.Size(132, 0);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(132, 24);
            this.DeliveryTimeComboBox.TabIndex = 58;
            this.DeliveryTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryTimeComboBox_SelectedIndexChanged);
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeliveryTimeComboBox);
            this.Controls.Add(this.DeliveryTimeLabel);
            this.Controls.Add(this.PriorityOptionsLabel);
            this.Controls.Add(this.ButtonsPanel2);
            this.Controls.Add(this.AmountDigitLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.OrderItemsListBox);
            this.Controls.Add(this.OrderItemsLabel);
            this.Controls.Add(this.AddressControl);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.CreatedTextBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.SelectedOrderLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1031, 620);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(1031, 620);
            this.Load += new System.EventHandler(this.PriorityOrdersTab_Load);
            this.ButtonsPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmountDigitLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Label OrderItemsLabel;
        private Controls.AddressControl AddressControl;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel2;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearOrderButton;
        private System.Windows.Forms.Label PriorityOptionsLabel;
        private System.Windows.Forms.Label DeliveryTimeLabel;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
    }
}
