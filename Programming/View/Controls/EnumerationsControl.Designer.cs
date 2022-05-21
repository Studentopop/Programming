
namespace Programming.View.Controls
{
    partial class EnumerationsControl
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
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.LabelEnumeration = new System.Windows.Forms.Label();
            this.LabelValue = new System.Windows.Forms.Label();
            this.LabelInt = new System.Windows.Forms.Label();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Colors",
            "EducationForm",
            "Genre",
            "Season",
            "Smartphones",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(8, 51);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(131, 184);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(198, 51);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(131, 184);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // LabelEnumeration
            // 
            this.LabelEnumeration.AutoSize = true;
            this.LabelEnumeration.Location = new System.Drawing.Point(7, 27);
            this.LabelEnumeration.Name = "LabelEnumeration";
            this.LabelEnumeration.Size = new System.Drawing.Size(149, 20);
            this.LabelEnumeration.TabIndex = 2;
            this.LabelEnumeration.Text = "Choose enumeration:";
            // 
            // LabelValue
            // 
            this.LabelValue.AutoSize = true;
            this.LabelValue.Location = new System.Drawing.Point(195, 27);
            this.LabelValue.Name = "LabelValue";
            this.LabelValue.Size = new System.Drawing.Size(100, 20);
            this.LabelValue.TabIndex = 3;
            this.LabelValue.Text = "Choose value:";
            // 
            // LabelInt
            // 
            this.LabelInt.AutoSize = true;
            this.LabelInt.Location = new System.Drawing.Point(381, 27);
            this.LabelInt.Name = "LabelInt";
            this.LabelInt.Size = new System.Drawing.Size(68, 20);
            this.LabelInt.TabIndex = 4;
            this.LabelInt.Text = "Int value:";
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(384, 50);
            this.IntTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(131, 27);
            this.IntTextBox.TabIndex = 5;
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.Controls.Add(this.IntTextBox);
            this.EnumGroupBox.Controls.Add(this.LabelInt);
            this.EnumGroupBox.Controls.Add(this.LabelValue);
            this.EnumGroupBox.Controls.Add(this.LabelEnumeration);
            this.EnumGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnumGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EnumGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumGroupBox.Size = new System.Drawing.Size(547, 247);
            this.EnumGroupBox.TabIndex = 1;
            this.EnumGroupBox.TabStop = false;
            this.EnumGroupBox.Text = "Enumerations";
            this.EnumGroupBox.Enter += new System.EventHandler(this.EnumGroupBox_Enter);
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumGroupBox);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(547, 261);
            this.EnumGroupBox.ResumeLayout(false);
            this.EnumGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label LabelEnumeration;
        private System.Windows.Forms.Label LabelValue;
        private System.Windows.Forms.Label LabelInt;
        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.GroupBox EnumGroupBox;
    }
}
