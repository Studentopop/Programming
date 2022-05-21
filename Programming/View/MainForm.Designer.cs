
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
            resources.ApplyResources(this.RectanglesTabPage, "RectanglesTabPage");
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            resources.ApplyResources(this.rectanglesCollisionControl1, "rectanglesCollisionControl1");
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            // 
            // ClassesTabPage
            // 
            resources.ApplyResources(this.ClassesTabPage, "ClassesTabPage");
            this.ClassesTabPage.Controls.Add(this.moviesControl1);
            this.ClassesTabPage.Controls.Add(this.RectangleGroupBox);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // moviesControl1
            // 
            resources.ApplyResources(this.moviesControl1, "moviesControl1");
            this.moviesControl1.Name = "moviesControl1";
            // 
            // RectangleGroupBox
            // 
            resources.ApplyResources(this.RectangleGroupBox, "RectangleGroupBox");
            this.RectangleGroupBox.Controls.Add(this.rectanglesControl1);
            this.RectangleGroupBox.Name = "RectangleGroupBox";
            this.RectangleGroupBox.TabStop = false;
            // 
            // rectanglesControl1
            // 
            resources.ApplyResources(this.rectanglesControl1, "rectanglesControl1");
            this.rectanglesControl1.Name = "rectanglesControl1";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnamsTabPage);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Controls.Add(this.RectanglesTabPage);
            resources.ApplyResources(this.TabControl, "TabControl");
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // EnamsTabPage
            // 
            this.EnamsTabPage.Controls.Add(this.SeasonGroupBox);
            this.EnamsTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnamsTabPage.Controls.Add(this.EnumGroupBox);
            resources.ApplyResources(this.EnamsTabPage, "EnamsTabPage");
            this.EnamsTabPage.Name = "EnamsTabPage";
            this.EnamsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.seasonHandleControl1);
            resources.ApplyResources(this.SeasonGroupBox, "SeasonGroupBox");
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.TabStop = false;
            // 
            // seasonHandleControl1
            // 
            resources.ApplyResources(this.seasonHandleControl1, "seasonHandleControl1");
            this.seasonHandleControl1.Name = "seasonHandleControl1";
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.weekdayParsingControl1);
            resources.ApplyResources(this.WeekdayGroupBox, "WeekdayGroupBox");
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.TabStop = false;
            // 
            // weekdayParsingControl1
            // 
            resources.ApplyResources(this.weekdayParsingControl1, "weekdayParsingControl1");
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.Controls.Add(this.enumerationsControl1);
            resources.ApplyResources(this.EnumGroupBox, "EnumGroupBox");
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.TabStop = false;
            // 
            // enumerationsControl1
            // 
            resources.ApplyResources(this.enumerationsControl1, "enumerationsControl1");
            this.enumerationsControl1.Name = "enumerationsControl1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.RectanglesTabPage.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.ClassesTabPage.PerformLayout();
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
