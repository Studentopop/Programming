
namespace ContactList
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectedContactGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.DeleteContactButton = new System.Windows.Forms.Button();
            this.SelectedContactGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedContactGroupBox
            // 
            this.SelectedContactGroupBox.Controls.Add(this.dateTimePicker);
            this.SelectedContactGroupBox.Controls.Add(this.VKTextBox);
            this.SelectedContactGroupBox.Controls.Add(this.PhoneTextBox);
            this.SelectedContactGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelectedContactGroupBox.Controls.Add(this.label4);
            this.SelectedContactGroupBox.Controls.Add(this.label3);
            this.SelectedContactGroupBox.Controls.Add(this.label2);
            this.SelectedContactGroupBox.Controls.Add(this.label1);
            this.SelectedContactGroupBox.Location = new System.Drawing.Point(346, 12);
            this.SelectedContactGroupBox.Name = "SelectedContactGroupBox";
            this.SelectedContactGroupBox.Size = new System.Drawing.Size(434, 169);
            this.SelectedContactGroupBox.TabIndex = 0;
            this.SelectedContactGroupBox.TabStop = false;
            this.SelectedContactGroupBox.Text = "Selected Contact";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(111, 61);
            this.dateTimePicker.MaxDate = new System.DateTime(2022, 6, 19, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1959, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(190, 27);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.Value = new System.DateTime(2022, 6, 19, 0, 0, 0, 0);
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(111, 133);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(190, 27);
            this.VKTextBox.TabIndex = 7;
            this.VKTextBox.TextChanged += new System.EventHandler(this.VKTextBox_TextChanged);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(111, 96);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(190, 27);
            this.PhoneTextBox.TabIndex = 6;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(111, 24);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(317, 27);
            this.FullNameTextBox.TabIndex = 4;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "vk.com:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date of Birth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.ItemHeight = 20;
            this.ContactsListBox.Location = new System.Drawing.Point(13, 12);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(327, 404);
            this.ContactsListBox.TabIndex = 1;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // AddContactButton
            // 
            this.AddContactButton.Image = global::ContactList.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddContactButton.Location = new System.Drawing.Point(13, 422);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(94, 42);
            this.AddContactButton.TabIndex = 2;
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            this.AddContactButton.MouseEnter += new System.EventHandler(this.AddContactButton_MouseEnter);
            this.AddContactButton.MouseLeave += new System.EventHandler(this.AddContactButton_MouseLeave);
            // 
            // DeleteContactButton
            // 
            this.DeleteContactButton.Image = global::ContactList.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.DeleteContactButton.Location = new System.Drawing.Point(246, 422);
            this.DeleteContactButton.Name = "DeleteContactButton";
            this.DeleteContactButton.Size = new System.Drawing.Size(94, 42);
            this.DeleteContactButton.TabIndex = 4;
            this.DeleteContactButton.UseVisualStyleBackColor = true;
            this.DeleteContactButton.Click += new System.EventHandler(this.DeleteContactButton_Click);
            this.DeleteContactButton.MouseEnter += new System.EventHandler(this.DeleteContactButton_MouseEnter);
            this.DeleteContactButton.MouseLeave += new System.EventHandler(this.DeleteContactButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 475);
            this.Controls.Add(this.DeleteContactButton);
            this.Controls.Add(this.AddContactButton);
            this.Controls.Add(this.ContactsListBox);
            this.Controls.Add(this.SelectedContactGroupBox);
            this.MinimumSize = new System.Drawing.Size(805, 522);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SelectedContactGroupBox.ResumeLayout(false);
            this.SelectedContactGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectedContactGroupBox;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.Button DeleteContactButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

