
namespace Programming.View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Controls.RectanglesCollisionControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.moviesControl1 = new Programming.View.Controls.MoviesControl();
            this.RectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.rectanglesControl1 = new Programming.View.Controls.RectanglesControl();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.EnamsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.seasonHandleControl1 = new Programming.View.Controls.SeasonHandleControl();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.weekdayParsingControl1 = new Programming.View.Controls.WeekdayParsingControl();
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.enumerationsControl1 = new Programming.View.Controls.EnumerationsControl();
            this.RectanglesTabPage.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.RectangleGroupBox.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.EnamsTabPage.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolTip
            // 
            this.ToolTip.AutomaticDelay = 50;
            this.ToolTip.ShowAlways = true;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 29);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(793, 500);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(783, 490);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClassesTabPage.Controls.Add(this.moviesControl1);
            this.ClassesTabPage.Controls.Add(this.RectangleGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 29);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassesTabPage.Size = new System.Drawing.Size(793, 466);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(400, 3);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(390, 461);
            this.moviesControl1.TabIndex = 1;
            // 
            // RectangleGroupBox
            // 
            this.RectangleGroupBox.Controls.Add(this.rectanglesControl1);
            this.RectangleGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RectangleGroupBox.Location = new System.Drawing.Point(3, 2);
            this.RectangleGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleGroupBox.Name = "RectangleGroupBox";
            this.RectangleGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleGroupBox.Size = new System.Drawing.Size(389, 462);
            this.RectangleGroupBox.TabIndex = 0;
            this.RectangleGroupBox.TabStop = false;
            this.RectangleGroupBox.Text = "Rectangles";
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(7, 26);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(382, 438);
            this.rectanglesControl1.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnamsTabPage);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Controls.Add(this.RectanglesTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(801, 533);
            this.TabControl.TabIndex = 0;
            // 
            // EnamsTabPage
            // 
            this.EnamsTabPage.Controls.Add(this.SeasonGroupBox);
            this.EnamsTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnamsTabPage.Controls.Add(this.EnumGroupBox);
            this.EnamsTabPage.Location = new System.Drawing.Point(4, 29);
            this.EnamsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnamsTabPage.Name = "EnamsTabPage";
            this.EnamsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnamsTabPage.Size = new System.Drawing.Size(793, 466);
            this.EnamsTabPage.TabIndex = 0;
            this.EnamsTabPage.Text = "Enums";
            this.EnamsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.seasonHandleControl1);
            this.SeasonGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SeasonGroupBox.Location = new System.Drawing.Point(401, 251);
            this.SeasonGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Size = new System.Drawing.Size(389, 213);
            this.SeasonGroupBox.TabIndex = 2;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // seasonHandleControl1
            // 
            this.seasonHandleControl1.Location = new System.Drawing.Point(6, 25);
            this.seasonHandleControl1.Name = "seasonHandleControl1";
            this.seasonHandleControl1.Size = new System.Drawing.Size(380, 81);
            this.seasonHandleControl1.TabIndex = 0;
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.weekdayParsingControl1);
            this.WeekdayGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.WeekdayGroupBox.Location = new System.Drawing.Point(3, 251);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(389, 213);
            this.WeekdayGroupBox.TabIndex = 1;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(-7, 25);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(414, 114);
            this.weekdayParsingControl1.TabIndex = 0;
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.Controls.Add(this.enumerationsControl1);
            this.EnumGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnumGroupBox.Location = new System.Drawing.Point(3, 2);
            this.EnumGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumGroupBox.Size = new System.Drawing.Size(787, 249);
            this.EnumGroupBox.TabIndex = 0;
            this.EnumGroupBox.TabStop = false;
            this.EnumGroupBox.Text = "Enumerations";
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Location = new System.Drawing.Point(0, 0);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(790, 244);
            this.enumerationsControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 533);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.RectanglesTabPage.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.RectangleGroupBox.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.EnamsTabPage.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.ResumeLayout(false);
            this.EnumGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.TabControl TabControl;
        private Controls.RectanglesCollisionControl rectanglesCollisionControl1;
        private System.Windows.Forms.GroupBox RectangleGroupBox;
        private Controls.RectanglesControl rectanglesControl1;
        private Controls.MoviesControl moviesControl1;
        private System.Windows.Forms.TabPage EnamsTabPage;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private Controls.SeasonHandleControl seasonHandleControl1;
        private Controls.WeekdayParsingControl weekdayParsingControl1;
        private System.Windows.Forms.GroupBox EnumGroupBox;
        private Controls.EnumerationsControl enumerationsControl1;
    }
}
