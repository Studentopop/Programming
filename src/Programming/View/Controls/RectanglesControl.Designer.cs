
namespace Programming.View.Controls
{
    partial class RectanglesControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CollisionTextBox = new System.Windows.Forms.TextBox();
            this.IdRectangleTextBox = new System.Windows.Forms.TextBox();
            this.CollisionLable = new System.Windows.Forms.Label();
            this.IdRectangle = new System.Windows.Forms.Label();
            this.YRectangleTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.XRectangleTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RectangleFindButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RectangleHeightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CollisionTextBox);
            this.groupBox1.Controls.Add(this.IdRectangleTextBox);
            this.groupBox1.Controls.Add(this.CollisionLable);
            this.groupBox1.Controls.Add(this.IdRectangle);
            this.groupBox1.Controls.Add(this.YRectangleTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.XRectangleTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.RectangleFindButton);
            this.groupBox1.Controls.Add(this.ColorTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RectangleWidthTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RectangleHeightTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RectanglesListBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 477);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rectangle";
            // 
            // CollisionTextBox
            // 
            this.CollisionTextBox.Location = new System.Drawing.Point(186, 379);
            this.CollisionTextBox.Name = "CollisionTextBox";
            this.CollisionTextBox.Size = new System.Drawing.Size(160, 27);
            this.CollisionTextBox.TabIndex = 47;
            this.CollisionTextBox.TextChanged += new System.EventHandler(this.CollisionTextBox_TextChanged);
            // 
            // IdRectangleTextBox
            // 
            this.IdRectangleTextBox.Location = new System.Drawing.Point(186, 51);
            this.IdRectangleTextBox.Name = "IdRectangleTextBox";
            this.IdRectangleTextBox.ReadOnly = true;
            this.IdRectangleTextBox.Size = new System.Drawing.Size(160, 27);
            this.IdRectangleTextBox.TabIndex = 46;
            this.IdRectangleTextBox.TextChanged += new System.EventHandler(this.IdRectangleTextBox_TextChanged);
            // 
            // CollisionLable
            // 
            this.CollisionLable.AutoSize = true;
            this.CollisionLable.Location = new System.Drawing.Point(185, 356);
            this.CollisionLable.Name = "CollisionLable";
            this.CollisionLable.Size = new System.Drawing.Size(69, 20);
            this.CollisionLable.TabIndex = 45;
            this.CollisionLable.Text = "Collision:";
            // 
            // IdRectangle
            // 
            this.IdRectangle.AutoSize = true;
            this.IdRectangle.Location = new System.Drawing.Point(186, 28);
            this.IdRectangle.Name = "IdRectangle";
            this.IdRectangle.Size = new System.Drawing.Size(25, 20);
            this.IdRectangle.TabIndex = 44;
            this.IdRectangle.Text = "id:";
            // 
            // YRectangleTextBox
            // 
            this.YRectangleTextBox.Location = new System.Drawing.Point(186, 326);
            this.YRectangleTextBox.Name = "YRectangleTextBox";
            this.YRectangleTextBox.ReadOnly = true;
            this.YRectangleTextBox.Size = new System.Drawing.Size(160, 27);
            this.YRectangleTextBox.TabIndex = 43;
            this.YRectangleTextBox.TextChanged += new System.EventHandler(this.YRectangleTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Y:";
            // 
            // XRectangleTextBox
            // 
            this.XRectangleTextBox.Location = new System.Drawing.Point(186, 273);
            this.XRectangleTextBox.Name = "XRectangleTextBox";
            this.XRectangleTextBox.ReadOnly = true;
            this.XRectangleTextBox.Size = new System.Drawing.Size(160, 27);
            this.XRectangleTextBox.TabIndex = 41;
            this.XRectangleTextBox.TextChanged += new System.EventHandler(this.XRectangleTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 20);
            this.label9.TabIndex = 40;
            this.label9.Text = "X:";
            // 
            // RectangleFindButton
            // 
            this.RectangleFindButton.Location = new System.Drawing.Point(186, 423);
            this.RectangleFindButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RectangleFindButton.Name = "RectangleFindButton";
            this.RectangleFindButton.Size = new System.Drawing.Size(100, 29);
            this.RectangleFindButton.TabIndex = 39;
            this.RectangleFindButton.Text = "Find";
            this.RectangleFindButton.UseVisualStyleBackColor = true;
            this.RectangleFindButton.TextChanged += new System.EventHandler(this.RectangleFindButton_TextChanged);
            this.RectangleFindButton.Click += new System.EventHandler(this.RectangleFindButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(186, 106);
            this.ColorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.ReadOnly = true;
            this.ColorTextBox.Size = new System.Drawing.Size(160, 27);
            this.ColorTextBox.TabIndex = 38;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Color:";
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(186, 163);
            this.RectangleWidthTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(160, 27);
            this.RectangleWidthTextBox.TabIndex = 36;
            this.RectangleWidthTextBox.TextChanged += new System.EventHandler(this.RectangleWidthTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Width:";
            // 
            // RectangleHeightTextBox
            // 
            this.RectangleHeightTextBox.Location = new System.Drawing.Point(186, 218);
            this.RectangleHeightTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            this.RectangleHeightTextBox.Size = new System.Drawing.Size(160, 27);
            this.RectangleHeightTextBox.TabIndex = 34;
            this.RectangleHeightTextBox.TextChanged += new System.EventHandler(this.RectangleHeightTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Height:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Location = new System.Drawing.Point(7, 28);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(168, 424);
            this.RectanglesListBox.TabIndex = 32;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(393, 484);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CollisionTextBox;
        private System.Windows.Forms.TextBox IdRectangleTextBox;
        private System.Windows.Forms.Label CollisionLable;
        private System.Windows.Forms.Label IdRectangle;
        private System.Windows.Forms.TextBox YRectangleTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox XRectangleTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RectangleFindButton;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RectangleWidthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RectangleHeightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
