
namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ObjectOrientedPractics.Model.Address address2 = new ObjectOrientedPractics.Model.Address();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.label1 = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearOrderButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountDigitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddressControl
            // 
            address2.Apartment = "None";
            address2.Building = "None";
            address2.City = "None";
            address2.Country = "None";
            address2.Index = 100000;
            address2.Street = "None";
            this.AddressControl.Address = address2;
            this.AddressControl.Location = new System.Drawing.Point(0, 129);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.ReadOnly = false;
            this.AddressControl.Size = new System.Drawing.Size(690, 166);
            this.AddressControl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Order";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(4, 37);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(27, 20);
            this.v.TabIndex = 2;
            this.v.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Created:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(80, 34);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(151, 27);
            this.IDTextBox.TabIndex = 5;
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Location = new System.Drawing.Point(80, 67);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.ReadOnly = true;
            this.CreatedTextBox.Size = new System.Drawing.Size(151, 27);
            this.CreatedTextBox.TabIndex = 6;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(80, 100);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(151, 28);
            this.StatusComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 20;
            this.OrderItemsListBox.Location = new System.Drawing.Point(3, 321);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(675, 104);
            this.OrderItemsListBox.TabIndex = 9;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(0, 431);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(94, 29);
            this.AddItemButton.TabIndex = 10;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click_1);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Location = new System.Drawing.Point(137, 431);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(94, 29);
            this.RemoveItemButton.TabIndex = 11;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.Location = new System.Drawing.Point(591, 503);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(94, 29);
            this.ClearOrderButton.TabIndex = 12;
            this.ClearOrderButton.Text = "Clear Order";
            this.ClearOrderButton.UseVisualStyleBackColor = true;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(607, 431);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(71, 20);
            this.AmountLabel.TabIndex = 13;
            this.AmountLabel.Text = "Amount:";
            // 
            // PriorityOptionsLabel
            // 
            this.PriorityOptionsLabel.AutoSize = true;
            this.PriorityOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriorityOptionsLabel.Location = new System.Drawing.Point(428, 4);
            this.PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(124, 20);
            this.PriorityOptionsLabel.TabIndex = 14;
            this.PriorityOptionsLabel.Text = "Priority Options:";
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(534, 37);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(151, 28);
            this.DeliveryTimeComboBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Delivery time:";
            // 
            // AmountDigitLabel
            // 
            this.AmountDigitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountDigitLabel.AutoSize = true;
            this.AmountDigitLabel.Location = new System.Drawing.Point(616, 460);
            this.AmountDigitLabel.Name = "AmountDigitLabel";
            this.AmountDigitLabel.Size = new System.Drawing.Size(0, 20);
            this.AmountDigitLabel.TabIndex = 17;
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AmountDigitLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeliveryTimeComboBox);
            this.Controls.Add(this.PriorityOptionsLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ClearOrderButton);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.OrderItemsListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.CreatedTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.v);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressControl);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(688, 535);
            this.Load += new System.EventHandler(this.PriorityOrdersTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.AddressControl AddressControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearOrderButton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label PriorityOptionsLabel;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AmountDigitLabel;
    }
}
