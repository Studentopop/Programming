﻿namespace ObjectOrientedPractics.View
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomerTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.CartsTabPage = new System.Windows.Forms.TabPage();
            this.CartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.OrdersTab = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.CustomerTabPage.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.CartsTabPage.SuspendLayout();
            this.OrdersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerTabPage
            // 
            this.CustomerTabPage.Controls.Add(this.CustomersTab);
            this.CustomerTabPage.Location = new System.Drawing.Point(4, 25);
            this.CustomerTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerTabPage.Name = "CustomerTabPage";
            this.CustomerTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.CustomerTabPage.Size = new System.Drawing.Size(1037, 621);
            this.CustomerTabPage.TabIndex = 1;
            this.CustomerTabPage.Text = "Customer";
            this.CustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTab.Location = new System.Drawing.Point(4, 4);
            this.CustomersTab.Margin = new System.Windows.Forms.Padding(5);
            this.CustomersTab.MinimumSize = new System.Drawing.Size(1031, 620);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Size = new System.Drawing.Size(1031, 620);
            this.CustomersTab.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTab);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 25);
            this.ItemsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.ItemsTabPage.Size = new System.Drawing.Size(1037, 621);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTab.Location = new System.Drawing.Point(4, 4);
            this.ItemsTab.Margin = new System.Windows.Forms.Padding(5);
            this.ItemsTab.MinimumSize = new System.Drawing.Size(1031, 620);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Size = new System.Drawing.Size(1031, 620);
            this.ItemsTab.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ItemsTabPage);
            this.TabControl.Controls.Add(this.CustomerTabPage);
            this.TabControl.Controls.Add(this.CartsTabPage);
            this.TabControl.Controls.Add(this.OrdersTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1045, 650);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.ItemsTab_ItemsChanged);
            // 
            // CartsTabPage
            // 
            this.CartsTabPage.Controls.Add(this.CartsTab);
            this.CartsTabPage.Location = new System.Drawing.Point(4, 25);
            this.CartsTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.CartsTabPage.Name = "CartsTabPage";
            this.CartsTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.CartsTabPage.Size = new System.Drawing.Size(1037, 621);
            this.CartsTabPage.TabIndex = 2;
            this.CartsTabPage.Text = "Carts";
            this.CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            this.CartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartsTab.Location = new System.Drawing.Point(4, 4);
            this.CartsTab.Margin = new System.Windows.Forms.Padding(5);
            this.CartsTab.MinimumSize = new System.Drawing.Size(1031, 620);
            this.CartsTab.Name = "CartsTab";
            this.CartsTab.Size = new System.Drawing.Size(1031, 620);
            this.CartsTab.TabIndex = 0;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Controls.Add(this.OrdersTab);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 25);
            this.OrdersTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.OrdersTabPage.Size = new System.Drawing.Size(1037, 621);
            this.OrdersTabPage.TabIndex = 3;
            this.OrdersTabPage.Text = "Orders";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersTab.Location = new System.Drawing.Point(4, 4);
            this.OrdersTab.Margin = new System.Windows.Forms.Padding(5);
            this.OrdersTab.MinimumSize = new System.Drawing.Size(1031, 620);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Size = new System.Drawing.Size(1031, 620);
            this.OrdersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 650);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.CustomerTabPage.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.CartsTabPage.ResumeLayout(false);
            this.OrdersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage CustomerTabPage;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage CartsTabPage;
        private Tabs.CustomersTab CustomersTab;
        private Tabs.ItemsTab ItemsTab;
        private Tabs.CartsTab CartsTab;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private Tabs.OrdersTab OrdersTab;
    }
}