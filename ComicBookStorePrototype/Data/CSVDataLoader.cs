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
    public static class CSVDataLoader
    {
            private static string datasetPath = Path.Combine(
                Application.StartupPath,
                "Data",
                "names.csv"
            );
            private const int dataLimit = 100000;

            public static List<Comics> LoadData()
            {
                using (var reader = new StreamReader(datasetPath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<ComicMap>();

                    var products = csv.GetRecords<Comics>().Take(dataLimit).ToList();

                    return products;
                }
            }

    }
}
