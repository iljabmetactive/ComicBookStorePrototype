using ComicBookStorePrototype.Comic_functions;
using ComicBookStorePrototype.Data;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace ComicBookStorePrototype
{
    /// <summary>
    ///Last thing that needs doing is adding a collum system that shows the first 5 collums and data within them and allowing the user to
    ///click a button that shows the rest of the collums as needed.
    ///after that you can work on refactoring the code to follow SOLID principles.
    ///
    /// </summary>
    public partial class ComicsForm : Form
    {
        public ComicsForm()
        {
            InitializeComponent();
        }

        List<Comics> _comic = new List<Comics>();

        private void ComicsForm_Load(object sender, EventArgs e)
        {
            _comic = Data.CSVDataLoader.LoadData();

            var genres = _comic
                .Where(c => !string.IsNullOrEmpty(c.Genre))
                .SelectMany(g => g.Genre.Split(','))
                .Select(g => g.Trim())
                .Where(g => g.Length > 0)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(g => g)
                .ToList();

            var Name = _comic
                .Where(c => !string.IsNullOrEmpty(c.Name))
                .SelectMany(g => g.Name.Split(','))
                .Select(g => g.Trim())
                .Where(g => g.Length > 0)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(g => g)
                .ToList();


            SortByFilterComboBox.Items.AddRange(new string[]
            {
                "Name",
                "Year of Publication",
            });
            SortByFilterComboBox.SelectedIndex = 0;

            SortOrderComboBox.Items.AddRange(new string[]
            {
                "Ascending",
                "Descending",
            });
            SortOrderComboBox.SelectedIndex = 0;


            GenreFilterCBox.DataSource = genres;
            GenreFilterCBox.SelectedIndex = 0; // optional, start with nothing selected

            ComicGridView.DataSource = _comic;



            ComicGridView.AutoGenerateColumns = true;

            ComicGridColumRowFilter();

            RefreshGrid();
        }




        private async void SearchText_TextChanged(object sender, EventArgs e)
        {
            int lengthBeforePause = SearchText.Text.Length;

            await Task.Delay(300);

            int lengthAfterPause = SearchText.Text.Length;

            if (lengthBeforePause == lengthAfterPause)
                RefreshGrid();
        }

        private void RefreshGrid()
        {
            if (_comic == null)
            {
                ComicGridView.DataSource = null;
                return;
            }

            string term = SearchText?.Text ?? string.Empty;
            var searchResult = _comic
                .Where(p => !string.IsNullOrEmpty(p?.Title) &&
                            p.Title.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            ComicGridView.DataSource = searchResult;
        }

        private void GenreFilterCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (GenreFilterCBox.SelectedItem == null)
            //{
            //    RefreshGrid();
            //    return;
            //}

            //string selectedGenre = GenreFilterCBox.SelectedItem.ToString();

            //var filtred = _comic
            //    .Where(c => !string.IsNullOrEmpty(c.Genre) && c.Genre.Contains(selectedGenre, StringComparison.OrdinalIgnoreCase))
            //    .ToList();

            //ComicGridView.DataSource = filtred;

            UpdateFilter();
        }

        private void SortByFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void SortOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void UpdateFilter()
        {
            var filtered = comicFilters.FilterByGenre(_comic, GenreFilterCBox.SelectedItem?.ToString() ?? string.Empty);
            var sorted = comicFilters.SortComics(
                filtered,
                SortByFilterComboBox.SelectedItem?.ToString() ?? string.Empty,
                SortOrderComboBox.SelectedItem?.ToString() == "Descending"
            );

            ComicGridView.DataSource = sorted.ToList();
        }

        //private void UpdateFilterResult()
        //{
        //    if (_comic == null || _comic.Count == 0)
        //    {
        //        RefreshGrid();
        //        return;
        //    }

        //    string selectedGenre = GenreFilterCBox.SelectedItem?.ToString();
        //    string sortBy = SortByFilterComboBox.SelectedItem?.ToString();
        //    string sortOrder = SortOrderComboBox.SelectedItem?.ToString();

        //    IEnumerable<Comics> filterComics = _comic;

        //    if (!string.IsNullOrEmpty(selectedGenre) && selectedGenre != "Show All")
        //    {
        //        filterComics = filterComics
        //            .Where(c => !string.IsNullOrEmpty(c.Genre) && c.Genre.Contains(selectedGenre, StringComparison.OrdinalIgnoreCase));
        //    }

        //    bool decending = sortOrder == "Descending";

        //    filterComics = sortBy switch
        //    {
        //        "Name" => decending
        //            ? filterComics.OrderByDescending(c => c.Name)
        //            : filterComics.OrderBy(c => c.Name),

        //        "Year of Publication" => decending
        //            ? filterComics.OrderByDescending(c => c.DateOfPublication)
        //            : filterComics.OrderBy(c => c.DateOfPublication),
        //        _ => filterComics

        //    };

        //    ComicGridView.DataSource = filterComics.ToList();
        //}



        private void ComicGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                e.Value = "Unknown";
                e.FormattingApplied = true;
            }
        }

        private void ComicGridColumRowFilter()
        {
            foreach (DataGridViewColumn column in ComicGridView.Columns)
            {
                column.Visible = false;
            }
            toggleColumnVisibilityBtn.Text = "Show More Columns";
            ComicGridView.Columns["Title"].Visible = true;
            ComicGridView.Columns["Name"].Visible = true;
            ComicGridView.Columns["Publisher"].Visible = true;
            ComicGridView.Columns["Genre"].Visible = true;
            ComicGridView.Columns["DateOfPublication"].Visible = true;
            ComicGridView.Columns["otherNames"].Visible = true;

        }

        bool areAllColumnsVisible = false;
        private void toggleColumnVisibilityBtn_Click(object sender, EventArgs e)
        {

            if (!areAllColumnsVisible)
            {
                foreach (DataGridViewColumn column in ComicGridView.Columns)
                {
                    column.Visible = true;
                }
                toggleColumnVisibilityBtn.Text = "Show Less Columns";
                areAllColumnsVisible = true;
            }
            else
            {
                ComicGridColumRowFilter();
                toggleColumnVisibilityBtn.Text = "Show All Columns";
                areAllColumnsVisible = false;
            }

        }

        private ComicFilters comicFilters = new ComicFilters();

    }
}
