using ComicBookStorePrototype.Data;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace ComicBookStorePrototype
{
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
            ComicGridView.DataSource = _comic;
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

        
    }
}
