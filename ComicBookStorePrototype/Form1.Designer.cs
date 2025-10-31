namespace ComicBookStorePrototype
{
    partial class ComicsForm
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
            ComicGridView = new DataGridView();
            SearchText = new TextBox();
            GenreFilterCBox = new ComboBox();
            SortByFilterComboBox = new ComboBox();
            GenreTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            SortOrderTextBox = new TextBox();
            SortOrderComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ComicGridView).BeginInit();
            SuspendLayout();
            // 
            // ComicGridView
            // 
            ComicGridView.AllowUserToOrderColumns = true;
            ComicGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ComicGridView.Location = new Point(12, 83);
            ComicGridView.Name = "ComicGridView";
            ComicGridView.RowHeadersWidth = 62;
            ComicGridView.Size = new Size(1079, 559);
            ComicGridView.TabIndex = 0;
            ComicGridView.CellFormatting += ComicGridView_CellFormatting;
            // 
            // SearchText
            // 
            SearchText.Location = new Point(29, 19);
            SearchText.Name = "SearchText";
            SearchText.Size = new Size(327, 31);
            SearchText.TabIndex = 1;
            SearchText.TextChanged += SearchText_TextChanged;
            // 
            // GenreFilterCBox
            // 
            GenreFilterCBox.BackColor = SystemColors.ScrollBar;
            GenreFilterCBox.FormattingEnabled = true;
            GenreFilterCBox.Location = new Point(426, 44);
            GenreFilterCBox.Name = "GenreFilterCBox";
            GenreFilterCBox.Size = new Size(654, 33);
            GenreFilterCBox.TabIndex = 2;
            GenreFilterCBox.SelectedIndexChanged += GenreFilterCBox_SelectedIndexChanged;
            // 
            // SortByFilterComboBox
            // 
            SortByFilterComboBox.BackColor = SystemColors.ScrollBar;
            SortByFilterComboBox.FormattingEnabled = true;
            SortByFilterComboBox.Location = new Point(1116, 44);
            SortByFilterComboBox.Name = "SortByFilterComboBox";
            SortByFilterComboBox.Size = new Size(285, 33);
            SortByFilterComboBox.TabIndex = 3;
            SortByFilterComboBox.SelectedIndexChanged += SortByFilterComboBox_SelectedIndexChanged;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(426, 7);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(150, 31);
            GenreTextBox.TabIndex = 4;
            GenreTextBox.Text = "Genres";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(1116, 7);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(244, 31);
            AuthorTextBox.TabIndex = 5;
            AuthorTextBox.Text = "Name or Year of publication";
            // 
            // SortOrderTextBox
            // 
            SortOrderTextBox.Location = new Point(1116, 109);
            SortOrderTextBox.Name = "SortOrderTextBox";
            SortOrderTextBox.Size = new Size(150, 31);
            SortOrderTextBox.TabIndex = 6;
            SortOrderTextBox.Text = "Sort by";
            // 
            // SortOrderComboBox
            // 
            SortOrderComboBox.BackColor = SystemColors.ScrollBar;
            SortOrderComboBox.FormattingEnabled = true;
            SortOrderComboBox.Location = new Point(1116, 160);
            SortOrderComboBox.Name = "SortOrderComboBox";
            SortOrderComboBox.Size = new Size(285, 33);
            SortOrderComboBox.TabIndex = 7;
            SortOrderComboBox.SelectedIndexChanged += SortOrderComboBox_SelectedIndexChanged;
            // 
            // ComicsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 654);
            Controls.Add(SortOrderComboBox);
            Controls.Add(SortOrderTextBox);
            Controls.Add(AuthorTextBox);
            Controls.Add(GenreTextBox);
            Controls.Add(SortByFilterComboBox);
            Controls.Add(GenreFilterCBox);
            Controls.Add(SearchText);
            Controls.Add(ComicGridView);
            Name = "ComicsForm";
            Text = "Form1";
            Load += ComicsForm_Load;
            ((System.ComponentModel.ISupportInitialize)ComicGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ComicGridView;
        private TextBox SearchText;
        private ComboBox GenreFilterCBox;
        private ComboBox SortByFilterComboBox;
        private TextBox GenreTextBox;
        private TextBox AuthorTextBox;
        private TextBox SortOrderTextBox;
        private ComboBox SortOrderComboBox;
    }
}
