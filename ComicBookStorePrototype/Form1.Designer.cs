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
            ((System.ComponentModel.ISupportInitialize)ComicGridView).BeginInit();
            SuspendLayout();
            // 
            // ComicGridView
            // 
            ComicGridView.AllowUserToOrderColumns = true;
            ComicGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ComicGridView.Location = new Point(12, 63);
            ComicGridView.Name = "ComicGridView";
            ComicGridView.RowHeadersWidth = 62;
            ComicGridView.Size = new Size(1169, 394);
            ComicGridView.TabIndex = 0;
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
            GenreFilterCBox.Location = new Point(425, 19);
            GenreFilterCBox.Name = "GenreFilterCBox";
            GenreFilterCBox.Size = new Size(654, 33);
            GenreFilterCBox.TabIndex = 2;
            GenreFilterCBox.SelectedIndexChanged += GenreFilterCBox_SelectedIndexChanged;
            // 
            // ComicsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 483);
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
    }
}
