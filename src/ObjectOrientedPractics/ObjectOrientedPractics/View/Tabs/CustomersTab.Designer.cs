
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SelectedCustomerPanel = new System.Windows.Forms.Panel();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.CustomersPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SelectedCustomerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomersPanel.Controls.Add(this.label1);
            this.CustomersPanel.Controls.Add(this.CustomersListBox);
            this.CustomersPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CustomersPanel.Location = new System.Drawing.Point(4, 4);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Size = new System.Drawing.Size(392, 559);
            this.CustomersPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 20;
            this.CustomersListBox.Location = new System.Drawing.Point(4, 28);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(385, 524);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonsPanel.Controls.Add(this.panel5);
            this.ButtonsPanel.Controls.Add(this.RemoveButton);
            this.ButtonsPanel.Controls.Add(this.AddButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(5, 569);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(392, 73);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(263, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(126, 62);
            this.panel5.TabIndex = 2;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(133, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(126, 62);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(4, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(126, 62);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SelectedCustomerPanel
            // 
            this.SelectedCustomerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SelectedCustomerPanel.Controls.Add(this.addressControl1);
            this.SelectedCustomerPanel.Controls.Add(this.FullNameTextBox);
            this.SelectedCustomerPanel.Controls.Add(this.IDTextBox);
            this.SelectedCustomerPanel.Controls.Add(this.label4);
            this.SelectedCustomerPanel.Controls.Add(this.label3);
            this.SelectedCustomerPanel.Controls.Add(this.label2);
            this.SelectedCustomerPanel.Location = new System.Drawing.Point(403, 4);
            this.SelectedCustomerPanel.Name = "SelectedCustomerPanel";
            this.SelectedCustomerPanel.Size = new System.Drawing.Size(545, 355);
            this.SelectedCustomerPanel.TabIndex = 2;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(88, 77);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(453, 27);
            this.FullNameTextBox.TabIndex = 7;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Location = new System.Drawing.Point(88, 44);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(198, 27);
            this.IDTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected Customer";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(403, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 274);
            this.panel1.TabIndex = 3;
            // 
            // addressControl1
            // 
            address1.Apartment = "None";
            address1.Building = "None";
            address1.City = "None";
            address1.Country = "None";
            address1.Index = 100000;
            address1.Street = "None";
            this.addressControl1.Address = address1;
            this.addressControl1.Location = new System.Drawing.Point(4, 110);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(559, 222);
            this.addressControl1.TabIndex = 8;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SelectedCustomerPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CustomersPanel);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(951, 642);
            this.CustomersPanel.ResumeLayout(false);
            this.CustomersPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.SelectedCustomerPanel.ResumeLayout(false);
            this.SelectedCustomerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CustomersPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel SelectedCustomerPanel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Controls.AddressControl addressControl1;
    }
}
