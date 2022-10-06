
namespace Programming.View.Controls
{
    partial class SeasonHandleControl
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
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(2, 30);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(214, 28);
            this.SeasonComboBox.TabIndex = 12;
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(223, 25);
            this.SeasonButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(75, 35);
            this.SeasonButton.TabIndex = 11;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(2, 5);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(110, 20);
            this.SeasonLabel.TabIndex = 10;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // SeasonHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonComboBox);
            this.Controls.Add(this.SeasonButton);
            this.Controls.Add(this.SeasonLabel);
            this.Name = "SeasonHandleControl";
            this.Size = new System.Drawing.Size(304, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.Label SeasonLabel;
    }
}
