﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.SelectedContactGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DateofBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.AddContactPictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteContactPictureBox = new System.Windows.Forms.PictureBox();
            this.SelectedContactGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteContactPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.ItemHeight = 20;
            this.ContactsListBox.Location = new System.Drawing.Point(12, 43);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(324, 444);
            this.ContactsListBox.TabIndex = 0;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // SelectedContactGroupBox
            // 
            this.SelectedContactGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedContactGroupBox.Controls.Add(this.DateofBirthTimePicker);
            this.SelectedContactGroupBox.Controls.Add(this.VKTextBox);
            this.SelectedContactGroupBox.Controls.Add(this.PhoneTextBox);
            this.SelectedContactGroupBox.Controls.Add(this.label4);
            this.SelectedContactGroupBox.Controls.Add(this.label3);
            this.SelectedContactGroupBox.Controls.Add(this.label2);
            this.SelectedContactGroupBox.Controls.Add(this.label1);
            this.SelectedContactGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelectedContactGroupBox.Location = new System.Drawing.Point(344, -3);
            this.SelectedContactGroupBox.MaximumSize = new System.Drawing.Size(480, 199);
            this.SelectedContactGroupBox.Name = "SelectedContactGroupBox";
            this.SelectedContactGroupBox.Size = new System.Drawing.Size(480, 163);
            this.SelectedContactGroupBox.TabIndex = 1;
            this.SelectedContactGroupBox.TabStop = false;
            this.SelectedContactGroupBox.Text = "Selected Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Search:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(74, 6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(262, 27);
            this.SearchTextBox.TabIndex = 9;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // DateofBirthTimePicker
            // 
            this.DateofBirthTimePicker.Location = new System.Drawing.Point(110, 58);
            this.DateofBirthTimePicker.MinDate = new System.DateTime(1900, 12, 31, 0, 0, 0, 0);
            this.DateofBirthTimePicker.Name = "DateofBirthTimePicker";
            this.DateofBirthTimePicker.Size = new System.Drawing.Size(211, 27);
            this.DateofBirthTimePicker.TabIndex = 8;
            this.DateofBirthTimePicker.Value = new System.DateTime(2022, 6, 22, 0, 0, 0, 0);
            this.DateofBirthTimePicker.ValueChanged += new System.EventHandler(this.DateofBirthTimePicker_ValueChanged);
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(109, 127);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(212, 27);
            this.VKTextBox.TabIndex = 7;
            this.VKTextBox.TextChanged += new System.EventHandler(this.VKTextBox_TextChanged);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(110, 91);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(211, 27);
            this.PhoneTextBox.TabIndex = 6;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "vk.com:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date of Birth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(110, 25);
            this.FullNameTextBox.MaximumSize = new System.Drawing.Size(346, 27);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(346, 27);
            this.FullNameTextBox.TabIndex = 0;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // AddContactPictureBox
            // 
            this.AddContactPictureBox.Image = global::ContactList.Properties.Resources.plus;
            this.AddContactPictureBox.Location = new System.Drawing.Point(342, 166);
            this.AddContactPictureBox.Name = "AddContactPictureBox";
            this.AddContactPictureBox.Size = new System.Drawing.Size(24, 24);
            this.AddContactPictureBox.TabIndex = 4;
            this.AddContactPictureBox.TabStop = false;
            this.AddContactPictureBox.Click += new System.EventHandler(this.AddContactPictureBox_Click);
            this.AddContactPictureBox.MouseEnter += new System.EventHandler(this.AddContactPictureBox_MouseEnter);
            this.AddContactPictureBox.MouseLeave += new System.EventHandler(this.AddContactPictureBox_MouseLeave);
            // 
            // DeleteContactPictureBox
            // 
            this.DeleteContactPictureBox.Image = global::ContactList.Properties.Resources.cancel;
            this.DeleteContactPictureBox.Location = new System.Drawing.Point(372, 166);
            this.DeleteContactPictureBox.Name = "DeleteContactPictureBox";
            this.DeleteContactPictureBox.Size = new System.Drawing.Size(24, 24);
            this.DeleteContactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DeleteContactPictureBox.TabIndex = 5;
            this.DeleteContactPictureBox.TabStop = false;
            this.DeleteContactPictureBox.Click += new System.EventHandler(this.DeleteContactPictureBox_Click);
            this.DeleteContactPictureBox.MouseEnter += new System.EventHandler(this.DeleteContactPictureBox_MouseEnter);
            this.DeleteContactPictureBox.MouseLeave += new System.EventHandler(this.DeleteContactPictureBox_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 499);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteContactPictureBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.AddContactPictureBox);
            this.Controls.Add(this.SelectedContactGroupBox);
            this.Controls.Add(this.ContactsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(852, 546);
            this.Name = "MainForm";
            this.Text = "ContactList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.SelectedContactGroupBox.ResumeLayout(false);
            this.SelectedContactGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteContactPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.GroupBox SelectedContactGroupBox;
        private System.Windows.Forms.DateTimePicker DateofBirthTimePicker;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.PictureBox AddContactPictureBox;
        private System.Windows.Forms.PictureBox DeleteContactPictureBox;
    }
}

