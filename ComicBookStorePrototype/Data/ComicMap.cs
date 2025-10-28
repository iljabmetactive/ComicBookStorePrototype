using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookStorePrototype.Data
{
    public class ComicMap : ClassMap<Comics>
    {
        public ComicMap()
        {
            Map(c => c.Title).Name("Title");
            Map(c => c.Name).Name("Name");
            Map(c => c.Role).Name("Role");
            Map(c => c.OtherNames).Name("Other names");
            Map(c => c.BLRecordID).Name("BL record ID");
            Map(c => c.ContentType).Name("Content type");
            Map(c => c.CountryOfPublication).Name("Country of publication");
            Map(c => c.Publisher).Name("Publisher");
            Map(c => c.DateOfPublication).Name("Date of publication");
            Map(c => c.Edition).Name("Edition");
            Map(c => c.Topics).Name("Topics");
            Map(c => c.Genre).Name("Genre");
            Map(c => c.Languages).Name("Languages");
        }

    }
}
