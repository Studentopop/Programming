
namespace Programming.View.Controls
{
    partial class MoviesControl
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
            this.FilmGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieRatingTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MovieReleaseTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MovieDurationTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MovieGenreTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MovieNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FindMovieButton = new System.Windows.Forms.Button();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.FilmGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilmGroupBox
            // 
            this.FilmGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FilmGroupBox.Controls.Add(this.MovieRatingTextBox);
            this.FilmGroupBox.Controls.Add(this.label8);
            this.FilmGroupBox.Controls.Add(this.MovieReleaseTextBox);
            this.FilmGroupBox.Controls.Add(this.label7);
            this.FilmGroupBox.Controls.Add(this.MovieDurationTextBox);
            this.FilmGroupBox.Controls.Add(this.label6);
            this.FilmGroupBox.Controls.Add(this.MovieGenreTextBox);
            this.FilmGroupBox.Controls.Add(this.label5);
            this.FilmGroupBox.Controls.Add(this.MovieNameTextBox);
            this.FilmGroupBox.Controls.Add(this.label4);
            this.FilmGroupBox.Controls.Add(this.FindMovieButton);
            this.FilmGroupBox.Controls.Add(this.MoviesListBox);
            this.FilmGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.FilmGroupBox.Location = new System.Drawing.Point(4, 0);
            this.FilmGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilmGroupBox.Name = "FilmGroupBox";
            this.FilmGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilmGroupBox.Size = new System.Drawing.Size(389, 465);
            this.FilmGroupBox.TabIndex = 2;
            this.FilmGroupBox.TabStop = false;
            this.FilmGroupBox.Text = "Movies";
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Location = new System.Drawing.Point(185, 277);
            this.MovieRatingTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(160, 27);
            this.MovieRatingTextBox.TabIndex = 18;
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.MovieRatingTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 255);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Rating:";
            // 
            // MovieReleaseTextBox
            // 
            this.MovieReleaseTextBox.Location = new System.Drawing.Point(185, 224);
            this.MovieReleaseTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovieReleaseTextBox.Name = "MovieReleaseTextBox";
            this.MovieReleaseTextBox.Size = new System.Drawing.Size(160, 27);
            this.MovieReleaseTextBox.TabIndex = 16;
            this.MovieReleaseTextBox.TextChanged += new System.EventHandler(this.MovieReleaseTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Release Year:";
            // 
            // MovieDurationTextBox
            // 
            this.MovieDurationTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MovieDurationTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MovieDurationTextBox.Location = new System.Drawing.Point(185, 168);
            this.MovieDurationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovieDurationTextBox.Name = "MovieDurationTextBox";
            this.MovieDurationTextBox.Size = new System.Drawing.Size(160, 27);
            this.MovieDurationTextBox.TabIndex = 14;
            this.MovieDurationTextBox.TextChanged += new System.EventHandler(this.MovieDurationTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Duration in Minutes:";
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Location = new System.Drawing.Point(185, 112);
            this.MovieGenreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(160, 27);
            this.MovieGenreTextBox.TabIndex = 12;
            this.MovieGenreTextBox.TextChanged += new System.EventHandler(this.MovieGenreTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Genre:";
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Location = new System.Drawing.Point(185, 55);
            this.MovieNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(160, 27);
            this.MovieNameTextBox.TabIndex = 10;
            this.MovieNameTextBox.TextChanged += new System.EventHandler(this.MovieNameTextBox_TextChanged);
            this.MovieNameTextBox.Enter += new System.EventHandler(this.MovieNameTextBox_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name:";
            // 
            // FindMovieButton
            // 
            this.FindMovieButton.Location = new System.Drawing.Point(185, 423);
            this.FindMovieButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FindMovieButton.Name = "FindMovieButton";
            this.FindMovieButton.Size = new System.Drawing.Size(100, 29);
            this.FindMovieButton.TabIndex = 8;
            this.FindMovieButton.Text = "Find";
            this.FindMovieButton.UseVisualStyleBackColor = true;
            this.FindMovieButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 20;
            this.MoviesListBox.Location = new System.Drawing.Point(8, 31);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(168, 424);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilmGroupBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(393, 465);
            this.FilmGroupBox.ResumeLayout(false);
            this.FilmGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FilmGroupBox;
        private System.Windows.Forms.TextBox MovieRatingTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MovieReleaseTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MovieDurationTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MovieGenreTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MovieNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FindMovieButton;
        private System.Windows.Forms.ListBox MoviesListBox;
    }
}
