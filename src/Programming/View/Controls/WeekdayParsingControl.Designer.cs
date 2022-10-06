
namespace Programming.View.Controls
{
    partial class WeekdayParsingControl
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
            this.ParsingFlag = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ValueParsing = new System.Windows.Forms.TextBox();
            this.LabelParsing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ParsingFlag
            // 
            this.ParsingFlag.AutoSize = true;
            this.ParsingFlag.Location = new System.Drawing.Point(18, 64);
            this.ParsingFlag.Name = "ParsingFlag";
            this.ParsingFlag.Size = new System.Drawing.Size(0, 20);
            this.ParsingFlag.TabIndex = 7;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(315, 27);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 34);
            this.ParseButton.TabIndex = 6;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ValueParsing
            // 
            this.ValueParsing.Location = new System.Drawing.Point(18, 32);
            this.ValueParsing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ValueParsing.Name = "ValueParsing";
            this.ValueParsing.Size = new System.Drawing.Size(288, 27);
            this.ValueParsing.TabIndex = 5;
            // 
            // LabelParsing
            // 
            this.LabelParsing.AutoSize = true;
            this.LabelParsing.Location = new System.Drawing.Point(17, 7);
            this.LabelParsing.Name = "LabelParsing";
            this.LabelParsing.Size = new System.Drawing.Size(158, 20);
            this.LabelParsing.TabIndex = 4;
            this.LabelParsing.Text = "Type value for parsing:";
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParsingFlag);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.ValueParsing);
            this.Controls.Add(this.LabelParsing);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(406, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ParsingFlag;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ValueParsing;
        private System.Windows.Forms.Label LabelParsing;
    }
}
