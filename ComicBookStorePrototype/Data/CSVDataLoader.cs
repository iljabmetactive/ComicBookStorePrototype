using ComicBookStorePrototype.Comic_functions;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicBookStorePrototype.Data
{
    public class CSVDataLoader : IComicLoad
    {
        private static string datasetPath = Path.Combine(
            Application.StartupPath,
            "Data",
            "names.csv"
        );
        private const int dataLimit = 100000;

        // Implement the instance method required by IComicLoad
        public List<Comics> LoadData()
        {
            using var reader = new StreamReader(datasetPath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Context.RegisterClassMap<ComicMap>();
            return csv.GetRecords<Comics>().Take(dataLimit).ToList();
        }

        // Retain the static method if needed elsewhere
        public static List<Comics> LoadDataStatic()
        {
            using var reader = new StreamReader(datasetPath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Context.RegisterClassMap<ComicMap>();
            return csv.GetRecords<Comics>().Take(dataLimit).ToList();
        }
    }
}
